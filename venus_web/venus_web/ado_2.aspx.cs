using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venus_web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument); 
                GridViewRow row = GridView1.Rows[index]; 
                string ad = row.Cells[2].Text; 
                string soyad = row.Cells[4].Text;
                Response.Write(index + ". satır: " + ad + " " + soyad);
             }       
         }
    }
}