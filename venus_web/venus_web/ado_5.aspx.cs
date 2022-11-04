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
    public partial class ado_5 : System.Web.UI.Page
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
                MyCommand.CommandText = "SELECT [Title], [FirstName], [MiddleName], [LastName] FROM [Person].[Person] WHERE BusinessEntityID<=25";
                MyCommand.CommandType = CommandType.Text;
                MyCommand.Connection = MyConnection;

                MyCommand.Connection.Open();
                MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                GridView1.DataSource = MyReader;
                GridView1.DataBind();
                MyCommand.Dispose();

                // DropDownlist1
                MyCommand = new SqlCommand();
                MyCommand.CommandText = "SELECT [TerritoryID], [Name] FROM [Sales].[SalesTerritory]";
                MyCommand.CommandType = CommandType.Text;
                MyCommand.Connection = MyConnection;

                MyCommand.Connection.Open();
                MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DropDownList1.DataValueField = "TerritoryID";
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataSource = MyReader;
                DropDownList1.DataBind();
                DropDownList1.Items.Add(new ListItem("Bir Bölge seçiniz","0"));
                DropDownList1.SelectedValue = "0";


                // CheckBoxList1
                MyCommand = new SqlCommand();
                MyCommand.CommandText = "SELECT [TerritoryID], [Name] FROM [Sales].[SalesTerritory] WHERE TerritoryID<=5";
                MyCommand.CommandType = CommandType.Text;
                MyCommand.Connection = MyConnection;

                MyCommand.Connection.Open();
                MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                CheckBoxList1.DataValueField = "TerritoryID";
                CheckBoxList1.DataTextField = "Name";
                CheckBoxList1.DataSource = MyReader;
                CheckBoxList1.DataBind();

                MyConnection.Dispose();
            }
        }
    }
}