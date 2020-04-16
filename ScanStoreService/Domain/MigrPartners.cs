using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class MigrPartners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PartnerId { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
