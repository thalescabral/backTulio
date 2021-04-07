using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticBankInfra.Configuration
{
    public static class AutoMapperSetup
    {
        public static IServiceCollection AddAutoMapperSetup(this IServiceCollection services)
        {
            IMapper mapper = AutoMapperConfig.RegisterMap().CreateMapper();

            return services.AddSingleton(mapper);
        }
    }
}
