using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Session["ad"]!=null)
            {
                TextBox1.Text = Convert.ToString(Session["ad"]);
                TextBox2.Text = Convert.ToString(Session["soyad"]);
                Calendar1.SelectedDate = Convert.ToDateTime(Session["dtarihi"]);
                DropDownList1.SelectedValue = Convert.ToString(Session["dyeri"]);
                TextBox3.Text = Convert.ToString(Session["email"]);
                TextBox4.Text = Convert.ToString(Session["ceptel"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["ad"] = TextBox1.Text;
            Session["soyad"]= TextBox2.Text;
            Session["dtarihi"] = Calendar1.SelectedDate;
            Session["dyeri"] = DropDownList1.SelectedValue;
            Session["email"] = TextBox3.Text;
            Session["ceptel"] = TextBox4.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}