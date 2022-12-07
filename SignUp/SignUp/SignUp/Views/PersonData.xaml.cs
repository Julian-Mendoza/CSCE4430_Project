using SignUp.Person;
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
    public partial class PersonData : ContentPage
    {
        public PersonTable person;
        public PersonData(PersonTable person)
        {
            InitializeComponent();
            BindingContext = person;
        }
    }
}