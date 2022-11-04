using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["toplam"] != null)
                {
                    Label1.Text = Convert.ToString(Session["toplam"]);
                    ListBox1.Items.AddRange((ListItem[])Session["MyListBox1Items"]);
                    ListBox2.Items.AddRange((ListItem[])Session["MyListBox2Items"]);
                }
                else
                {
                    ListItem li = new ListItem("Elma", "20");
                    ListBox1.Items.Add(li);
                    li = new ListItem("Armut", "25");
                    ListBox1.Items.Add(li);
                    li = new ListItem("Şeftali", "15");
                    ListBox1.Items.Add(li);
                    li = new ListItem("Patates", "5");
                    ListBox1.Items.Add(li);
                    ViewState["ToplamFiyat"] = "0";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count > 0 && ListBox1.SelectedIndex != -1)
            {
                string secilen = ListBox1.SelectedItem.Text ;
                string fiyat = ListBox1.SelectedValue;

                ListItem li = new ListItem (secilen, fiyat);
                ListBox1.Items.Remove(li);
                ListBox2.Items.Add(li);
                fiyatHesapla(Convert.ToInt32(fiyat));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox2.Items.Count > 0 && ListBox2.SelectedIndex != -1)
            {
                string secilen = ListBox2.SelectedItem.Text;
                string fiyat = ListBox2.SelectedValue;

                ListItem li = new ListItem(secilen, fiyat);
                ListBox2.Items.Remove(secilen); 
                ListBox1.Items.Add(li);
                fiyatHesapla(-1*Convert.ToInt32(fiyat));
            
            }
        }
        void fiyatHesapla(int fiyat)
        {
            int toplamFiyat = Convert.ToInt32(ViewState["ToplamFiyat"]);
            toplamFiyat += fiyat;
            ViewState["ToplamFiyat"] = toplamFiyat;
            Label1.Text = Convert.ToString(toplamFiyat);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["toplam"] = Convert.ToInt32(Label1.Text);
            Session["MyListBox1Items"] = ListBox1.Items.Cast<ListItem>().ToArray();
            Session["MyListBox2Items"] = ListBox2.Items.Cast<ListItem>().ToArray();
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}