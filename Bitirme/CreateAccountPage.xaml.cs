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
	public partial class CreateAccountPage : ContentPage
	{
		public CreateAccountPage ()
		{
			InitializeComponent ();
		}
        private void Signup_Clicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(usernameentry.Text);
            bool isEmailEmpty = string.IsNullOrEmpty(emailentry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(newpassword.Text);
            bool isPasswordagainEmpty = string.IsNullOrEmpty(againpassword.Text);

            if (isUsernameEmpty || isEmailEmpty || isPasswordEmpty || isPasswordagainEmpty)
            {

            }
            else if (newpassword.Text == againpassword.Text)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {

            }

        }
    }
}