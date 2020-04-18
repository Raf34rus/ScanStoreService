using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScanStoreService.Features.ContractRequests
{
    [Route("ContractRequests")]
    public class ContractRequestsController
    {
        private readonly IMediator _mediator;

        public ContractRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ContractRequestEnvelope> Create([FromBody]Create.Command command)
        {
            return await _mediator.Send(command);
        }

    }
}
