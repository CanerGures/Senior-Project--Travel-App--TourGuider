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
	public partial class ForgetPasswordPage : ContentPage
	{
		public ForgetPasswordPage ()
		{
			InitializeComponent ();
		}

        private void Apply_Clicked(object sender, EventArgs e)
        {
            
            bool isEmailEmpty = string.IsNullOrEmpty(emailentry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(newpasswordentry.Text);
            bool isPasswordagainEmpty = string.IsNullOrEmpty(againpassword.Text);

            if (isEmailEmpty || isPasswordEmpty || isPasswordagainEmpty)
            {

            }
            else if (newpasswordentry.Text == againpassword.Text)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {

            }
        }
    }
}