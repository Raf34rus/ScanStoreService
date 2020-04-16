using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class Kuznecova
    {
        public int? IdHkd { get; set; }
        public string Filename { get; set; }
        public long? IdPkb { get; set; }
        public string NewKeeper { get; set; }
        public string NewCity { get; set; }
        public string NewParty { get; set; }
        public string NewBox { get; set; }
        public string NewFolder { get; set; }
        public byte? NewExist { get; set; }
        public DateTime? DeptDate { get; set; }
    }
}
