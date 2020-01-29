using System;
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
        Image houseImage = new Image { Source = "HouseExample.jpg" };
        
        public HouseSearchPage ()
		{
			InitializeComponent ();

		}
        // Function for sending to NewItemPage when clicking the big plus image
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
    }
}