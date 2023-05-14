using CountryInfoApp.REST.Interfaces;
using CountryInfoApp.Shared.Dtos.Models;
using CountryInfoApp.Shared.JsonWrappers;
using Microsoft.AspNetCore.Components;
using System.Linq;
using static MudBlazor.Colors;


namespace CountryInfoApp.Shared
{
    public partial class CountriesTableComponent
    {
        [Parameter]
        public string ContinentCode { get; set; } = null!;
        [Parameter]
        public int CountriesNumber { get; set; }
        [Inject]
        public ICountryRepository CountryRepository { get; set; }

        private ContinentDTO Continent = null!;

        private string SearchValue = string.Empty;
        private bool IsLoading = true;
        protected override async Task OnParametersSetAsync()
        {
            Continent = await ContinentService.GetContinentAsync(ContinentCode);
            Continent.Countries = Continent.Countries.OrderBy(x => new Random().Next()).Take(CountriesNumber).ToList();
            if (Continent is not null && Continent.Countries.Count > 0)
            {
                IsLoading = false;
            }
        }

        private bool FilterFuncShort(CountryDTO e) => FilterFunc(e, SearchValue);

        private bool FilterFunc(CountryDTO e, string SearchValue)
        {
            if (e.Name.Contains(SearchValue, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (e.Code.Contains(SearchValue, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (e.Emoji.Contains(SearchValue, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (e.Native.Contains(SearchValue, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(SearchValue))
            {
                return true;
            }
            return false;
        }

        private async Task ShowBtnSwipe(CountryDTO selectedElement)
        {
            selectedElement.ShowCountryDetails = !selectedElement.ShowCountryDetails;
            selectedElement.CountryDetails = await CountryRepository.GetCountryDetailsAsync(selectedElement.Name);
            StateHasChanged();
        }
    }
}
