using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPC_Warehouse
{
    public partial class SupperilesMain : System.Web.UI.Page
    {
        ServiceTenders.SPC_TendersSoapClient tenders = new ServiceTenders.SPC_TendersSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String value = tenders.addTenders(txtDrugid.Text, txtDrugname.Text, txtDQuantity.Text, txtProDate.Text, txtExDate.Text);
            int norecord = Int32.Parse(value);

            if (norecord > 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Tender Submited Successfully')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Try Again')", true);

            }
        }
    }
}