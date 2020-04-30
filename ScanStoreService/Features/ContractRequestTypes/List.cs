using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ScanStoreService.Domain;
using ScanStoreService.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ScanStoreService.Features.ContractRequestTypes
{
    public class List
    {
        public class Query : IRequest<ContractRequestTypesEnvelope>
        {
        }

        public class QueryHandler : IRequestHandler<Query, ContractRequestTypesEnvelope>
        {
            private readonly Domain.ScanStoreContext _context;

            public QueryHandler(Domain.ScanStoreContext context)
            {
                _context = context;
                _context.ChangeTracker.LazyLoadingEnabled = false;
            }

            public async Task<ContractRequestTypesEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.ContractRequestTypes> queryable = _context.ContractRequestTypes;
                var contractRequestTypes = await queryable
                    .OrderBy(x => x.Id)
                    .AsNoTracking()
                    //.Select(s => new ContractRequestTypesView(s))
                    .ToListAsync(cancellationToken);

                return new ContractRequestTypesEnvelope()
                {
                    ContractRequestTypes = contractRequestTypes,
                    ContractRequestTypesCount = contractRequestTypes.Count()                    
                };
            }
        }
    }
}
