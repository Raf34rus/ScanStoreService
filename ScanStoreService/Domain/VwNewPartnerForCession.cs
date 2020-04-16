using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwNewPartnerForCession
    {
        public int Id { get; set; }
        public string PartnerName { get; set; }
        public int? NewPartnerId { get; set; }
        public string CessionName { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CommitDate { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public int? AssignmentCess { get; set; }
        public string PortfolioName { get; set; }
        public int? MigrPartnerId { get; set; }
    }
}
