using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ScanStoreService.Features.ContractScans;
using ScanStoreService.Infrastructure.Errors;

namespace ScanStoreService.Features.ContractScans
{
    public class Files
    {
        public class Query : IRequest<IActionResult>
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
        public class QueryHandler : IRequestHandler<Query, IActionResult>
        {
            private readonly Domain.ScanStoreContext _context;


            public QueryHandler(Domain.ScanStoreContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Handle(Query message, CancellationToken cancellationToken)
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

                return new FileStreamResult(new FileStream(contractScans.Path, FileMode.Open), contractScans.Type);
            }
        }
    }
}
