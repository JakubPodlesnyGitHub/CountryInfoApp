using CountryInfoApp.Shared.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoApp.Shared.JsonWrappers
{
    public class CountryDetails
    {
        public Name Name { get; set; }
        public int Population { get; set; }
        public List<string> Capital { get; set; }
        public string Subregion { get; set; }
        public Dictionary<string,CurrencySymbol> Currencies { get; set; }
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
