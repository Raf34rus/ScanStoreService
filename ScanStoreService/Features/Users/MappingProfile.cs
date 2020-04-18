using AutoMapper;

namespace ScanStoreService.Features.Users
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Persons, User>(MemberList.None);
        }
    }
}
