using System;

namespace Co_opClassLibraryy
{
    public class clsPersonalInjury
    {
        public string TypeOfInjury { get; set; }
        public string Severity { get; set; }
        public decimal Compensation { get; set; }
        public int PersonalInjuryID { get; set; }

        public string Valid(string somePersonalInjury)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the personal injury is more than 50 characters
            if (somePersonalInjury.Length > 50)
            {
                //return a blank string
                Error = "The Personal Injury cannot have more than 50 characters";
            }
            if (somePersonalInjury.Length == 0)
            {
                //return an error message
                Error = "The Personal Injury must not be blank";
            }
            return Error;
        }
    }
}