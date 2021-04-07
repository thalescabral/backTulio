using AtlanticBankDomain.Enum;
using AtlanticBankDomain.Models;
using AtlanticBankDomain.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticBankInfra.Configuration
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CashMachineViewModel, CashMachine>()
                .ForMember(d => d.Status, o => o.MapFrom(src => (src.Status == 1)));

            /*CreateMap<CashMachineViewModel, CashMachine>()
                .ForMember(dest => dest.Status,
                     opt => opt.MapFrom(source => Enum.GetName(typeof(StatusCashMachine), source.Status)));*/

            /*CreateMap<CashMachineViewModel, CashMachine>()
            .ForMember(dest => dest.Status,
                e => e.MapFrom(source =>
                    source.Status == 0
                        ? StatusCashMachine.NullValue
                        : source.Status ? StatusCashMachine.ACTIVE : StatusCashMachine.BLOCKED));*/
        }
    }
}
