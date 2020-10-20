using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Domain
{
    public partial class BitRequestDetail
    {
        public int Id { get; set; }
        public BitRequestDetailsStatus Status { get; set; }
        public int Type { get; set; }
        public string Comment { get; set; }
        public DateTime DateInst { get; set; }
        public DateTime DateUpdate { get; set; }
        public int BitRequestsId { get; set; }
        public virtual BitRequest BitRequests { get; set; }

    }
}
