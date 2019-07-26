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
	public partial class Camppage : ContentPage
	{
		public Camppage ()
		{
			InitializeComponent ();
		}

        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Actionpage());

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideCamppage.CampingSpots());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideCamppage.NaturalParks());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WeatherView());
        }
    }
}