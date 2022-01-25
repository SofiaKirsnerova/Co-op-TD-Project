using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PITesting
{
    [TestClass]
    public class tstClaimInjury
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //see it exists
            Assert.IsNotNull(AClaimInjury);
        }

        [TestMethod]
        public void ClaimIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 ClaimID = 1;
            //assign the data to the property
            AClaimInjury.ClaimID = ClaimID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.ClaimID, ClaimID);
        }

        [TestMethod]
        public void InjuryIDOK()
        {
            //create an instance of the class
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            //create some test data to assign to the property
            Int32 InjuryID = 1;
            //assign the data to the property
            AClaimInjury.InjuryID = InjuryID;
            //test to see it exists
            Assert.AreEqual(AClaimInjury.InjuryID, InjuryID); 
        }
    }
}
