using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTest.Student
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Simple Connection Buildup*/
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=DESKTOP-1HKAK02\SQLEXPRESS;Initial Catalog=CrudTest;User Id=sa;Password=mzaman9";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //Response.Write("Connection Made");
            //cnn.Close();

            /*Simple Connection Buildup*/


            /*Insert Operation*/
            SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "INSERT INTO Department(DepartmentName,Code) VALUES('ETE','003')";

            command = new SqlCommand(sql, cnn);
            //adapter.InsertCommand = command;
            //adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            //cnn.Close();
            /*Insert Operation*/


            /*Data Read*/
            SqlCommand commandRead;
            SqlDataReader dataReader;
            string SqlRead, Output = " ";
            SqlRead = "SELECT * FROM Department";
            commandRead = new SqlCommand(SqlRead, cnn);
            dataReader = commandRead.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + " - " + dataReader.GetValue(1) + "</br>";
                
            }
            Response.Write(Output);
            cnn.Close();

            /*Data Read*/


            /*Data Update*/

            SqlCommand commandUpdate;

            string sqlUpdate = "";
            sqlUpdate = "Update Department SET Code='006' WHERE Id=12";
            commandUpdate = new SqlCommand(sqlUpdate,cnn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            
            cnn.Open();
            adapter.UpdateCommand = commandUpdate;
            adapter.UpdateCommand.ExecuteNonQuery();
            cnn.Close();

            /*Data Update*/

        }
    }
}