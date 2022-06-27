using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPC_Warehouse
{
    public partial class PhaReg : System.Web.UI.Page
    {
        ServicePharmacy.SPC_PharmacySoapClient pharmacy = new ServicePharmacy.SPC_PharmacySoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String value = pharmacy.registerPharmacy(txtPid.Text, txtPname.Text, txtPemail.Text, txtPphone.Text, txtPlocation.Text, txtPassword.Text);
            int norecord = Int32.Parse(value);

            if (norecord > 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Pharmacy Register successfull')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Try Again')", true);

            }
        }
    }
}