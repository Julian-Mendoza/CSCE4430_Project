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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        Person test = new Person("Julian", "jjm", "Password", true);

        private void CheckEntries()
        {
            if(WeightEnty.Text != null && HeightEnty.Text != null && WaistEnty.Text != null && NeckEnty.Text != null)
            {
                EnterButton.IsEnabled = true;
            }
            else
            {
                EnterButton.IsEnabled = false;
            }
        }

        private void WeightEnty_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            CheckEntries();
        }

        private void HeightEnty_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            CheckEntries();
        }

        private void WaistEnty_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            CheckEntries();
        }

        private void NeckEnty_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            CheckEntries();
        }
        
        private void EnterButton_Clicked(object sender, EventArgs e)
        {
            setUsersData();
        }

        private void setUsersData()
        {
            test.Weight = Convert.ToDouble(WeightEnty.Text);
            test.Neck = Convert.ToDouble(NeckEnty.Text);
            test.Height = Convert.ToDouble(HeightEnty.Text);
            test.Waist = Convert.ToDouble(WaistEnty.Text);

            test.CalculateData();

            BodyFatLabel.Text = "Body Fat: " + test.BodyFat + "%";
            FatMassLabel.Text = "Fat Mass: " + test.FatMass + "lbs";
            LeanMassLabel.Text = "Lean Mass: " + test.LeanMass + "lbs";
            BMILabel.Text = "BMI: " + test.BMI;
            BMRLabel.Text = "BMR: " + test.BMRCalories + " calories";
            GoalWeightLabel.Text = "Goal weight: " + test.GoalWeight + "lbs";
            if(test.BodyFat > 15)
            {
                LoseGainLabel.Text = "Lose: " + test.FatToLoseGain + "lbs"; 
            }
            else
            {
                LoseGainLabel.Text = "Gain: " + test.FatToLoseGain + "lbs";
            }

            
        }
    }
}