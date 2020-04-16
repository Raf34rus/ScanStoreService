using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractLocation
    {
        public int? ContractId { get; set; }
        public string LocationKd { get; set; }
        public string LocationLawyer { get; set; }
        public string LocationDocket { get; set; }
        public string LocationPts { get; set; }
        public string LocationIl { get; set; }
        public string KeeperKd { get; set; }
    }
}
