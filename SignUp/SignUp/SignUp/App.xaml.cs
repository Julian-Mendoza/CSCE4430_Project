using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);
            MainPage = new NavigationPage(new Views.RegistrationPage());
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
