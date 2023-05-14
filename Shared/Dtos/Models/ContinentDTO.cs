namespace CountryInfoApp.Shared.Dtos.Models
{
    public class ContinentDTO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public List<CountryDTO>? Countries { get; set; }
    }
}