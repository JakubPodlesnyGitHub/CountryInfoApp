using CountryInfoApp.Interfaces;
using CountryInfoApp.Shared.Dtos.Models;
using CountryInfoApp.Shared.Dtos.Responses;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace CountryInfoApp.Services
{
    public class ContinentService : IContinentService
    {
        private readonly IGraphQLClient _client;

        public ContinentService(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<ContinentDTO> GetContinentAsync(string continentCode)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                    continent(code: ""#continent"") {
                        code
                        name
                        countries {
                            name
                            code
                            native
                            emoji
                            languages {
                                code
                                name
                            }
                        }
                    }
                }".Replace("#continent", continentCode)
            };
            var response = await _client.SendQueryAsync<GraphQLContinentResponse>(request);
            return response.Data.Continent;
        }

        public async Task<List<ContinentDTO>> GetContinentsAsync()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                    continents {
                        code
                        name
                    }
                }"
            };
            var response = await _client.SendQueryAsync<GraphQLContinentsResponse>(request);
            return response.Data.Continents;
        }
    }
}