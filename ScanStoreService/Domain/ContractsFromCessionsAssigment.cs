using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractsFromCessionsAssigment
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int CessionId { get; set; }

        public virtual Cessions Cession { get; set; }
        public virtual Contracts Contract { get; set; }
    }
}
