using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScanStoreService.Domain;
using ScanStoreService.Features.ContractScans;
using ScanStoreService.Infrastructure;
using ScanStoreService.Infrastructure.Errors;

namespace ScanStoreService.Features.CessionScan
{
    public class CessionScansReader: ICessionScanReader
    {
        private readonly ScanStoreContext _context;
        private readonly ICurrentUserAccessor _currentUserAccessor;
        private readonly IMapper _mapper;

        public CessionScansReader(ScanStoreContext context, ICurrentUserAccessor currentUserAccessor, IMapper mapper)
        {
            _context = context;
            _currentUserAccessor = currentUserAccessor;
            _mapper = mapper;
        }
        public async Task<CessionScansEnvelope> ReadCessionScan(int cessionsId)
        {
            IQueryable<Domain.CessionScans> queryable = _context.CessionScans;

            var cessionScans = await queryable
                .Where(w => w.CessionId == cessionsId)
                .AsNoTracking()
                .ToListAsync();

            if (cessionScans == null)
            {
                throw new RestException(HttpStatusCode.NotFound, new { ContractScans = Constants.NOT_FOUND });
            }

            List<CessionScan> res = _mapper.Map<IEnumerable<Domain.CessionScans>, List<CessionScan>>(cessionScans);

            return new CessionScansEnvelope()
            {
                CessionScans = res,
                CessionScansCount = res.Count()
            };
        }
    }
}
