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
    }
}