using System;
using System.Collections.Generic;
using System.Text;

namespace SignUp.Person
{
    public class PersonTable
    {
        public Guid UserId { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String Age { get; set; }
        public String Weight { get; set; }
        public String Height { get; set; }
        public String Gender { get; set; }
        public String Waist { get; set; }
        public String Hip { get; set; }
        public String Neck { get; set; }
        public String Intensity { get; set; }
        public String Goal_Weight { get; set; }
        public String Goal_BMI { get; set; }
    }
}
