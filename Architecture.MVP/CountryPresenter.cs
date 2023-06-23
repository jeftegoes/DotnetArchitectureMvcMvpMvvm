using Architecture.Model.Services;

namespace Architecture.MVP
{
    public class CountryPresenter
    {
        private readonly IView _view;

        public CountryPresenter(IView view)
        {
            _view = view;
        }

        public async Task GetCountries()
        {
            var countryService = new CountryService();
            var countries = (await countryService.Get()).OrderBy(c => c.Name.Common).Select(c => c.Name.Common).ToList();

            _view.SetCountries(countries);
        }

        public async Task OnGetCountries()
        {
            await GetCountries();
        }
    }
}
