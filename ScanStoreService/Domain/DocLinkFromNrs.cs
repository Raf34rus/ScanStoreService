using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class DocLinkFromNrs
    {
        public int IdDocNrs { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public int? IdClient { get; set; }
        public int? IdDEaSubType { get; set; }
        public DateTime? DtUpd { get; set; }
        public int? IdNrs { get; set; }
        public DateTime? DtIns { get; set; }
        public int? RefinAgreementNumber { get; set; }
    }
}
