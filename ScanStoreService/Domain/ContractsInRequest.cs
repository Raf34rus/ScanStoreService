using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractsInRequest
    {
        public int Id { get; set; }
        public int ContractRequessId { get; set; }
        public int OutsideRequessId { get; set; }

        public virtual ContractRequess ContractRequess { get; set; }
        public virtual OutsideRequess OutsideRequess { get; set; }
    }
}
