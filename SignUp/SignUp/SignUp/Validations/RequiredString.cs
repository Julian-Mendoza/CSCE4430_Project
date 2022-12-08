using Plugin.ValidationRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignUp.Validations
{
    class RequiredString : IValidationRule<string>
    {
        public string parameter = "";
        public RequiredString(string parameter)
        {
            this.parameter = parameter;
        }
        public string ValidationMessage { get ; set ; }

        public bool Check(string value)
        {
            if (value == null)
            {
                ValidationMessage = $"{this.parameter} cannot be null";
                return false;
            }

            if (value == "")
            {
                ValidationMessage = $"{this.parameter} cannot be null";
                return false;
            }

            if (string.IsNullOrEmpty(value))
            {
                ValidationMessage = $"{this.parameter} cannot be null";
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                ValidationMessage = $"{this.parameter} cannot be null";
                return false;
            }

            return true;
        }
    }
}
