using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class Contracts
    {
        public Contracts()
        {
            ContractRequess = new HashSet<ContractRequess>();
            ContractScans = new HashSet<ContractScans>();
            ContractsFromCessionsAssigment = new HashSet<ContractsFromCessionsAssigment>();
            ContractsLocations = new HashSet<ContractsLocations>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
        }

        public int Id { get; set; }
        public string DebtNumber { get; set; }
        public string DebtorFio { get; set; }
        public DateTime? DebtDate { get; set; }
        public string Location { get; set; }
        public int? CessionId { get; set; }
        public long IdPkb { get; set; }
        public string LocationAddress { get; set; }
        public DateTime? UploadDate { get; set; }
        public string LawyerAddress { get; set; }
        public string PtsAddress { get; set; }
        public int? IdPristav { get; set; }
        public string DocketAddress { get; set; }
        public int? IdNrs { get; set; }
        public int? IdStatus { get; set; }
        public string OriginalIlAdress { get; set; }
        public DateTime? LocationAddressUpdate { get; set; }
        public DateTime? LawyerAddressUpdate { get; set; }
        public DateTime? PtsAddressUpdate { get; set; }
        public DateTime? DocketAddressUpdate { get; set; }
        public DateTime? OriginalIlAdressUpdate { get; set; }
        public double? Balance { get; set; }
        public string EtcAddress { get; set; }
        public DateTime? EtcAddressUpdate { get; set; }
        public byte Auditing { get; set; }
        public byte Avtocredit { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public long? IdClient { get; set; }
        public byte IsAssigment { get; set; }

        public virtual ContractSigns AuditingNavigation { get; set; }
        public virtual ContractSigns AvtocreditNavigation { get; set; }
        public virtual Cessions Cession { get; set; }
        public virtual ContractSigns IsAssigmentNavigation { get; set; }
        public virtual ICollection<ContractRequess> ContractRequess { get; set; }
        public virtual ICollection<ContractScans> ContractScans { get; set; }
        public virtual ICollection<ContractsFromCessionsAssigment> ContractsFromCessionsAssigment { get; set; }
        public virtual ICollection<ContractsLocations> ContractsLocations { get; set; }
        public virtual ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
    }
}
