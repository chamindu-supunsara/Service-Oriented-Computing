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
    public partial class StaffLogin : System.Web.UI.Page
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
            string checkstaff = "select count(*) from StaffTbl where Staff_ID='" + txtStaffLogin.Text + "'";
            SqlCommand com = new SqlCommand(checkstaff, sqlCon);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            sqlCon.Close();
            if (temp == 1)
            {
                sqlCon.Open();
                String checkpasswordQuery = "select password from StaffTbl where Staff_ID='" + txtStaffLogin.Text + "'";
                SqlCommand passComm = new SqlCommand(checkpasswordQuery, sqlCon);
                string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtStPassword.Text)
                {
                    Response.Redirect("StaffMain.aspx");
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