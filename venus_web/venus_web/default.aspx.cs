using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venus_web
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HyperLink2.NavigateUrl = "ado_8.aspx?Function=Update&ID="+DropDownList1.SelectedValue;
            HyperLink2.Text = DropDownList1.SelectedValue + " ID'li telefonu değiştireceğim.";

            HyperLink3.NavigateUrl = "ado_8.aspx?Function=Read&ID=" + DropDownList1.SelectedValue;
            HyperLink3.Text = DropDownList1.SelectedValue + " ID'li telefonun detayını göreceğim.";

            HyperLink4.NavigateUrl = "ado_8.aspx?Function=Delete&ID=" + DropDownList1.SelectedValue;
            HyperLink4.Text = DropDownList1.SelectedValue + " ID'li telefonun detayını sileceğim.";
        }
    }
}