﻿using System;

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

        private async void NavigateToRights_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RightsPage());
        }

        private async void NavigateToMovingOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovingOut());
        }

        private async void NavigateToHouseSearch_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HouseSearchPage());
        }

        private async void NavigateToMovingIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovingInPage());
        }

        private async void NavigateToAbout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void NavigateToLivingIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LivingInPage());
        }
    }
}