using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.Extensions.DependencyInjection;

namespace CountryInfoApp.ConifgurationServices
{
    public static class GraphQLClientSetup
    {
        public static IServiceCollection AddGraphQLConfiguration(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient(new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri(uriString: configuration["GraphQLServerUri"])
            },
            new NewtonsoftJsonSerializer()));
            return services;
        }
    }
}
