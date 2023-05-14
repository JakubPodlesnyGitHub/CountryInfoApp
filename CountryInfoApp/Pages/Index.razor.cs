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