using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class AllCessions
    {
        public string PartnerName { get; set; }
        public string CessionName { get; set; }
        public DateTime CessionDate { get; set; }
        public int PartnerId { get; set; }
        public int CessionId { get; set; }
    }
}
