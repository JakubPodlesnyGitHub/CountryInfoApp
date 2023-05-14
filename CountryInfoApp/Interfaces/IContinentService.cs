using CountryInfoApp.Shared.Dtos.Models;

namespace CountryInfoApp.Interfaces
{
    public interface IContinentService
    {
        public Task<ContinentDTO> GetContinentAsync(string continentCode);
        public Task<List<ContinentDTO>> GetContinentsAsync();
    }
}
