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

namespace ScanStoreService.Features.ContractRequests
{
    public class Create
    {
        public class ReqData
        {
            public string Req_tp { get; set; }
            public string Com { get; set; }
        }

        public class ReqDataValidator : AbstractValidator<ReqData>
        {
            public ReqDataValidator()
            {
                RuleFor(x => x.Req_tp).NotNull().NotEmpty();
                RuleFor(x => x.Com).NotNull().NotEmpty();
            }
        }

        public class ContractRequestData
        {
            public string Id { get; set; }
            public string IdPkb { get; set; }
            public string Fio { get; set; }
            public ReqData[] ReqList { get; set; }
        }

        public class ContractRequestDataValidator : AbstractValidator<ContractRequestData>
        {
            public ContractRequestDataValidator()
            {                
                RuleFor(x => x.Id).NotNull().NotEmpty();
                RuleFor(x => x.IdPkb).NotNull().NotEmpty();
                RuleFor(x => x.Fio).NotNull().NotEmpty();
                RuleFor(x => x.ReqList).NotNull().NotEmpty();
                //RuleFor(x => x.ReqList).NotNull().SetValidator(new ReqDataValidator());
            }
        }

        public class Command : IRequest<ContractRequestEnvelope>
        {
            public ContractRequestData ContractRequest { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.ContractRequest).NotNull().SetValidator(new ContractRequestDataValidator());
            }
        }

        public class Handler : IRequestHandler<Command, ContractRequestEnvelope>
        {
            private readonly ScanStoreContext _context;
            private readonly ICurrentUserAccessor _currentUserAccessor;

            public Handler(ScanStoreContext context, ICurrentUserAccessor currentUserAccessor)
            {
                _context = context;
                _currentUserAccessor = currentUserAccessor;
            }

            public async Task<ContractRequestEnvelope> Handle(Command message, CancellationToken cancellationToken)
            {
                //var author = await _context.Persons.FirstAsync(x => x.Username == _currentUserAccessor.GetCurrentUsername(), cancellationToken);
                var contractRequests = new List<ContractRequess>();
                foreach (var req in (message.ContractRequest.ReqList ?? Enumerable.Empty<ReqData>()))
                {
                    var t = await _context.ContractRequess.Where(x => x.ReqType == Int32.Parse(req.Req_tp) && x.IdBit == message.ContractRequest.Id).FirstOrDefaultAsync();
                    if (t == null)
                    {
                        t = new ContractRequess()
                        {
                            IdBit = message.ContractRequest.Id,
                            ReqType = 1,//Int32.Parse(req.Req_tp),
                            RequestComment = req.Com,
                            ArchivistComment = "",
                            RequestUser = "From1cBIT",
                            RequestUserFio = message.ContractRequest.Fio,
                            IsUrgent = true,
                            ReqStatus = 3, //генерирование статуса основываясь на её местоположении                        
                            ContractId = 100,
                            RequestDate = DateTime.Now,
                            ReqComment = 1


                        };
                        contractRequests.Add(t);
                    }
                    //else Error? or add
                    await _context.ContractRequess.AddRangeAsync(contractRequests, cancellationToken);
                    //save immediately for reuse
                    try
                    {
                        await _context.SaveChangesAsync(cancellationToken);
                    } catch (Exception ex)
                    {
                        var tt = ex.Message;
                    }
                }

                return new ContractRequestEnvelope(contractRequests.FirstOrDefault());
            }
        }
    }

}
