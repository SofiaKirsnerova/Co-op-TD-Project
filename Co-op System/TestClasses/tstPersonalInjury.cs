using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestClasses
{
    [TestClass]
    public class tstPersonalInjury
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsPersonalInjury
            clsPersonalInjury APersonalInjury = clsPersonalInjury();
            //test to see it exists
            Assert.IsNotNull(APersonalInjury);
        }
    }
}
