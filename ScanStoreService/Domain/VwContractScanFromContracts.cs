using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractScanFromContracts
    {
        public int PartnerId { get; set; }
        public int CessionId { get; set; }
        public Guid CsId { get; set; }
        public string Partner { get; set; }
        public string Cession { get; set; }
        public int IdHkd { get; set; }
        public long? IdClient { get; set; }
        public int? IdPristav { get; set; }
        public long IdPkb { get; set; }
        public string DeptNumber { get; set; }
        public string DeptFio { get; set; }
        public string IsAssigment { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string CsType { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
