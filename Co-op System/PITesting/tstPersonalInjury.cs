using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PITesting
{
    [TestClass]
    public class tstPersonalInjury
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //test to see it exists
            Assert.IsNotNull(APersonalInjury);
        }

        [TestMethod]
        public void TypeOfInjuryOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            string SomeTypeOfInjury = "Head";
            //assign the data to the property
            APersonalInjury.TypeOfInjury = SomeTypeOfInjury;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.TypeOfInjury, SomeTypeOfInjury);
        }

        [TestMethod]
        public void SeverityOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            string SomeSeverity = "Moderate";
            //assign the data to the property
            APersonalInjury.Severity = SomeSeverity;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.Severity, SomeSeverity);
        }

        public void CompensationOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            Decimal Compensation = 50.00M;
            //assign the data to the property
            APersonalInjury.Compensation = Compensation;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.Compensation, Compensation);
        }

        [TestMethod]
        public void PersonalInjuryIDOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create some test data to assign to the property
            Int32 PersonalInjuryID = 1;
            //assign the data to the property
            APersonalInjury.PersonalInjuryID = PersonalInjuryID;
            //test to see it exists
            Assert.AreEqual(APersonalInjury.PersonalInjuryID, PersonalInjuryID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            //create a string variable to store the result of validation
            String Error = "";
            //create some test data to test the method
            string SomePersonalInjury = "Head";
            //invoke the method
            Error = APersonalInjury.Valid(SomePersonalInjury);
            //test to see it exists
            Assert.AreEqual(Error, "");
        }
    }
}
