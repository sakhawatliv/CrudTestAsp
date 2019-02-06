using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTest.Department
{
    public partial class Index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string query = null;

            connectionString = @"Data Source=DESKTOP-1HKAK02\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security = true";
            query = "SELECT * FROM Department";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query,connection);

            adapter.SelectCommand = command;
            adapter.Fill(ds, "Department");
            adapter.Dispose();
            connection.Dispose();
            connection.Close();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        Response.Write(row[col]);
                    }

                }


            }

        }
    }
}