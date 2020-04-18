using ScanStoreService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.ContractRequests
{
    public class ContractRequestsEnvelope
    {
        public List<ContractRequess> ContractRequests { get; set; }

        public int ContractRequestsCount { get; set; }
    }
    
}
