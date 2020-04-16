using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ScanList
    {
        public string PartnerName { get; set; }
        public string CessionName { get; set; }
        public string DebtorFio { get; set; }
        public string DebtNumber { get; set; }
        public int? IdHkd { get; set; }
        public long IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public long? Size { get; set; }
        public string FileName { get; set; }
        public string ScanType { get; set; }
    }
}
