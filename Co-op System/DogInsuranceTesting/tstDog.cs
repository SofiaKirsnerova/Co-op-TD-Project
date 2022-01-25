using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DogInsuranceTesting
{
    [TestClass]
    public class tstDog
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDog ADog = new clsDog();
            //test to see that it exisits
            Assert.IsNotNull(ADog);
        }

        
    }
}
