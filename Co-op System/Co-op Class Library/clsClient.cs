using System;

namespace Co_op_Class_Library
{
    public class clsClient
    {
        //find function
        public bool Find(int ClientID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@ClientID", ClientID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByClientID");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {
                mClientID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mOrderValue = Convert.ToInt32(DB.DataTable.Rows[0]["OrderValue"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mDeliveryTown = Convert.ToString(DB.DataTable.Rows[0]["DeliveryTown"]);

                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false if there's a problem
                return false;

            }
        }//end of find function
    }
}