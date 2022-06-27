using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPC_Warehouse
{
    public partial class StaffMain : System.Web.UI.Page
    {
        ServiceStock.SPC_StockSoapClient stock = new ServiceStock.SPC_StockSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String value = stock.addStock(txtDid.Text, txtDname.Text, txtQuantity.Text, txtPdate.Text, txtEdate.Text);
            int norecord = Int32.Parse(value);

            if (norecord > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Stock Added Successfully')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Try Again')", true);
            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            stock.updateQuantity(txtDid.Text, Convert.ToInt32(txtQuantity.Text));

            GridViewStock.DataSource = stock.searchDrugs(txtDid.Text);
            GridViewStock.DataBind();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(' Record Updated')", true);
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GridViewStock.DataSource = stock.searchDrugs(txtDid.Text);
            GridViewStock.DataBind();
        }
    }
}