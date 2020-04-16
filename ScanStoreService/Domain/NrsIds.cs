using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class NrsIds
    {
        public int IdNrs { get; set; }
        public int? IdPristav { get; set; }
        public string Contract { get; set; }
        public DateTime? CreditDate { get; set; }
        public string IdPkb { get; set; }
        public string Partner { get; set; }
        public string Cession { get; set; }
        public long? IdClient { get; set; }
        public DateTime? PartnerDtIns { get; set; }
        public DateTime? CessionNumberDtIns { get; set; }
        public string CessionContractDate { get; set; }
        public string Status { get; set; }
        public string PortfolioName { get; set; }
    }
}
