using CountryInfoApp.HttpHelpers;
using CountryInfoApp.REST.Interfaces;
using CountryInfoApp.Shared.JsonWrappers;

namespace CountryInfoApp.REST.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly string _baseURL = "https://restcountries.com/v3.1/name/";
        private readonly IHttpService _httpService;

        public CountryRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<CountryDetails>> GetCountryDetailsAsync(string countryName)
        {
            var httpResponse = await _httpService.GetAsync<List<CountryDetails>>($"{_baseURL}{countryName}");
            return httpResponse.Response;
        }
    }
}
