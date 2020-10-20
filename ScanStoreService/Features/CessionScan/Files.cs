using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;
using ScanStoreService.Infrastructure.Errors;

namespace ScanStoreService.Features.CessionScan
{
    public class Files
    {
        public class Query : IRequest<IActionResult>
        {
            public Query(int cessionId, int id)
            {
                Id = id;
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
        public class QueryHandler : IRequestHandler<Query, IActionResult>
        {
            private readonly Domain.ScanStoreContext _context;

            public QueryHandler(Domain.ScanStoreContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Handle(Query message, CancellationToken cancellationToken)
            {
                IQueryable<Domain.CessionScans> queryable = _context.CessionScans;

                var cessionScans = await queryable
                    .Where(w => w.CessionId == message.CessionId && w.Id == message.Id )
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                if (cessionScans == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { CessionScans = Constants.NOT_FOUND });
                }

                return new FileStreamResult(new FileStream(cessionScans.Path, FileMode.Open) , cessionScans.Type);
            }
        }
    }
}

