using System.Threading.Tasks;
using ScanStoreService.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using ScanStoreService.Features.CessionScan;

namespace ScanStoreService.Features.Cessions
{
    [Route("Cessions")]
    public class CessionScanController
    {
        private readonly IMediator _mediator;
        public CessionScanController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("scans")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<CessionScansEnvelope> GetListScan(String name, DateTime date, int type)
        {
            return await _mediator.Send(new ListFind.Query(name, date, type));
        }
        [HttpGet("{id}/scans")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<CessionScansEnvelope> GetListScan(int id,int? type)
        {
            return await _mediator.Send(new List.Query(id, type));
        }
        [HttpGet("{id}/scans/{scanId}")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<CessionScanEnvelope> GetScan(int id, int scanId)
        {
            return await _mediator.Send(new Details.Query(id, scanId));
        }
        [HttpGet("{id}/scans/{scanId}/file")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<IActionResult> GetListFile(int id, int scanId)
        {
            return await _mediator.Send(new Files.Query(id, scanId));
        }
    }   
}
