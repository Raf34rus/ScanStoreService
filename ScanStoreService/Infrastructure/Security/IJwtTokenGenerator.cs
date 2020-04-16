using System.Threading.Tasks;

namespace ScanStoreService.Infrastructure.Security
{
    public interface IJwtTokenGenerator
    {
        Task<string> CreateToken(string username);
    }
}