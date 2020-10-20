using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScanStoreService.Features.BitRequests
{
    [Route("Requests")]
    public class BitRequestsController
    {
        private readonly IMediator _mediator;

        public BitRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("1CBit")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<BitRequestEnvelope> Create([FromBody]Create.Command command)
        {
            return await _mediator.Send(command);
        }
        [HttpPost("1CBit/{id}/send")]
        //[Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<BitRequestEnvelope> Send(string id)
        {
            return await _mediator.Send(new Send.Query(id));
        }
    }
}
