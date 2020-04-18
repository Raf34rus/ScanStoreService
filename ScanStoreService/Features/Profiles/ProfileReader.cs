using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using ScanStoreService.Infrastructure;
using ScanStoreService.Infrastructure.Errors;
using Microsoft.EntityFrameworkCore;
using ScanStoreService.Domain;

namespace ScanStoreService.Features.Profiles
{
    public class ProfileReader : IProfileReader
    {
        private readonly ScanStoreContext _context;
        private readonly ICurrentUserAccessor _currentUserAccessor;
        private readonly IMapper _mapper;

        public ProfileReader(ScanStoreContext context, ICurrentUserAccessor currentUserAccessor, IMapper mapper)
        {
            _context = context;
            _currentUserAccessor = currentUserAccessor;
            _mapper = mapper;
        }

        public async Task<ProfileEnvelope> ReadProfile(string username)
        {
            var currentUserName = _currentUserAccessor.GetCurrentUsername();

            var person = await _context.Persons.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Username == username);

            if (person == null)
            {
                throw new RestException(HttpStatusCode.NotFound, new { User = Constants.NOT_FOUND });
            }
            var profile = _mapper.Map<Domain.Persons, Profile>(person);

            if (currentUserName != null)
            {
                var currentPerson = await _context.Persons
                    .FirstOrDefaultAsync(x => x.Username == currentUserName);
            }
            return new ProfileEnvelope(profile);
        }
    }
}