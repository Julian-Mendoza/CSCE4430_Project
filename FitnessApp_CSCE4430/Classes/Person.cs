using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp_CSCE4430.Classes
{
    class Person : RealmObject
    {
        public Person(string name, string username, string password, bool gender)
        {
            this.Name = name;
            this.UserName = username;
            this.Password = password;
            this.Gender = gender;
        }

        /**Vars for credientals**/
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /**User Static data**/
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //True = male, False = female
        private bool gender;
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        /**Users current measurements**/
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private double waist;
        public double Waist
        {
            get { return waist; }
            set { waist = value; }
        }

        private double hip;
        public double Hip
        {
            get { return hip; }
            set { hip = value; }
        }

        private double neck;
        public double Neck
        {
            get { return neck; }
            set { neck = value; }
        }

        private double bodyFat;
        public double BodyFat
        {
            get { return bodyFat; }
            set { bodyFat = value; }
        }

        private double fatMass;
        public double FatMass
        {
            get { return fatMass; }
            set { fatMass = value; }
        }

        private double leanMass;
        public double LeanMass
        {
            get { return leanMass; }
            set { leanMass = value; }
        }

        private double bmi;
        public double BMI
        {
            get { return bmi; }
            set { bmi = value; }
        }

        private double bmrCalories;
        public double BMRCalories
        {
            get { return bmrCalories; }
            set { bmrCalories = value; }
        }

        private double dailyCalories;
        public double DailyCalories
        {
            get { return dailyCalories; }
            set { dailyCalories = value; }
        }




        /**User Goals**/
        private double goalWeight;
        public double GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }

        private double fatToLoseGain;
        public double FatToLoseGain
        {
            get { return fatToLoseGain; }
            set { fatToLoseGain = value; }
        }


        private double goalCalories;
        public double GoalCalories
        {
            get { return goalCalories; }
            set { goalCalories = value; }
        }

        private double goalBodyFat;
        public double GoalBodyFat
        {
            get { return goalBodyFat; }
            set { goalBodyFat = value; }
        }

        public void CalculateData()
        {
            if(gender)
            {
                bodyFat = Math.Round(((86.010 * Math.Log10(waist - neck)) - (70.041 * Math.Log10(height)) + 36.76), 2);
            }
            else
            {
                bodyFat = Math.Round(((163.205*Math.Log10(waist+hip-neck))-(97.684*Math.Log10(height))-78.387), 2);
            }

            fatMass = Math.Round(weight * (bodyFat/100),2);
            leanMass = Math.Round((weight - fatMass),2);
            goalWeight = Math.Round((leanMass + (weight * 0.15)),2);
            bmrCalories = Math.Round((370 + (9.82 * leanMass)),2);
            bmi = Math.Round(((weight / 2.204) / (Math.Pow((height * .0254), 2))),2);

            if(bodyFat >= 15)
            {
                fatToLoseGain = Math.Round((fatMass - (weight * 0.15)),2);
            }
            else
            {
                fatToLoseGain = Math.Round(((weight * 0.15) - fatMass),2);
            }
        }


    }
}
