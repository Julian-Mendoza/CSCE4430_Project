using SignUp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private static readonly RegistrationPageModel _context = new RegistrationPageModel();
        public bool enableBtn = false;
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = _context;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {  
            if (_context.IsModalValid())
            {
                var item = new Person.PersonTable()
                {
                    Firstname = _context.Firstname.Value,
                    Lastname = _context.Lastname.Value,
                    Password = _context.Password.Value,
                    Email = _context.Email.Value,
                    PhoneNumber = _context.PhoneNo.Value
                };
                Navigation.PushAsync(new Measurements(item));
            }
        }
        private void FirstnameOutFocus(object sender, EventArgs e)
        {
           
            _context.Firstname.Validate();
           
           
        }
        private void LastnameOutFocus(object sender, EventArgs e)
        {

            _context.Lastname.Validate();


        }
        private void PasswordOutFocus(object sender, EventArgs e)
        {
           
            _context.Password.Validate();
     
           
        }
        private void EmailOutFocus(object sender, EventArgs e)
        {
           
            _context.Email.Validate();
          
           
        }
        private void PhoneNoOutFocus(object sender, EventArgs e)
        {
           
            _context.PhoneNo.Validate();
  
           
        }
        private void GenderOutFocus(object sender, EventArgs e)
        {
           
            _context.Gender.Validate();
      
           
        }
        private void AgeOutFocus(object sender, EventArgs e)
        {
           
            _context.Age.Validate();
     
            Console.WriteLine(_context.Age.HasErrors);
        }

    }
}