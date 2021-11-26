using NetWebForm.資料讀取;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test.資料讀取
{
    public partial class XSDTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            guestbook _guestbook = new guestbook();
            _guestbook = (guestbook)GetDataTable();
        }

        DataSet GetDataTable()
        {
            string conn = ConfigurationManager.ConnectionStrings["tesConn"].ConnectionString;

            DataSet ds = new DataSet();
            string strSQL = @"select * from users";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, connection);
                adapter.Fill(ds);
                adapter.SelectCommand.Parameters.Clear();

                connection.Close();
                return ds;
            }
        }
    }
}