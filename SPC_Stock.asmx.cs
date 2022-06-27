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
    /// Summary description for SPC_Stock
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SPC_Stock : System.Web.Services.WebService
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
        public String addStock(String DrugID, String DrugName, String Quantity, String ProductDate, String ExpirationDate)
        {
            int stock = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into StockTbl values('" + DrugID + "', '" + DrugName + "', '" + Quantity + "',  '" + ProductDate + "',  '" + ExpirationDate + "');", sqlCon);
                stock = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return stock.ToString();
        }


        [WebMethod]

        public bool updateQuantity(String stockID, int newStock)
        {
            bool update = false;
            try
            {
                getConnection();

                SqlCommand cmd = new SqlCommand("update StockTbl set Quantity = Quantity +" + newStock + "where Drug_ID ='" + stockID + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                update = dr.HasRows;
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Try Agian");
            }
            return update;
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
