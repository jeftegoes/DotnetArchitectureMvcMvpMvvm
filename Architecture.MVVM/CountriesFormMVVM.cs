using System.ComponentModel;

namespace Architecture.MVVM
{
    public partial class CountriesFormMVVM : Form
    {
        private BindingList<string> _countries = new BindingList<string>();

        public CountriesFormMVVM()
        {
            InitializeComponent();
            countriesListBox.DataSource = _countries;
        }

        private async void getCountriesButton_Click(object sender, EventArgs e)
        {

        }
    }
}