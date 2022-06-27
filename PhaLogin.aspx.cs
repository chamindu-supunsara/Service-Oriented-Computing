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
    public partial class PhaLogin : System.Web.UI.Page
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
            string checkpharmacy = "select count(*) from PharmacyTbl where Pharmacy_ID='" + txtPhaLogin.Text + "'";
            SqlCommand com = new SqlCommand(checkpharmacy, sqlCon);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            sqlCon.Close();
            if (temp == 1)
            {
                sqlCon.Open();
                String checkpasswordQuery = "select password from PharmacyTbl where Pharmacy_ID='" + txtPhaLogin.Text + "'";
                SqlCommand passComm = new SqlCommand(checkpasswordQuery, sqlCon);
                string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtPhaPassword.Text)
                {
                    Response.Redirect("PharmacyMain.aspx");
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