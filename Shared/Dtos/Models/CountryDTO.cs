using CountryInfoApp.Shared.JsonWrappers;
using System.Text.Json.Serialization;

namespace CountryInfoApp.Shared.Dtos.Models
{
    public class CountryDTO
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Native { get; set; }
        public string? Emoji { get; set; }
        public List<LanguageDTO>? Languages { get; set; }

        [JsonIgnore]
        public List<CountryDetails>? CountryDetails { get; set; } = new List<CountryDetails>();

        [JsonIgnore]
        public bool ShowCountryDetails { get; set; } = false;

        [JsonIgnore]
        public bool IsDetailsLoading { get; set; } = true;
    }
}