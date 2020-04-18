
using ScanStoreService.Domain;

namespace ScanStoreService.Features.ContractRequests
{
    public class ContractRequestEnvelope
    {
        public ContractRequestEnvelope(ContractRequess contractRequest)
        {
            ContractRequest = contractRequest;
        }

        public ContractRequess ContractRequest { get; }
    }
}
