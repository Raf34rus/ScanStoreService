using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.ContractScans
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.ContractScans, ContractScan>(MemberList.None);
        }
    }
}
