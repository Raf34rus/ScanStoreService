using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractRequestTypesStatusVisible
    {
        public ContractRequestTypesStatusVisible()
        {
            ContractRequestTypes = new HashSet<ContractRequestTypes>();
        }

        public int Id { get; set; }
        public string Discript { get; set; }

        public virtual ICollection<ContractRequestTypes> ContractRequestTypes { get; set; }
    }
}
