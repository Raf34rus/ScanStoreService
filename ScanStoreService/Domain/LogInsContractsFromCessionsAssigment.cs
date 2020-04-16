using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LogInsContractsFromCessionsAssigment
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int ContractId { get; set; }
        public int CessionId { get; set; }
        public int Status { get; set; }
        public string ErrMess { get; set; }

        public virtual ServiceTasks IdTaskNavigation { get; set; }
    }
}
