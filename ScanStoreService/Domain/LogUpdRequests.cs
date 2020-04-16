using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LogUpdRequests
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int? IdReq { get; set; }
        public int? ReqStatus { get; set; }
        public string Comment { get; set; }

        public virtual ServiceTasks IdTaskNavigation { get; set; }
    }
}
