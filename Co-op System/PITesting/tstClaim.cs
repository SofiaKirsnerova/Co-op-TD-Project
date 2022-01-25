using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PITesting
{
    [TestClass]
    public class tstClaim
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //test to see it exists
            Assert.IsNotNull(AClaim);
        }

        [TestMethod]
        public void LocationOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            string SomeLocation = "Leicester";
            //assign the data to the property
            AClaim.Location = SomeLocation;
            //test to see it exists
            Assert.AreEqual(AClaim.Location, SomeLocation);   
        }

        [TestMethod]
        public void StatusOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            string SomeStatus = "In Progress";
            //assign the data to the property
            AClaim.Status = SomeStatus;
            //test to see it exists
            Assert.AreEqual(AClaim.Status, SomeStatus);
        }

        [TestMethod]
        public void ClaimIDOK()
        {
            //create an instance of the class
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            Int32 ClaimID = 1;
            //assign the data to the property
            AClaim.ClaimID = ClaimID;
            //test to see it exists
            Assert.AreEqual(AClaim.ClaimID, ClaimID);
        }

        [TestMethod]
        public void DateOfClaimOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AClaim.DateOfClaim = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.DateOfClaim);
        }

        [TestMethod]
        public void DateOfInjuryOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AClaim.DateOfInjury = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.DateOfInjury);
        }

        [TestMethod]
        public void EvidenceProvidedOK()
        {
            //create an instance of the class clsTrainers
            clsClaim AClaim = new clsClaim();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AClaim.EvidenceProvided = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, AClaim.EvidenceProvided);
        }

    }
}
