using System;
using System.Collections.Generic;

namespace HealthApp
{
    [Serializable]
    public class Client
    {
        public string firstName;
        public string lastName;
        public string gender;
        public string ethnicity;
        public int heightFt;
        public int heightIn;
        public int weight;
        public double bmi;
        public int birthYear;
        public int birthDay;
        public int birthMonth;
        public string Age;
        public string allergy;
        public string pcp;
        public string bmiCategory;

        public Client() { }
    }
}
