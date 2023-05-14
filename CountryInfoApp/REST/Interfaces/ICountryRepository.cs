using CountryInfoApp.Shared.JsonWrappers;

namespace CountryInfoApp.REST.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<CountryDetails>> GetCountryDetailsAsync(string countryName);
    }
}
