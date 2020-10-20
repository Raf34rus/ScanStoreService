using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.CessionScan
{
    public class CessionScan
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public int? CessionId { get; set; }
        public Guid Giantguid { get; set; }
        public DateTime DateLastUpdate { get; set; }
    }

    public class CessionScanEnvelope
    {
        public CessionScanEnvelope(CessionScan cessionScan)
        {
            CessionScan = cessionScan;
        }

        public CessionScan CessionScan { get; }
    }
}
