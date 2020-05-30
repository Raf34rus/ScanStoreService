using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ScanStoreService.Infrastructure
{
    public class CurrentUserAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUsername()
        {
            var tt = _httpContextAccessor.HttpContext.User?.Claims;
            var tt2 = _httpContextAccessor.HttpContext.User?.Claims.ToString();
            return _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
