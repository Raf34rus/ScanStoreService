using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwCessionTree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string PartnerName { get; set; }
        public int RootCessionId { get; set; }
        public int? Parentid { get; set; }
        public int? Level { get; set; }
        public string Rn { get; set; }
    }
}
