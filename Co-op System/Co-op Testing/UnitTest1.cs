using Co_op_Class_Library;
using Co_opClassLibraryy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Co_op_Testing
{
    [TestClass]
    public class tstClient
    {
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create
            clsClient AnOrder = new clsClient();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 CientID = 2;
            //invoke the method
            Found = AnOrder.Find(ClientID);

            //check the ClientID
            if (AnOrder.ClientID != 2)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
