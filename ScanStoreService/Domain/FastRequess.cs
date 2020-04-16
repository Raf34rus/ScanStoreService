using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class FastRequess
    {
        public int Id { get; set; }
        public int ContractRequessId { get; set; }
        public int RequessResonId { get; set; }
        public string Descr { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public string Address { get; set; }
        public string CollectorFio { get; set; }
        public string BossEmail { get; set; }

        public virtual ContractRequess ContractRequess { get; set; }
        public virtual RequessReson RequessReson { get; set; }
    }
}
