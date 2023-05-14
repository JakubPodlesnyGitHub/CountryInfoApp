using Microsoft.AspNetCore.Components;

namespace CountryInfoApp.Shared
{
    public partial class ContinentInformationComponent
    {
        [Parameter]
        public string Name { get; set; }
    }
}