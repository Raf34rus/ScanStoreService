using System.Threading.Tasks;

namespace ScanStoreService.Features.Profiles
{
    public interface IProfileReader
    {
        Task<ProfileEnvelope> ReadProfile(string username);
    }
}