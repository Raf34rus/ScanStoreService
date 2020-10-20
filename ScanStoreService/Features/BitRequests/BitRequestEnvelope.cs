
using ScanStoreService.Domain;

namespace ScanStoreService.Features.BitRequests
{
    public class BitRequestEnvelope
    {
        public BitRequestEnvelope(BitRequest bitRequest)
        {
            BitRequest = bitRequest;
        }

        public BitRequest BitRequest { get; }
    }
}
