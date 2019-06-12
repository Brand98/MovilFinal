using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFinalDM.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void LoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        public void SignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new Model.User
            {
                Username = UsernameEntry.Text,
                Password = PasswordEntry.Text,
                Email = EmailEntry.Text
            };
            var signUpSucceeded = AreDetailsValid(user);
            if (signUpSucceeded)
            {
                var rootpage = Navigation.NavigationStack.FirstOrDefault();
                if (rootpage != null)
                {
                    string m = "blanco";
                    DisplayAlert("", m, "OK");
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
                    //await Navigation.PopToRootAsync();                    
                }
                else
                {
                    errortext.Text = "SignUpError";
                }
            }

        }

        bool AreDetailsValid(Model.User user)
        {
            if (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@")) ;
            {
                DisplayAlert("Error", "Por favor ingrese los valores correspondientes", "OK");
            }

            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
        }
    }
}