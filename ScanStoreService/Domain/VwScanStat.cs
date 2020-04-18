using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwScanStat
    {
        public int ContractId { get; set; }
        public int? CountScanContracts { get; set; }
        public int? CountScanSud { get; set; }
        public int? CountScanPts { get; set; }
        public int? CountScanVipiska { get; set; }
        public int? CountScanIl { get; set; }
        public int? DocExist { get; set; }
    }
}
