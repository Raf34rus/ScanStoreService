using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class RequessReson
    {
        public RequessReson()
        {
            FastRequess = new HashSet<FastRequess>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FastRequess> FastRequess { get; set; }
    }
}
