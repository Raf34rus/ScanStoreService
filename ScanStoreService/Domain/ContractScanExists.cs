using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractScanExists
    {
        public ContractScanExists()
        {
            ContractScans = new HashSet<ContractScans>();
            LogInsContractScans = new HashSet<LogInsContractScans>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContractScans> ContractScans { get; set; }
        public virtual ICollection<LogInsContractScans> LogInsContractScans { get; set; }
        public virtual ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
    }
}
