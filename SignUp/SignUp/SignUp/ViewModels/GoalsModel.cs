using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;
using SignUp.Validations;

namespace SignUp.ViewModels
{
    public class GoalsModel
    {
        public Validatable<string> Weight
        {
            get;
            set;
        }
        public Validatable<string> BMI
        {
            get;
            set;
        }
        public Validatable<string> Intensity
        {
            get;
            set;
        }
        public GoalsModel()
        {
            Weight = new Validatable<string>();
            BMI = new Validatable<string>();
            Intensity = new Validatable<string>();

            Weight = Validator.Build<string>()
                .WithRule(new RequiredString("Weight"));

            BMI = Validator.Build<string>()
                .WithRule(new RequiredString("BMI"));

            Intensity = Validator.Build<string>()
                .WithRule(new RequiredString("Intensity"));
        }

        public bool IsModalValid()
        {
            Weight.Validate();
            BMI.Validate();
            Intensity.Validate();

            return Weight.IsValid && BMI.IsValid && Intensity.IsValid;
        }
    }
}
