namespace CountryInfoApp.Shared.JsonWrappers
{
    public class CountryDetails
    {
        public Name Name { get; set; }
        public int? Population { get; set; }
        public List<string> Capital { get; set; }
        public string Subregion { get; set; }
        public Dictionary<string, CurrencySymbol> Currencies { get; set; }
    }

    public class CurrencySymbol
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }
    }
}