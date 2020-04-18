using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class Cessions
    {
        public Cessions()
        {
            CessionScans = new HashSet<CessionScans>();
            Contracts = new HashSet<Contracts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int PartnerId { get; set; }
        public string NewPrefix { get; set; }
        public DateTime? CommitDate { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public int? AssignmentCess { get; set; }

        public virtual Partners Partner { get; set; }
        public virtual ICollection<CessionScans> CessionScans { get; set; }
        public virtual ICollection<Contracts> Contracts { get; set; }
    }
}
