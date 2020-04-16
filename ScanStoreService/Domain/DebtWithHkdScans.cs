using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class DebtWithHkdScans
    {
        public string CessionName { get; set; }
        public DateTime CessionDate { get; set; }
        public string PartnerName { get; set; }
        public long IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public string DebtNumber { get; set; }
        public string DebtorFio { get; set; }
        public int? ScanCountDoc { get; set; }
        public int? ScanCountLaw { get; set; }
        public int? ScanCountPts { get; set; }
        public int? ScanCountDot { get; set; }
        public int? ScanCount { get; set; }
    }
}
