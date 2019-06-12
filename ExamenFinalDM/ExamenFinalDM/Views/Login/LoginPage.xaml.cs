using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFinalDM.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        async void SigUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            var user = new Model.User
            {
                Username = UserNameEntry.Text,
                Password = PasswordEntry.Text
            };

            var isVaild = AreCredentialsCorrect(user);
            if (isVaild)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                LoginFaild.Text = "InCorrect Password";
                PasswordEntry.Text = string.Empty;
            }


        }

        bool AreCredentialsCorrect(Model.User user)
        {
            //return user.Username == Model.Constants.Username && user.Password == Model.Constants.Password;
            return user.Username == Model.Constants.Username && user.Password == Model.Constants.Password;

        }
    }
}