using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using A2J.Models;

namespace A2J.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {

        public HouseEntry houseEntry { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            houseEntry = new HouseEntry
            {
                houseAddress = "Enter the address",
                houseBedrooms = 0,
                houseRent = 0
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddHouse", houseEntry);

            await Navigation.PopAsync();
        }
    }
}