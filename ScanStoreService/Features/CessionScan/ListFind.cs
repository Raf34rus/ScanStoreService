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
    public class ListFind
    {
        public class Query : IRequest<CessionScansEnvelope>
        {
            public Query(String name, DateTime date, int type)
            {
                Date = date;
                Name = name;
                Type = type;
            }
            public string Name { get; }
            public int Type { get; } // попросили добавить на будущее, что бы потом не выкатывать версию на стороне 1С
            public DateTime Date { get; }
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.Date).NotNull().NotEmpty();
                RuleFor(x => x.Name).NotNull().NotEmpty();
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
                IQueryable<Domain.Cessions> cession = _context.Cessions;
                var cessionId = await cession
                    .Where(w => w.Name == message.Name && w.Date == message.Date)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                if (cessionId == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { Cessions = Constants.NOT_FOUND });
                }

                return await _cessionScanReader.ReadCessionScan(cessionId.Id);
            }
        }
    }
}
