using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["ad"].ToString();
            Label2.Text = Session["soyad"].ToString();
            Label3.Text = Session["dtarihi"].ToString();
            Label4.Text = Session["dyeri"].ToString();
            Label5.Text = Session["email"].ToString();
            Label6.Text = Session["ceptel"].ToString();
            Label7.Text = Session["takim"].ToString();
            Label8.Text = Session["araba"].ToString();
            Label9.Text = Session["toplam"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}