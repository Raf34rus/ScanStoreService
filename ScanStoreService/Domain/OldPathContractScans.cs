using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class OldPathContractScans
    {
        public Guid? IdScan { get; set; }
        public string OldPath { get; set; }
        public string NewPath { get; set; }
        public int? LenFile { get; set; }
        public int? ContractId { get; set; }
        public int? StatusCopy { get; set; }
        public string ErrorMess { get; set; }

        public virtual StatusesCopy StatusCopyNavigation { get; set; }
    }
}
