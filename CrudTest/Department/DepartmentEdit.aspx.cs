using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTest.Department
{
    public partial class DepartmentEdit : System.Web.UI.Page
    {
        string cSring = @"Data Source=DESKTOP-1HKAK02\SQLEXPRESS;Initial Catalog=CrudTest;User Id=sa;Password=mzaman9";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(cSring);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand readCommand;
            string query = "SELECT * FROM Department WHERE Id=2";
            readCommand = new SqlCommand(query,cnn);
            dataReader = readCommand.ExecuteReader();
            while (dataReader.Read())
            {
                txtDepName.Text = ((dataReader.GetValue(1)).ToString()).Trim();
                txtDepCode.Text = ((dataReader.GetValue(2)).ToString()).Trim();
            }

            HttpCookie ck = new HttpCookie("Code");
            ck.Value = txtDepCode.Text;
            DateTime dt = DateTime.Now;
            TimeSpan ts= new TimeSpan(0,0,1,0);
            ck.Expires = dt + ts;
            Response.Cookies.Add(ck);
            
            cnn.Close();

            
        }

        protected void btnDepCreate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(cSring);
            string trimQt = ("'").Trim();
            if (IsPostBack)
            {
            string departmentName = trimQt + (this.txtDepName.Text).Trim() + trimQt;
            string departmentCode = trimQt + (this.txtDepCode.Text).Trim() + trimQt;
            SqlCommand command;
            string query = "";
           // query = "INSERT INTO Department(DepartmentName,Code) VALUES(" + departmentName + "," + departmentCode + ")";
            query = "EXEC InsertDepartment @Name="+departmentName+",@Code="+departmentCode+";";
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
            cmdRead = new SqlCommand(qryRead, cnn);
            dtaReader = cmdRead.ExecuteReader();

            }
            if (Request.Cookies["Code"] != null)
            {
                var value = Request.Cookies["Code"].Value;
            }

            Response.Redirect("Index.cshtml");
            
            
        }
    }
}