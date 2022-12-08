using SignUp.Person;
using SignUp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Goals : ContentPage
    {
        private static GoalsModel _context = new GoalsModel();
        public PersonTable person;
        public Goals(PersonTable cacheData)
        {
            InitializeComponent();
            BindingContext = _context;
            person = cacheData;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (_context.IsModalValid())
            {
                person.Intensity = _context.Intensity.Value;
                person.Goal_Weight = _context.Weight.Value;
                person.Goal_BMI = _context.BMI.Value;
                Navigation.PushAsync(new PersonData(person));
            }
        }
        private void IntensityOutFocus(object sender, EventArgs e)
        {
            Console.WriteLine("Validating Intensity");
            _context.Intensity.Validate();
            
            Console.WriteLine(_context.Intensity.HasErrors);
        }
        private void WeightOutFocus(object sender, EventArgs e)
        {
            Console.WriteLine("Validating Weight");
            _context.Weight.Validate();
            
            Console.WriteLine(_context.Weight.HasErrors);
        }
        private void BMIOutFocus(object sender, EventArgs e)
        {
            Console.WriteLine("Validating BMI");
            _context.BMI.Validate();
            
            Console.WriteLine(_context.BMI.HasErrors);
        }
    }
}