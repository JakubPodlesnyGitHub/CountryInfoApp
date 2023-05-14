using CountryInfoApp.Shared.Dtos.Models;

namespace CountryInfoApp.Shared.Dtos.Responses
{
    public class GraphQLContinentsResponse
    {
        public List<ContinentDTO> Continents { get; set; } = null!;
    }
}