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
    public partial class PersonalData : ContentPage
    { 
       public PersonalData()
        {
            InitializeComponent();
        }

        public class weightGraph
        {
            public string Date {get; set;}
            public double Weight {get; set;}

            public weightGraph(string xValue, double yValue)
            {
                Date = xValue;
                Weight = yValue; 
            }
        }

        public class viewGraph
        {
            public ObservableCollection<weightGraph> userData{get; set;}

            public viewGraph()
            {
                userData = new ObservableCollection<weightGraph>()
                {
                    //Add random dates and weights
                    new weightGraph("January 17", 200),
                    new weightGraph("January 29", 195),
                    new weightGraph("February 10", 190),
                    new weightGraph("February 21", 185),
                    new weightGraph("March 16", 180),
                    new weightGraph("March 23", 175),
                    new weightGraph("April 15", 170),
                    new weightGraph("April 25", 165),
                    new weightGraph("May 12", 160),
                    new weightGraph("May 27", 155),
                    new weightGraph("June 3", 150),
                    new weightGraph("June 21", 145),
                    new weightGraph("July 6", 140),
                    new weightGraph("July 20", 135), 
                };
            }
        }

    }
}
