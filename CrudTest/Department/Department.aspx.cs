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
    public partial class Department : System.Web.UI.Page
    {
        string cSring = @"Data Source=DESKTOP-1HKAK02\SQLEXPRESS;Initial Catalog=CrudTest;User Id=sa;Password=mzaman9";

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        
        protected void btnDepCreate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(cSring);
            string departmentName ="'" + txtDepName.Text+ "'";
            string departmentCode ="'"+ txtDepCode.Text+ "'";

            SqlCommand command;
            string query = "";
            query= "INSERT INTO Department(DepartmentName,Code) VALUES("+departmentName+","+departmentCode+")";
            command = new SqlCommand(query, cnn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            cnn.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            //cnn.Close();

            SqlDataReader dtaReader;
            string qryRead = "SELECT * FROM Department";
            SqlCommand cmdRead;
            cmdRead = new SqlCommand(qryRead,cnn);
            dtaReader = cmdRead.ExecuteReader();
            string output = "";
            DataTable tbl = new DataTable();
            while (dtaReader.Read())
            {
                tbl.Columns.Add(dtaReader.GetValue(1).ToString());    
                //Label1.Text = output + dtaReader.GetValue(1);
            }

            //Table1.Load(tbl);
            tbl.Load(dtaReader);
            











        }

        
    }
}