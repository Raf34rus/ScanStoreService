using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;
using ScanStoreService.Infrastructure.Errors;

namespace ScanStoreService.Features.CessionScan
{
    public class Details
    {
        public class Query : IRequest<CessionScanEnvelope>
        {
            public Query(int cessionId, int scanId)
            {
                Id = scanId;
                CessionId = cessionId;
            }
            public int Id { get; }
            public int CessionId { get; }

        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.Id).NotNull().NotEmpty();
            }
        }
        public class QueryHandler : IRequestHandler<Query, CessionScanEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;
            private readonly IMapper _mapper;

            public QueryHandler(Domain.ScanStoreContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<CessionScanEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.CessionScans> queryable = _context.CessionScans;

                Domain.CessionScans cessionScan = await queryable
                    .Where(w => w.CessionId == message.CessionId && w.Id == message.Id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                if (cessionScan == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { CessionScans = Constants.NOT_FOUND });
                }

                var res = _mapper.Map<Domain.CessionScans, CessionScan>(cessionScan);

                return new CessionScanEnvelope(res);
            }
        }
    }
}
