using AtlanticBankDomain.Models;
using AtlanticBankDomain.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticBankInfra.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMap()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
