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
    public partial class ado_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection MyConnection;
                SqlCommand MyCommand;
                SqlDataReader MyReader;

                //GridView1
                MyConnection = new SqlConnection();
                MyConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ConnectionString;

                MyCommand = new SqlCommand();
                MyCommand.CommandText = "SELECT TOP 10 P.BusinessEntityID, Title, FirstName, LastName, EmailAddress, EmailPromotion FROM Person.Person P INNER JOIN Person.EmailAddress E ON P.BusinessEntityID = E.BusinessEntityID";
                MyCommand.CommandType = CommandType.Text;
                MyCommand.Connection = MyConnection;

                MyCommand.Connection.Open();
                MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                GridView1.DataSource = MyReader;
                GridView1.DataBind();
                MyCommand.Dispose();

                MyConnection.Dispose();
            }
        }

        protected void test(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string value = e.Row.Cells[5].Text;
                if (value == "0")
                {
                    e.Row.Cells[5].Text = "Mail atma";
                }
                else if (value == "1")
                {
                    e.Row.Cells[5].Text = "Sadece duyuru maili at";
                }
                else if (value == "2")
                {
                    e.Row.Cells[5].Text = "Her türlü maili at";
                }
            }

        }
    }
}