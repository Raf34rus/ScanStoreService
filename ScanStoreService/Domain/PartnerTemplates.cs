using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class PartnerTemplates
    {
        public int Id { get; set; }
        public int? PartnerId { get; set; }
        public string Email { get; set; }
        public int? TemplateId { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }

        public virtual Partners Partner { get; set; }
        public virtual Templates Template { get; set; }
    }
}
