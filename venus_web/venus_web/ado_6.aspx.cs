using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venus_web
{
    public partial class ado_6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection MyConnection;
                SqlCommand MyCommand;
                SqlDataAdapter MyAdapter;
                DataTable myTable = new DataTable();

                MyConnection = new SqlConnection();
                MyConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ConnectionString;

                MyCommand = new SqlCommand();
                MyCommand.CommandText = "SELECT TOP 10 [Title], [FirstName], [MiddleName], [LastName] FROM [Person].[Person]";
                MyCommand.CommandType = CommandType.Text;
                MyCommand.Connection = MyConnection;

                MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                MyAdapter.Fill(myTable);

                GridView1.DataSource = myTable.DefaultView;
                GridView1.DataBind();

                MyAdapter.Dispose();
                MyCommand.Dispose();
                MyConnection.Dispose();
            }
        }
    }
}