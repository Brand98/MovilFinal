using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFinalDM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarView());
        }

        async void OnNextPageButtonClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsertarView());
        }

        async void OnNextPageButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EliminarView());
        }

        async void OnNextPageButtonClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActualizaView());
        }

        async void OnLogout_Clicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new Login.LoginPage(), this);
            await Navigation.PopAsync();
        }

        async void BtnGrafico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gráfico());
        }
    }
}