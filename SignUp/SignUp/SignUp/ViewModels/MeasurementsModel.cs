using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;
using SignUp.Validations;

namespace SignUp.ViewModels
{
    class MeasurementsModel
    {
        public Validatable<string> Neck
        {
            get;
            set;
        }
        public Validatable<string> Hip
        {
            get;
            set;
        }
        public Validatable<string> Waist
        {
            get;
            set;
        }
        public Validatable<string> Height
        {
            get;
            set;
        }
        public Validatable<string> Weight
        {
            get;
            set;
        }
       public MeasurementsModel()
        {
            Height = new Validatable<string>();
            Weight = new Validatable<string>();
            Waist = new Validatable<string>();
            Hip = new Validatable<string>();
            Neck = new Validatable<string>();

            Height = Validator.Build<string>()
                .WithRule(new RequiredString("Height"));
            Weight = Validator.Build<string>()
                .WithRule(new RequiredString("Weight"));
            Waist = Validator.Build<string>()
                .WithRule(new RequiredString("Waist"));
            Hip = Validator.Build<string>()
                .WithRule(new RequiredString("Hip"));
            Neck = Validator.Build<string>()
                .WithRule(new RequiredString("Neck"));
        }
        public bool IsModalValid()
        {
            Height.Validate();
            Weight.Validate();  
            Waist.Validate();  
            Hip.Validate();  
            Neck.Validate();
            return Height.IsValid && Weight.IsValid && Waist.IsValid && Hip.IsValid && Neck.IsValid;
        }
    }
}
