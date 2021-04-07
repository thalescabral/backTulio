using AtlanticBankData.Context;
using AtlanticBankData.Repository;
using AtlanticBankDomain.Interfaces;
using AtlanticBankDomain.Services;
using Microsoft.Extensions.DependencyInjection;


namespace AtlanticBankInfra.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApiDbContext>();
            services.AddScoped<ICashMachineRepository, CashMachineRepository>();
            services.AddScoped<ICashMachineService, CashMachineService>();

            return services;
        }
    }
}
