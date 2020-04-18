using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScanStoreService.Features.ContractRequestTypes
{
    [Route("ContractRequestTypes")]
    public class ContractRequestTypesController : Controller
    {
        private readonly IMediator _mediator;
        public ContractRequestTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ContractRequestTypesEnvelope> Get()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}
