using System;

namespace HealthApp
{
    public static class ClientHelper
    {
        public static bool VerifyBirth(string by, string bm, string bd)
        {
            try
            {
                int birthyear = Convert.ToInt32(by);
                int birthmonth = Convert.ToInt32(bm);
                int birthday = Convert.ToInt32(bd);

                bool isValidationSuccessful = isValid(birthyear < (DateTime.Today.Year - 120) || birthyear > DateTime.Today.Year ? false : true, "That is an invalid birth year.") ? true :
                isValid(birthyear == DateTime.Today.Year && birthmonth > DateTime.Today.Month ? false : true, "That is an invalid birth month.") ? true :
                isValid(birthyear == DateTime.Today.Year && birthmonth == DateTime.Today.Month && birthday > DateTime.Today.Day ? false : true, "That is an invalid birth day of the week.") ?
                true : false;
                return isValidationSuccessful;
            }
            catch (Exception e)
            {
                new CustomException("Error trying to verify client birth.", e);
            }
            bool isValid(bool valid, string errorMessage)
            {
                if (valid == false)
                {
                    throw new CustomException(errorMessage);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static string CalculateAge(int birthyear, int birthmonth, int birthday)
        {
            try
            {
                int currentYear = DateTime.Today.Year;
                int currentMonth = DateTime.Today.Month;
                int currentDay = DateTime.Today.Day;

                string ageIfBornThisMonth = (currentDay - birthday).ToString();
                string ageIfBornThisYear = (currentMonth - birthmonth).ToString();
                string ageIfBdayHasPassed = (currentYear - birthyear).ToString();
                string ageIfBdayHasNotPassed = (currentYear - birthyear - 1).ToString();

                //Check age
                string age = birthyear == currentYear && birthmonth == currentMonth && birthday == currentDay ? $"Born today!" :
                birthyear == currentYear && birthmonth == currentMonth ? $"{ageIfBornThisMonth} days" :
                birthyear < currentYear && birthmonth > currentMonth ? $"{ageIfBdayHasNotPassed} years" :
                birthyear < currentYear && birthmonth == currentMonth && birthday > currentDay ? $"{ageIfBdayHasNotPassed} years" :
                birthyear < currentYear && birthmonth == currentMonth && birthday == currentDay ? $"{ageIfBdayHasPassed} - Happy Birthday!" :
                birthyear < currentYear && birthmonth == currentMonth ? ageIfBdayHasPassed : $"{ageIfBdayHasPassed} years";
                return age;
            }
            catch (Exception e)
            {
                new CustomException("Exception caught trying to set age", e);
            }
            return "";
        }
        public static double CalculateBMI(int weight, int heightFt, int heightIn)
        {
            try
            {
                double bmi = Math.Round(Convert.ToDouble(703 * weight) / Math.Pow(Convert.ToDouble(heightFt * 12 + heightIn), 2), 2);
                return bmi;
            }
            catch (Exception e)
            {
                new CustomException("Exception caught trying to set BMI", e);
            }
            return 0;
        }
        public static string SetBMICategory(double bmi)
        {
            try
            {
                string bmiCategory = bmi < 18.5 ? "Underweight" :
                bmi < 24.9 ? "Normal Weight" :
                bmi < 29.9 ? "Overweight" : "Obese";
                return bmiCategory;
            }
            catch (Exception e)
            {
                new CustomException("Error trying to set BMI category.", e);
            }
            return "";
        }
    }
}
