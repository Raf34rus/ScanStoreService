using ScanStoreService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.BitRequests
{
    public class BitRequestsEnvelope
    {
        public List<BitRequest> BitRequests { get; set; }

        public int BitRequestsCount { get; set; }
    }
    
}
