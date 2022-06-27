using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPC_Warehouse
{
    public partial class PharmacyMain : System.Web.UI.Page
    {
        ServiceOrder.SPC_OrderSoapClient order = new ServiceOrder.SPC_OrderSoapClient();
        ServiceStock.SPC_StockSoapClient stock = new ServiceStock.SPC_StockSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GridViewStock.DataSource = stock.searchDrugs(txtDid.Text);
            GridViewStock.DataBind();
        }

        
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            String value = order.orderItem(txtDid.Text, txtQuantity.Text, txtPid.Text);
            int norecord = Int32.Parse(value);

            if (norecord > 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ordered Successfully')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Try Again')", true);
            }
        }
    }
}