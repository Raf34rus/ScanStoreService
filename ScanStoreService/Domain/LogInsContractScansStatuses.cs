using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LogInsContractScansStatuses
    {
        public LogInsContractScansStatuses()
        {
            LogInsContractScans = new HashSet<LogInsContractScans>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LogInsContractScans> LogInsContractScans { get; set; }
    }
}
