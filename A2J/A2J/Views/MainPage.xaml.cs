using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2J.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateToRights_Clicked(object sender, EventArgs e) // Intialise the Rights Page
        {
            await Navigation.PushAsync(new RightsPage());
        }

        private async void NavigateToHouseSearch (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HouseSearchPage());
        }
    }
}