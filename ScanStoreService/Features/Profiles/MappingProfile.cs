using AutoMapper;

namespace ScanStoreService.Features.Profiles
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Persons, Profile>(MemberList.None);
        }
    }
}
