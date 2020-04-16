using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ScanCount
    {
        public string ДоговораЦессии { get; set; }
        public DateTime ДатаЦессии { get; set; }
        public string Цедент { get; set; }
        public long IdPkb { get; set; }
        public string DebtNumber { get; set; }
        public string DebtorFio { get; set; }
        public int? ScanCount1 { get; set; }
    }
}
