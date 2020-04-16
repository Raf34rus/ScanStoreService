using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class Partners
    {
        public Partners()
        {
            Cessions = new HashSet<Cessions>();
            MigrPartners = new HashSet<MigrPartners>();
            PartnerTemplates = new HashSet<PartnerTemplates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool PrimaryCreditor { get; set; }

        public virtual ICollection<Cessions> Cessions { get; set; }
        public virtual ICollection<MigrPartners> MigrPartners { get; set; }
        public virtual ICollection<PartnerTemplates> PartnerTemplates { get; set; }
    }
}
