using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;
using Plugin.ValidationRules.Formatters;
using Plugin.ValidationRules.Rules;
using SignUp.Validations;
using System;

namespace SignUp.ViewModels
{
    public class RegistrationPageModel
    {
        public Validatable<string> Firstname
        {
            get;
            set;
        }
        public Validatable<string> Lastname
        {
            get;
            set;
        }
        public Validatable<string> Password
        {
            get;
            set;
        }
        public Validatable<string> Email
        {
            get;
            set;
        }
        public Validatable<string> PhoneNo
        {
            get;
            set;
        }
        public Validatable<string> Age
        {
            get;
            set;
        }
        public Validatable<string> Gender
        {
            get;
            set;
        }

        public RegistrationPageModel()
        {
            Console.WriteLine("-------------Validations ---------------");
            
            Firstname = new Validatable<string>();
            Firstname = Validator.Build<string>()
                .WithRule(new RequiredString("Firstname"))
                .When(x => !string.IsNullOrEmpty(x))
                .Must(x => x.Length > 2, "Firstname must be greater than 2");
            Lastname = new Validatable<string>();
            Lastname = Validator.Build<string>()
                .WithRule(new RequiredString("Lastname"))
                .When(x => !string.IsNullOrEmpty(x))
                .Must(x => x.Length > 2, "Lastname must be greater than 2");

            Password = new Validatable<string>();
            Password = Validator.Build<string>()
                .WithRule(new RequiredString("Password"))
                .WithRule(new Password());

            Email = new Validatable<string>();
            Email = Validator.Build<string>()
                .WithRule(new RequiredString("Email"))
                .WithRule(new EmailRule());

            PhoneNo = new Validatable<string>();
            PhoneNo = Validator.Build<string>()
                .WithRule(new RequiredString("Phone Number"))
                .When(x => !string.IsNullOrEmpty(x))
                .Must(x => x.Length == 10, "Phone number must be 10 digits");
            PhoneNo.Formatter = new MaskFormatter("XXX-XXX-XXXX");

            Age = Validator.Build<string>()
                .WithRule(new RequiredString("Age"));

            Gender = Validator.Build<string>()
                .WithRule(new RequiredString("Gender"));

            Console.WriteLine("Validations Added");
        }

        public bool IsModalValid()
        {
            Firstname.Validate();
            Lastname.Validate();
            Password.Validate();
            PhoneNo.Validate();
            Email.Validate();
            Age.Validate();
            Gender.Validate();

            return Firstname.IsValid 
                &&Lastname.IsValid 
                && Password.IsValid 
                && PhoneNo.IsValid
                && Email.IsValid 
                && Age.IsValid 
                && Gender.IsValid;
        }
    }

}
