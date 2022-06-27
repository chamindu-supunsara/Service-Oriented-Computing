using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPC_Warehouse
{
    public partial class StaffReg : System.Web.UI.Page
    {
        ServiceSupplier.SPC_SupplierSoapClient supplier = new ServiceSupplier.SPC_SupplierSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String value = supplier.registerSupplier(txtSid.Text, txtSname.Text, txtSnic.Text, txtSphone.Text, txtSemail.Text, txtPassword.Text);
            int norecord = Int32.Parse(value);

            if (norecord > 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Supplier Register successfull')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(' Unsuccessfull Try Again')", true);

            }
        }
    }
}