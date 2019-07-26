using Bitirme.Logic;
using Plugin.Geolocator;
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
	public partial class NewPage : ContentPage
	{
		public NewPage ()
		{
			InitializeComponent ();
		}

        

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();

            var veneus = VenueLogic.GetVenues(position.Latitude, position.Longitude);
        }

        private void İstanbul_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Actionpage());
        }
    }
}