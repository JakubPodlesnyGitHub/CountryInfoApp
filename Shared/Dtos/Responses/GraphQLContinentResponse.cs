using CountryInfoApp.Shared.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoApp.Shared.Dtos.Responses
{
    public class GraphQLContinentResponse
    {
        public ContinentDTO Continent { get; set; } = null!;
    }
}
