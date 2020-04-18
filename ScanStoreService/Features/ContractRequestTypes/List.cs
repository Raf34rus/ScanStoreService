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
            }

            public async Task<ContractRequestTypesEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {                              
                var contractRequestTypes = await _context.ContractRequestTypes
                    .OrderBy(x => x.Id)
                    .AsNoTracking()
                    .ToListAsync(cancellationToken);

                return new ContractRequestTypesEnvelope()
                {
                    ContractRequestTypes = contractRequestTypes.ToList(),
                    ContractRequestTypesCount = contractRequestTypes.Count()                    
                };
            }
        }
    }
}
