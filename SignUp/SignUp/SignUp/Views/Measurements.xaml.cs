using SignUp.Person;
using SignUp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Measurements : ContentPage
    {
        private static readonly MeasurementsModel _context = new MeasurementsModel();
        public bool enableBtn = false;
        private PersonTable person;
        public Measurements(PersonTable cacheData)
        {
            InitializeComponent();
            BindingContext = _context;
            person = cacheData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (_context.IsModalValid())
            {
                person.Waist = _context.Waist.Value;
                person.Hip = _context.Hip.Value;
                person.Neck = _context.Neck.Value;
                person.Height = _context.Height.Value;
                person.Weight = _context.Weight.Value;
                Navigation.PushAsync(new Goals(person));
            }
        }
      
        private void WaistOutFocus(object sender, EventArgs e)
        {
         
            _context.Waist.Validate();
          
        }
        private void HipOutFocus(object sender, EventArgs e)
        {
          
            _context.Hip.Validate();
           }
        private void NeckOutFocus(object sender, EventArgs e)
        {
     
            _context.Neck.Validate();
           
          
        }
        private void HeightOutFocus(object sender, EventArgs e)
        {
          
            _context.Height.Validate();
          
        }
        private void WeightOutFocus(object sender, EventArgs e)
        {
           
            _context.Weight.Validate();
           
        }
    }
}