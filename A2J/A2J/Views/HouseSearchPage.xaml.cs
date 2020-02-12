using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using A2J.Models;
using A2J.Data;

namespace A2J.Views
{ 

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HouseSearchPage : ContentPage
	{

        Dictionary<Button, HouseEntry> buttonsToHouses;
        public HouseSearchPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Button> buttons = buttonGrid.Children.Where(x => x is Button).ToList().ConvertAll(x => (Button)x);
            List<HouseEntry> houses;
            var task = Task.Run(async () => await HouseDatabase.getHousesAsync());
            houses = task.Result;

            for (int i = 0; i < Math.Min(houses.Count, buttons.Count); i++)
            {
                buttons.ElementAt(i).Text = houses.ElementAt(i).houseAddress;
            }
        }



        async void AddHouse(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

        async void DirectToEntry(object sender, EventArgs e)
        {
        }
    }
}