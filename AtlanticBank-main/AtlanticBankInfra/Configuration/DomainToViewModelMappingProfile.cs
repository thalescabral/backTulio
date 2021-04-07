using AtlanticBankDomain.Models;
using AtlanticBankDomain.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticBankInfra.Configuration
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CashMachine, CashMachineViewModel>()
                .ForMember(d => d.Status, o => o.MapFrom(src => (src.Status == 1)));
        }
    }
}
