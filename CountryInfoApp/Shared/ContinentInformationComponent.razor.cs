using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CountryInfoApp.Shared
{
    public partial class ContinentInformationComponent
    {
        [Parameter]
        public string Name { get; set; }
    }
}
