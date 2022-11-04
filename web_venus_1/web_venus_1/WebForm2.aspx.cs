using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Session["takim"] != null)
            {
                RadioButtonList1.SelectedValue = Convert.ToString(Session["takim"]);
                RadioButtonList2.SelectedValue = Convert.ToString(Session["araba"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["takim"] = RadioButtonList1.SelectedValue;
            Session["araba"] = RadioButtonList2.SelectedValue;
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}