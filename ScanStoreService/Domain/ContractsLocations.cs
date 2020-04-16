using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractsLocations
    {
        public int Id { get; set; }
        public int IdHkd { get; set; }
        public int CsType { get; set; }
        public string Keeper { get; set; }
        public string Сity { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public string IdContractScan { get; set; }
        public string Comment { get; set; }
        public bool ScanExist { get; set; }

        public virtual ContractRequestTypes CsTypeNavigation { get; set; }
        public virtual Contracts IdHkdNavigation { get; set; }
    }
}
