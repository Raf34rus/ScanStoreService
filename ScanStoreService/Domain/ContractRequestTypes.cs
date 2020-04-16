using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractRequestTypes
    {
        public ContractRequestTypes()
        {
            ContractRequess = new HashSet<ContractRequess>();
            ContractScans = new HashSet<ContractScans>();
            ContractsLocations = new HashSet<ContractsLocations>();
            LogInsContractScans = new HashSet<LogInsContractScans>();
            LogInsRequests = new HashSet<LogInsRequests>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VisibleStatus { get; set; }

        public virtual ContractRequestTypesStatusVisible VisibleStatusNavigation { get; set; }
        public virtual ICollection<ContractRequess> ContractRequess { get; set; }
        public virtual ICollection<ContractScans> ContractScans { get; set; }
        public virtual ICollection<ContractsLocations> ContractsLocations { get; set; }
        public virtual ICollection<LogInsContractScans> LogInsContractScans { get; set; }
        public virtual ICollection<LogInsRequests> LogInsRequests { get; set; }
        public virtual ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
    }
}
