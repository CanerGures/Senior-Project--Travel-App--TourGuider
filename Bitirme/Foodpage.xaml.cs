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
	public partial class Foodpage : ContentPage
	{
		public Foodpage ()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideFoodpage.nightclubs());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideFoodpage.dinner());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideFoodpage.coffee());
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new insideFoodpage.breakfast());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            Navigation.PushAsync(new Actionpage());
        }
    }
}