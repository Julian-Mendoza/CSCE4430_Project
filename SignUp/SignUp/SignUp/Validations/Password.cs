using Plugin.ValidationRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignUp.Validations
{
    class Password : IValidationRule<string>
    {
        public string ValidationMessage { get; set; }

        public bool Check(string value)
        {
            
                if (value == null)
                {
                    ValidationMessage = "A password is required.";
                    return false;
                }
                if (value.Length < 8)
                {
                    ValidationMessage = "Password length must be 8 characters minimum.";
                    return false;
                }

                return true; // Yupiii ! We did !!!
            }
        }
    }

