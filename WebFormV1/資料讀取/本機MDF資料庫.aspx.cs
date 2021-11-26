using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class 測試mdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["tesConn"].ConnectionString;

            DataTable dt = new DataTable();
            string strSQL = @"select * from users";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, connection);
                adapter.Fill(dt);
                adapter.SelectCommand.Parameters.Clear();

                if (dt != null)
                {
                    Response.Write(dt.Rows.Count.ToString());
                }

                connection.Close();
            }

        }
    }
}