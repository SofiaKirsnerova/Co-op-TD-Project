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
            //if the name of the personal injury is not blank
            if (somePersonalInjury != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The Personal Injury must not be blank";
            }
        }
    }
}