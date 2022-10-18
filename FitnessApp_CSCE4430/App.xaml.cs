using FitnessApp_CSCE4430.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FitnessApp_CSCE4430
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
