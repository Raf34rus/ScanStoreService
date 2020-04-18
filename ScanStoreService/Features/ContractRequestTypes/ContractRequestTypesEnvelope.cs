using System.Collections.Generic;
using ScanStoreService.Domain;

namespace ScanStoreService.Features.ContractRequestTypes
{
    public class ContractRequestTypesEnvelope
    {
        public List<Domain.ContractRequestTypes> ContractRequestTypes { get; set; }

        public int ContractRequestTypesCount { get; set; }
    }
}
