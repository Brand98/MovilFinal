using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenFinalDM;
using ExamenFinalDM.Views; 
using ExamenFinalDM.Controller;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExamenFinalDM
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App(string filename)
        {
            InitializeComponent();
            Conexion.Inicializador(filename);
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new Views.Login.LoginPage());
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Views.Login.LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
