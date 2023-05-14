using CountryInfoApp.HttpHelpers;
using CountryInfoApp.Interfaces;
using CountryInfoApp.REST.Interfaces;
using CountryInfoApp.REST.Repositories;
using CountryInfoApp.Services;

namespace CountryInfoApp.ConifgurationServices
{
    public static class ServicesClientSetup
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IContinentService, ContinentService>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            return services;
        }
    }
}
