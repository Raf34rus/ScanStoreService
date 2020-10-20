using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Domain
{
    public partial class ContractRequestTypes
    {
    }

    public partial class ContractRequestTypesView
    {
        public ContractRequestTypesView (ContractRequestTypes contractRequestTypes)
        {
            Id = contractRequestTypes.Id;
            Name = contractRequestTypes.Name;
            Description = contractRequestTypes.Description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}

