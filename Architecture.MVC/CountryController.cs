using Architecture.Model.Services;

namespace Architecture.MVC
{
    public class CountryController
    {
        private readonly CountriesFormMVC _countriesForm;

        public CountryController(CountriesFormMVC countriesForm)
        {
            _countriesForm = countriesForm;
        }

        public async Task GetCountries()
        {
            var countryService = new CountryService();
            var countries = await countryService.Get();

            _countriesForm.countries.Clear();
            foreach (var country in countries.OrderBy(c => c.Name.Common).Select(c => c.Name.Common))
            {
                _countriesForm.countries.Add(country);
            }
        }

        public async Task OnGetCountries()
        {
            await GetCountries();
        }
    }
}
