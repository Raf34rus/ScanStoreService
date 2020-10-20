using System;
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
    public class Details
    {        
        public class Query : IRequest<ContractScanEnvelope>
        {
            public Query(int contractid, string id)
            {
                ContractId = contractid;
                Id = id;
            }
            public string Id { get; }
            public int ContractId { get; }            
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.ContractId).NotNull().NotEmpty();
                RuleFor(x => x.Id).NotNull().NotEmpty();
            }
        }
        public class QueryHandler : IRequestHandler<Query, ContractScanEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;
            private readonly IMapper _mapper;

            public QueryHandler(Domain.ScanStoreContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ContractScanEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.ContractScans> queryable = _context.ContractScans;
                var guid = new Guid(message.Id);

                var contractScans = await queryable
                    .Where(w => w.ContractId == message.ContractId && w.Id == guid)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                if (contractScans == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { ContractScans = Constants.NOT_FOUND });
                }

                var contractScan = _mapper.Map<Domain.ContractScans, ContractScan>(contractScans);

                return new ContractScanEnvelope(contractScan);
            }
        }        
    }
}
