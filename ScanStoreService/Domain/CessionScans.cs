using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class CessionScans
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public string Access { get; set; }
        public int? CessionId { get; set; }
        public int? Status1c { get; set; }
        public int? Migrate { get; set; }
        public Guid Giantguid { get; set; }
        public int? StatusCopy { get; set; }
        public string OldPath { get; set; }
        public DateTime DateLastUpdate { get; set; }

        public virtual Cessions Cession { get; set; }
        public virtual StatusesCopy StatusCopyNavigation { get; set; }
    }
}
