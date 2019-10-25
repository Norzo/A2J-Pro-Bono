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
	public partial class RightsPage : ContentPage
	{
        private async void BackToMainPage_RightsPageClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public RightsPage ()
		{
			InitializeComponent ();
		}
	}
}