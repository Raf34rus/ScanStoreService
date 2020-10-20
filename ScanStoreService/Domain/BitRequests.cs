using ScanStoreService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Domain
{
    public partial class BitRequest
    {
        public int Id { get; set; }
        public string IdBit { get; set; }
        public BitRequestStatus Status { get; set; }
        public long IdPkb { get; set; }
        public string Fio { get; set; }
        public DateTime DateInst{ get; set; }
        public DateTime DateUpdate { get; set; }
        public int ReqCount { get; set; }
         
        public virtual ICollection<ContractRequess> ContractRequests { get; set; } 
    }
}
