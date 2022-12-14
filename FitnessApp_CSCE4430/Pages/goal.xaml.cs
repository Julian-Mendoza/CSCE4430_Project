sing System;  
using System.ComponentModel;  
using System.Windows.Input;  
using Xamarin.Forms;  
namespace APP3 
{  
    public class Goal : ContentPage  
    {  
        public string weight
        {  
            get { return weight; }  
            set  
            {  
                weight = value;  
            }  
        }  
        private string height;
        {  
            get { return height; }  
            set  
            {  
                height = value;  
            }  
        }  

        public string goal
        {  
            get { return goal; }  
            set  
            {  
                password= goal;  
                
            }  
        }  
       
        public void OnSubmit()  
        {  
            if (goal != "")  
            {  
                DisplayInvalidLoginPrompt();  
            }  
        }  
    }  
}  
