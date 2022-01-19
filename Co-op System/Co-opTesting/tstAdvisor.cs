using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Co_opTesting
{
    [TestClass]
    public class tstAdvisor
    {

        //these lines of code are all for FIND METHOD with all attributes
        //it starts here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        //test method for find function
        [TestMethod]
            public void FindMethodOK()
            {
                //create instance of the class we want to create
                clsAdvisor AnAdvisor = new clsAdvisor();
                //boolean variable to store the results of validation
                Boolean Found = false;
                //boolean to record if data is OK
                Boolean OK = true;
                //some test data to use with the method
                Int32 AdvisorID = 1;
                //invoke the method
                Found = AnAdvisor.Find(AdvisorID);

                //check the ClientID
                if (AnAdvisor.AdvisorID != 1)
                {
                    OK = false;
                }

                //test to see if the result is true
                Assert.IsTrue(OK);
            }

       
    }
}
