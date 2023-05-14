using MudBlazor.Services;

namespace CountryInfoApp.ConifgurationServices
{
    public static class MudBlazorClientSetup
    {
        public static IServiceCollection AddMudBlazorConfiguration(this IServiceCollection services)
        {
            services.AddMudServices();
            return services;
        }
    }
}