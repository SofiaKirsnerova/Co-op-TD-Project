using Co_opClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Co_opTesting
{
    [TestClass]
    public class tstClient
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
                clsClient AClient = new clsClient();
                //boolean variable to store the results of validation
                Boolean Found = false;
                //boolean to record if data is OK
                Boolean OK = true;
                //some test data to use with the method
                Int32 ClientID = 2;
                //invoke the method
                Found = AClient.Find(ClientID);

                //check the ClientID
                if (AClient.ClientID != 2)
                {
                    OK = false;
                }

                //test to see if the result is true
                Assert.IsTrue(OK);
            }
        
    }
}
