using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClassLibraryy;

namespace Co_op_Front_Office
{
    public partial class APersonalInjury : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            string Error;
            string TypeOfInjury;
            TypeOfInjury = txtTypeOfInjury.Text;
            Error = APersonalInjury.Valid(TypeOfInjury);
            lblError.Text = Error;
        }
    }
}