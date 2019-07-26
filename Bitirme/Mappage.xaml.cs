using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitirme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mappage : ContentPage
    {
        public Mappage()
        {
            InitializeComponent();
            GetPermissions();
        }
        private async void GetPermissions()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);


                    if (status !=PermissionStatus.Granted)
                         {
                          if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                         {

                             await DisplayAlert("Need your location", "We need to access your location", "Ok");
                         }

                         var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                         status = results[Permission.LocationWhenInUse];
                    if (status == PermissionStatus.Granted)
                    {
                        locationsMap.IsShowingUser = true;

                    }
                    else
                    {
                        await DisplayAlert("Location denied", "You didn't give us permission to acces location", "Ok");
                    }
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
                
            }
            
            
        }
    }
}