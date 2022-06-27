using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace Web_Site_Server
{
    /// <summary>
    /// Summary description for SPC_Supplier
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SPC_Supplier : System.Web.Services.WebService
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
        public String registerSupplier(String SupplierID, String SupplierName, String SupplierNIC, String SupplierPhoneNumber, String SupplierEmail, String Password)
        {
            int supplier = 0;

            try
            {
                getConnection();

                SqlCommand cmd = new SqlCommand("insert into SupplierTbl values('" + SupplierID + "', '" + SupplierName + "', '" + SupplierNIC + "',  '" + SupplierPhoneNumber + "',  '" + SupplierEmail + "',  '" + Password + "');", sqlCon);

                supplier = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return supplier.ToString();
        }
    }
}
