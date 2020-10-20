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

namespace ScanStoreService.Features.ContractScans
{
    public class List
    {
        public class Query : IRequest<ContractScansEnvelope>
        {
            public Query(int contractid, int? type)
            {
                ContractId = contractid;
                Type = type;
            }
            public int ContractId { get; }
            public int? Type { get; }
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.ContractId).NotNull().NotEmpty();
            }
        }
        public class QueryHandler : IRequestHandler<Query, ContractScansEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;
            private readonly IMapper _mapper;

            public QueryHandler(Domain.ScanStoreContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ContractScansEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.ContractScans> queryable = _context.ContractScans;

                if (message.Type != null)
                {
                    queryable = queryable.Where(w => w.CsType == message.Type);
                }

                var contractScans = await queryable
                    .Where(w => w.ContractId == message.ContractId)
                    .AsNoTracking()
                    .ToListAsync(cancellationToken);

                if (contractScans == null && contractScans.Count() > 0)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { ContractScans = Constants.NOT_FOUND });
                }

                List<ContractScan> res = _mapper.Map<IEnumerable<Domain.ContractScans>, List<ContractScan>>(contractScans);

                return new ContractScansEnvelope()
                {
                    ContractScans = res,
                    ContractScansCount = res.Count()
                };               
            }
        }
    }
}
