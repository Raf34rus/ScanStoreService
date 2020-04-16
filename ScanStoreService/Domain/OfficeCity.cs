using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class OfficeCity
    {
        public OfficeCity()
        {
            OfficeAddress = new HashSet<OfficeAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OfficeAddress> OfficeAddress { get; set; }
    }
}
