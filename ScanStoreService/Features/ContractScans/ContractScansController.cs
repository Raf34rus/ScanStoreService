using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using Microsoft.EntityFrameworkCore.Storage;

namespace ScanStoreService.Features.ContractScans
{
    [Route("Contracts")]
    public class ScansController : Controller
    {
        private readonly IMediator _mediator;
        public ScansController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("Pristav/{id}/scans")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ContractScansEnvelope> GetScan(int id, int? type)
        {
            return await _mediator.Send(new FindByPristav.Query(id, type));
        }
        [HttpGet("PKB/{id}/scans")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ContractScansEnvelope> GetScan(long id, int? type)
        {
            return await _mediator.Send(new FindByPKB.Query(id, type));
        }
        [HttpGet("{id}/scans")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ContractScansEnvelope> GetScans(int id, int? type)
        {
            return await _mediator.Send(new List.Query(id, type));
        }
        [HttpGet("{id}/scans/{scanId}")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ContractScanEnvelope> GetScan(int id, string scanId)
        {
            return await _mediator.Send(new Details.Query(id, scanId));
        }
        [HttpGet("{id}/scans/{scanId}/file")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<IActionResult> GetFile(int id, string scanId)
        {
            return await _mediator.Send(new Files.Query(id, scanId));
        }
    }
}
