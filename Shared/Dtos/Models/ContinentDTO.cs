using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoApp.Shared.Dtos.Models
{
    public class ContinentDTO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public List<CountryDTO>? Countries { get; set; }
    }
}
