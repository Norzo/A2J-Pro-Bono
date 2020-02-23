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
    public partial class MovingInPage : ContentPage
    {
        public MovingInPage()
        {
            InitializeComponent();
        }

        async void NavToChecklist(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovingInChecklist());

        }
    }
}