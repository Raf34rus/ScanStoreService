using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.CessionScan
{
    public class CessionScansEnvelope
    {
        public List<CessionScan> CessionScans { get; set; }
        public int CessionScansCount { get; set; }
    }
}
