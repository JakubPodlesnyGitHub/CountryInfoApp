using System.Text.Json;

namespace CountryInfoApp.HttpHelpers
{
    public interface IHttpService
    {
        Task<HttpWrapper<T>> GetAsync<T>(string URL);
    }
}
