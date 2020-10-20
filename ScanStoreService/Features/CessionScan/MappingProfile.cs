using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.CessionScan
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.CessionScans, CessionScan>(MemberList.None);
        }
    }
}
