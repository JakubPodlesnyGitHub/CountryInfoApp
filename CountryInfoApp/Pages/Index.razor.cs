using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using CountryInfoApp;
using CountryInfoApp.Shared;
using MudBlazor;
using CountryInfoApp.Shared.Dtos.Models;

namespace CountryInfoApp.Pages
{
    public partial class Index
    {
        private List<ContinentDTO> Continents = new List<ContinentDTO>();
        private ContinentDTO SelectedContinent = null!;
        private int CountriesNumber = 2;
        protected override async Task OnInitializedAsync()
        {
            Continents = await ContinentService.GetContinentsAsync();
        }

        private void ValueChanged(int number)
        {
            CountriesNumber = number;
            StateHasChanged();
        }
    }
}