using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractRequestCommentType
    {
        public ContractRequestCommentType()
        {
            ContractRequess = new HashSet<ContractRequess>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContractRequess> ContractRequess { get; set; }
    }
}
