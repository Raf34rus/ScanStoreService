using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Errors;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ScanStoreService.Domain;
using ScanStoreService.Infrastructure;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace ScanStoreService.Features.BitRequests
{
    public class Send
    {
        public class Query : IRequest<BitRequestEnvelope>
        {
            public Query(string id)
            {
                Id = id;
            }
            public string Id { get;}
        }

        public class QueryHandler : IRequestHandler<Query, BitRequestEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;
            private readonly ICurrentUserAccessor _currentUserAccessor;

            public QueryHandler(Domain.ScanStoreContext context, ICurrentUserAccessor currentUserAccessor)
            {
                _context = context;
                _currentUserAccessor = currentUserAccessor;
            }

            public async Task<BitRequestEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.ContractScans> queryable = _context.ContractScans;
                var currentUsername = _currentUserAccessor.GetCurrentUsername();
                
                IQueryable<BitRequest> queryableRequest = _context.BitRequests;

                BitRequest requests = await queryableRequest    
                    .Include(x => x.ContractRequests)
                    .Where(w => w.IdBit == message.Id && w.Status != BitRequestStatus.Finished)                    
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                if (requests == null || requests.ContractRequests.Count() == 0)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { BitRequest = Constants.NOT_FOUND });
                }

                var notFinished = requests.ContractRequests.Where(w => w.FinishDate == null);
                if (notFinished != null)
                {
                    return new BitRequestEnvelope(requests);
                }

                IQueryable<Domain.ContractScans> queryableResult = _context.ContractScans;
                List<int?> contracts = requests.ContractRequests.Select(s => s.ContractId).ToList();
                List<int> types = requests.ContractRequests.Select(s => s.ReqType).ToList();

                List<BitFiles> result = await queryableResult
                    .Where(w => contracts.Contains(w.ContractId) && types.Contains(w.CsType) && w.ContractId != null)
                    .Select(s => new BitFiles(s))
                    .ToListAsync(cancellationToken);

                var jsonObj = JsonConvert.SerializeObject(result);
                ResponceBit responceBit = SendRestRequestBIT(jsonObj, requests.IdBit);                

                if (responceBit.code == HttpStatusCode.OK)
                {
                    try
                    {
                        requests.Status = BitRequestStatus.Finished;
                        await _context.SaveChangesAsync(cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        var tt = ex.Message;
                    }
                }
                else
                {
                    ContractRequestBitSendLog CRBSL = new ContractRequestBitSendLog();
                    CRBSL.RequestId = requests.ContractRequests.FirstOrDefault().Id;
                    CRBSL.DateSend = DateTime.Now;
                    CRBSL.HtmlCode = (int)responceBit.code;
                    CRBSL.Responce = responceBit.body;
                    CRBSL.StatusSend = false;
                    _context.ContractRequestBitSendLog.Add(CRBSL);
                    await _context.SaveChangesAsync(cancellationToken);
                }

                return new BitRequestEnvelope(requests);
            }
            public ResponceBit SendRestRequestBIT(string json_body, string bitId)
            {
                ResponceBit respBit = new ResponceBit();
                // боевой сервер 1С
                var lcUrl2 = "http://10.1.3.83/BIT_UZ/hs/hkd/ExecuteRequest?id=" + bitId;
                // тестовый сервер 1С:
                //var lcUrl2 = "http://10.1.3.83/Test_BIT/hs/hkd/ExecuteRequest?id=" + bitId;

                WebRequest Request2 = WebRequest.Create(lcUrl2);
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(new System.Uri(lcUrl2), "Basic", new NetworkCredential("ws", "ke/24JEFSuu"));
                Request2.Credentials = credentialCache;
                Request2.PreAuthenticate = true;
                Request2.Method = WebRequestMethods.Http.Post;
                Request2.ContentType = "application/json;charset=utf-8";
                using (var streamWriter = new StreamWriter(Request2.GetRequestStream()))
                {
                    streamWriter.Write(json_body);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                try
                {
                    HttpWebResponse Response2 = (HttpWebResponse)Request2.GetResponse();
                    respBit.code = Response2.StatusCode;

                    using (Stream stream = Response2.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            respBit.body = reader.ReadToEnd();
                        }
                    }
                    return respBit;
                }
                catch (WebException ex)
                {
                    if (ex.Response != null)
                    {
                        respBit.code = ((HttpWebResponse)ex.Response).StatusCode;
                        respBit.body = ((HttpWebResponse)ex.Response).ContentType;
                    }
                    else
                    {
                        respBit.body = ex.Message;                           
                    }
                    return respBit;
                }
            }
        }
    }
}

/*
 
            ResponceBit respBit = new ResponceBit();
            var lcUrl2 = "http://10.1.3.83/BIT_UZ/hs/hkd/ExecuteRequest?id=" + bitId;
            //var lcUrl2 = "http://10.1.3.83/Test_BIT/hs/hkd/ExecuteRequest?id=" + bitId;
            WebRequest Request2 = WebRequest.Create(lcUrl2);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new System.Uri(lcUrl2), "Basic", new NetworkCredential("ws", "ke/24JEFSuu"));
            Request2.Credentials = credentialCache;
            Request2.PreAuthenticate = true;
            Request2.Method = WebRequestMethods.Http.Post;
            Request2.ContentType = "application/json;charset=utf-8";
            using (var streamWriter = new StreamWriter(Request2.GetRequestStream()))
            {
                streamWriter.Write(json_body);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                
                HttpWebResponse Response2 = (HttpWebResponse)Request2.GetResponse();
                respBit.code = (int)Response2.StatusCode;

                using (Stream stream = Response2.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        respBit.body = reader.ReadToEnd();
                    }
                }
                return respBit;
            }
            catch(WebException ex)
            {
                respBit.code = (int)((HttpWebResponse)ex.Response).StatusCode;
                respBit.body = ((HttpWebResponse)ex.Response).ContentType;
                return respBit;
            }     
     
     */
