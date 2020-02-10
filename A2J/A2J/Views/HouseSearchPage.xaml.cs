using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using A2J.Models;

namespace A2J.Views
{ 

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HouseSearchPage : ContentPage
	{

        public HouseSearchPage ()
		{
			InitializeComponent ();
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