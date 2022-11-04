using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["LoginId"] != null)
                {
                    Response.Redirect("profilim.aspx");
                }
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (isCorrect(Login1.UserName, Login1.Password))
            {
                e.Authenticated = true;
                Response.Redirect("profilim.aspx");
            }
            else
            {
                e.Authenticated = false;
                Session.Remove("LoginID");
            }
        }
        private bool isCorrect(string userName, string Password)
        {
            SqlConnection MyConnection;
            SqlCommand MyCommand;
            SqlDataReader MyReader;

            bool success=false;
            MyConnection = new SqlConnection();
            MyConnection.ConnectionString = ConfigurationManager.ConnectionStrings["db_eticaretConnectionString"].ConnectionString;

            MyCommand = new SqlCommand();
            MyCommand.CommandText = "SELECT LoginID FROM login WHERE LoginName=@LoginName AND Password=@Password";
            MyCommand.CommandType = CommandType.Text;
            MyCommand.Connection = MyConnection;
            MyCommand.Parameters.AddWithValue("@LoginName", userName);
            MyCommand.Parameters.AddWithValue("@Password", Password);

            MyCommand.Connection.Open();
            MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (MyReader.HasRows)
            {
                MyReader.Read();
                Session["LoginId"] = MyReader["LoginID"].ToString();
                success = true;
            }
            MyCommand.Dispose();
            MyConnection.Dispose();
            return success;
        }

    }
}