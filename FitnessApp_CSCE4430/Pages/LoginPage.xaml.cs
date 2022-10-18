using FitnessApp_CSCE4430.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessApp_CSCE4430.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Person testUser = new Person("Julian", "jmendoza728", "Password", true);
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginReady()
        {
            if (UserEntry.Text != null && PasswordEntry.Text != null)
            {
                LoginButton.IsEnabled = true;
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
        }

        private void UserEntry_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            LoginReady();
        }

        private void PasswordEntry_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            LoginReady();
        }
      
        private async Task Login()
        {
           
           if(UserEntry.Text == testUser.UserName && PasswordEntry.Text == testUser.Password)
            {
                 await Navigation.PushAsync(new HomePage());
            }
           else
            {
                await DisplayAlert("Invalid Credentials", "The username or password are invalid, please try again", "Ok");
                LoginButton.IsEnabled = false;
                PasswordEntry.Text = null;
            }
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Login();
        }
    }
}