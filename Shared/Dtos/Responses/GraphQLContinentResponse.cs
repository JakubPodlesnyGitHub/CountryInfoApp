using CountryInfoApp.Shared.Dtos.Models;

namespace CountryInfoApp.Shared.Dtos.Responses
{
    public class GraphQLContinentResponse
    {
        public ContinentDTO Continent { get; set; } = null!;
    }
}