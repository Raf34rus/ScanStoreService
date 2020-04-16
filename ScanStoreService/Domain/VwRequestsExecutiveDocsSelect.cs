using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwRequestsExecutiveDocsSelect
    {
        public Guid Csid { get; set; }
        public int Id { get; set; }
        public string Partner { get; set; }
        public string Cession { get; set; }
        public DateTime CessDate { get; set; }
        public string DebtNumber { get; set; }
        public string DebtorFio { get; set; }
        public long IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public int? ReqId { get; set; }
        public string ExistDocument { get; set; }
        public string FileName { get; set; }
    }
}
