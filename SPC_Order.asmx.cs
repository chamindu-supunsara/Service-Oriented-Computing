using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace Web_Site_Server
{
    /// <summary>
    /// Summary description for SPC_Order
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SPC_Order : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;

        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source=DESKTOP-7OO1QOL; database=SPC_Warehouse; Integrated Security=True; ");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connectiong to DB" + ex);
            }

            return sqlCon;
        }


        [WebMethod]
        public String orderItem(String DrugID, String Quantity, String PharmacyID)
        {
            int order = 0;

            try
            {
                getConnection();

                SqlCommand cmd = new SqlCommand("insert into OrderitemTbl values('" + DrugID + "', '" + Quantity + "', '" + PharmacyID + "');", sqlCon);

                order = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return order.ToString();
        }
    }
}
