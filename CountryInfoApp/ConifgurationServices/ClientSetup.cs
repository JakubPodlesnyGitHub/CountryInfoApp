namespace CountryInfoApp.ConifgurationServices
{
    public static class ClientSetup
    {
        public static IServiceCollection AddClientSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddGraphQLConfiguration(configuration);
            services.AddServicesConfiguration();
            services.AddMudBlazorConfiguration();
            return services;
        }
    }
}