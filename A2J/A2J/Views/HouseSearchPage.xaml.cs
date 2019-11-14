﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2J.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HouseSearchPage : CarouselPage
	{
		public HouseSearchPage ()
		{
			InitializeComponent ();
		}

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
    }
}