using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class StatusesCopy
    {
        public StatusesCopy()
        {
            CessionScans = new HashSet<CessionScans>();
            ContractScans = new HashSet<ContractScans>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CessionScans> CessionScans { get; set; }
        public virtual ICollection<ContractScans> ContractScans { get; set; }
    }
}
