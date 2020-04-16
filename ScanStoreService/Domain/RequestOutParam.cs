using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class RequestOutParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TemplateId { get; set; }
        public int Type { get; set; }

        public virtual Templates Template { get; set; }
    }
}
