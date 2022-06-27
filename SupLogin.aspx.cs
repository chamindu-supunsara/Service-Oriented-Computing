using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace SPC_Warehouse
{
    public partial class SupLogin : System.Web.UI.Page
    {
        SqlConnection sqlCon;

        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source =DESKTOP-7OO1QOL; initial catalog=SPC_Warehouse; Integrated Security=True;");
            sqlCon.Open();

        }

        protected void btnStLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string checksupplier = "select count(*) from SupplierTbl where Supplier_ID='" + txtSupLogin.Text + "'";
            SqlCommand com = new SqlCommand(checksupplier, sqlCon);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            sqlCon.Close();
            if (temp == 1)
            {
                sqlCon.Open();
                String checkpasswordQuery = "select password from SupplierTbl where Supplier_ID='" + txtSupLogin.Text + "'";
                SqlCommand passComm = new SqlCommand(checkpasswordQuery, sqlCon);
                string password = passComm.ExecuteScalar().ToString().Replace(" ","");
                if (password == txtSuPassword.Text)
                {
                    Response.Redirect("SupperilesMain.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password is Not Correct')", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Username is Not Correct')", true);
            }
        }
    }
}