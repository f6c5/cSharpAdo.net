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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            string baglanStr = ConfigurationManager.ConnectionStrings["db_eticaretConnectionString"].ConnectionString;
            baglanti = new SqlConnection(baglanStr);

            komut = new SqlCommand("INSERT INTO login (LoginName, Password) VALUES(@LoginName, @Password)", baglanti);
            komut.Parameters.AddWithValue("@LoginName", TextBox1.Text);
            komut.Parameters.AddWithValue("@Password", TextBox2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Response.Redirect("login.aspx");
        }
    }
}