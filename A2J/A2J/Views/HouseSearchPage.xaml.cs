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
        String[] buttonList = new String[6] {"but1", "but2", "but3", "but4", "but5", "but6"}; // Array used to indicate when boxes are "used up" or not.


        public HouseSearchPage ()
		{
			InitializeComponent ();
        }

        async void AddHouse(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
            Button button = sender as Button;
            
            button.Text = "House Saved";
        }

        async void DirectToEntry(object sender, EventArgs e)
        {
            
        }
    }
}