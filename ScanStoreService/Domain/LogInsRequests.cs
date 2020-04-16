using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LogInsRequests
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int? IdHkd { get; set; }
        public string RequestUser { get; set; }
        public int? ReqType { get; set; }
        public string Comment { get; set; }

        public virtual ServiceTasks IdTaskNavigation { get; set; }
        public virtual ContractRequestTypes ReqTypeNavigation { get; set; }
    }
}
