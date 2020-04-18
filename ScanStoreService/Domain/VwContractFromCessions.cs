using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractFromCessions
    {
        public int PartnerId { get; set; }
        public int CessionId { get; set; }
        public string Partners { get; set; }
        public string Cessions { get; set; }
        public DateTime CessDate { get; set; }
        public int IdHkd { get; set; }
        public long? IdClient { get; set; }
        public long IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public string DeptNumber { get; set; }
        public DateTime? DeptDate { get; set; }
        public string DeptFio { get; set; }
        public string KeeperKd { get; set; }
        public string LocationKd { get; set; }
        public string LocationLawyer { get; set; }
        public string LocationDocket { get; set; }
        public string LocationPts { get; set; }
        public string LocationIl { get; set; }
        public int? CountScanContracts { get; set; }
        public int? CountScanSud { get; set; }
        public int? CountScanPts { get; set; }
        public int? CountScanVipiska { get; set; }
        public int? CountScanIl { get; set; }
        public string Auditing { get; set; }
        public string Avtocredit { get; set; }
        public string IsAssigment { get; set; }
        public double? Balance { get; set; }
    }
}
