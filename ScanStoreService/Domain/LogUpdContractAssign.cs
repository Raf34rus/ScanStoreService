using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LogUpdContractAssign
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int IdHkd { get; set; }
        public byte IsAssign { get; set; }
        public int StatusUpdate { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMess { get; set; }

        public virtual ServiceTasks IdTaskNavigation { get; set; }
    }
}
