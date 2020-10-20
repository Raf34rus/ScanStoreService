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

namespace ScanStoreService.Features.BitRequests
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

        public class BitRequestData
        {
            public string Id { get; set; }
            public string IdPkb { get; set; }
            public string Fio { get; set; }
            public ReqData[] ReqList { get; set; }
        }

        public class BitRequestDataValidator : AbstractValidator<BitRequestData>
        {
            public BitRequestDataValidator()
            {                
                RuleFor(x => x.Id).NotNull().NotEmpty();
                RuleFor(x => x.IdPkb).NotNull().NotEmpty();
                RuleFor(x => x.Fio).NotNull().NotEmpty();
                RuleFor(x => x.ReqList).NotNull().NotEmpty();
                //RuleFor(x => x.ReqList).NotNull().SetValidator(new ReqDataValidator());
            }
        }

        public class Command : IRequest<BitRequestEnvelope>
        {
            public BitRequestData BitRequest { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.BitRequest).NotNull().SetValidator(new BitRequestDataValidator());
            }
        }

        public class Handler : IRequestHandler<Command, BitRequestEnvelope>
        {
            private readonly ScanStoreContext _context;
            private readonly ICurrentUserAccessor _currentUserAccessor;

            public Handler(ScanStoreContext context, ICurrentUserAccessor currentUserAccessor)
            {
                _context = context;
                _currentUserAccessor = currentUserAccessor;
            }

            public async Task<BitRequestEnvelope> Handle(Command message, CancellationToken cancellationToken)
            {
                //var author = await _context.Persons.FirstAsync(x => x.Username == _currentUserAccessor.GetCurrentUsername(), cancellationToken);
                if (message.BitRequest.ReqList == null)
                    throw new ArgumentException($"Отсутствует список типов запрашиваемых документов");
                var checkContract = await _context.Contracts.Where(x => x.IdPkb == Int64.Parse(message.BitRequest.IdPkb)).FirstOrDefaultAsync();
                if (checkContract == null)
                    throw new ArgumentException($"Контракт ID {message.BitRequest.IdPkb} не найден в БД");
                var checkIdBit = await _context.BitRequests.Where(x => x.IdBit == message.BitRequest.Id).FirstOrDefaultAsync();
                if (checkIdBit != null)
                    throw new ArgumentException($"ID Bit {message.BitRequest.Id} уже существует в БД");

                var newBitRequest = new BitRequest()
                {
                    IdBit = message.BitRequest.Id,
                    IdPkb = Int64.Parse(message.BitRequest.IdPkb),
                    Status = BitRequestStatus.New,
                    ReqCount = message.BitRequest.ReqList.Count(),
                    Fio = message.BitRequest.Fio
                };

                foreach (var req in (message.BitRequest.ReqList ?? Enumerable.Empty<ReqData>()))
                {
                    var newRequestDetail = new ContractRequess(newBitRequest, checkContract.Id, Int32.Parse(req.Req_tp));
                    newBitRequest.ContractRequests.Add(newRequestDetail);
                    await _context.BitRequests.AddAsync(newBitRequest, cancellationToken);
                }

                try
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
                catch (Exception ex)
                {
                    var tt = ex.Message;
                }

                return new BitRequestEnvelope(newBitRequest);
            }
        }
    }
}
