using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class OfficeAddress
    {
        public OfficeAddress()
        {
            ContractRequess = new HashSet<ContractRequess>();
        }

        public int Id { get; set; }
        public int City { get; set; }
        public string Address { get; set; }

        public virtual OfficeCity CityNavigation { get; set; }
        public virtual ICollection<ContractRequess> ContractRequess { get; set; }
    }
}
