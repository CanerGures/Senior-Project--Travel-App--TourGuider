using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitirme
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Actionpage : ContentPage
	{
		public Actionpage ()
		{
			InitializeComponent ();
		}

      
        private void Camp_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Camppage());

        }
       
      
        private void Adventure_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Adventurepage());

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Historicalpage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Hotelpage());

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Foodpage());

        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Airportpage());
        }
    }
}