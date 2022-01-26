using System;

namespace Co_opClassLibraryy
{
    public class clsClaim
    {
        public string Location { get; set; }
        public string Status { get; set; }
        public int ClaimID { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfInjury { get; set; }
        public bool EvidenceProvided { get; set; }

        public string Valid(string someClaim)
        {
            //if the name of the personal injury is not blank
            if (someClaim != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The Claim must not be blank";
            }
        }
    }
}