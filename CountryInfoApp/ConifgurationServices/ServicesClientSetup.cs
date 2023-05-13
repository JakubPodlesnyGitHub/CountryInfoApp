using CountryInfoApp.Interfaces;
using CountryInfoApp.Services;

namespace CountryInfoApp.ConifgurationServices
{
    public static class ServicesClientSetup
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IContinentService, ContinentService>();
            return services;
        }
    }
}
