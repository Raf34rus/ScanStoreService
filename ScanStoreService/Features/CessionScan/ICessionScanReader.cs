using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.CessionScan
{

    public interface ICessionScanReader
    {
        Task<CessionScansEnvelope> ReadCessionScan(int cessionsId);
    }
}
