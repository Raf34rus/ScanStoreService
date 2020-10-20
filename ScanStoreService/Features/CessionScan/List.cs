using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScanStoreService.Features.ContractScans;
using ScanStoreService.Infrastructure.Errors;

namespace ScanStoreService.Features.CessionScan
{
    public class List
    {
        public class Query : IRequest<CessionScansEnvelope>
        {
            public Query(int cessionId, int? type)
            {
                CessionId = cessionId;
                Type = type;
            }
            public int CessionId { get; }
            public int? Type { get; } // попросили добавить на будущее, что бы потом не выкатывать версию на стороне 1С
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.CessionId).NotNull().NotEmpty();
            }
        }
        public class QueryHandler : IRequestHandler<Query, CessionScansEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;
            private readonly ICessionScanReader _cessionScanReader;

            public QueryHandler(Domain.ScanStoreContext context, ICessionScanReader cessionScanReader)
            {
                _context = context;
                _cessionScanReader = cessionScanReader;
            }

            public async Task<CessionScansEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                return await _cessionScanReader.ReadCessionScan(message.CessionId);
            }
        }
    }
}
