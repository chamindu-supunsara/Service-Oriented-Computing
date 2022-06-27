using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace Web_Site_Server
{
    /// <summary>
    /// Summary description for SPC_Pharmacy
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SPC_Pharmacy : System.Web.Services.WebService
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
        public String registerPharmacy(String PharmacyID, String PharmacyName, String PharmacyEmail, String PharmacyPhoneNumber, String PharmacyLocation, String Password)
        {
            int pharmacy = 0;

            try
            {
                getConnection();

                SqlCommand cmd = new SqlCommand("insert into PharmacyTbl values('" + PharmacyID + "', '" + PharmacyName + "', '" + PharmacyEmail + "',  '" + PharmacyPhoneNumber + "',  '" + PharmacyLocation + "',  '" + Password + "');", sqlCon);

                pharmacy = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return pharmacy.ToString();
        }


        [WebMethod]

        public DataSet searchDrugs(String stockID)
        {
            DataSet search = new DataSet();

            try
            {
                getConnection();

                SqlCommand cmd = new SqlCommand("Select * from StockTbl where Drug_ID = '" + stockID + "'", sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(search, "StockTbl");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not Available in Stock" + ex);
            }
            return search;
        }
    }
}
