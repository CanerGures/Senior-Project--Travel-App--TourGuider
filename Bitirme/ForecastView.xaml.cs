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
    public partial class ForecastView : ContentPage
    {
        public ForecastView()
        {
            InitializeComponent();
            if (Device.RuntimePlatform != Device.UWP)
                Icon = new FileImageSource { File = "tab2.png" };

            ListViewWeather.ItemTapped += (sender, args) => ListViewWeather.SelectedItem = null;


        }
    }
}