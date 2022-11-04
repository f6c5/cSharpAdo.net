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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string function = Request.QueryString["Function"];
                ViewState["function"] = function;
                string id = Request.QueryString["ID"];
                
                if (function == "New")
                {
                    txtDate.Text = DateTime.Now.ToString();
                    txtDate.Enabled = false;
                    Button1.Text = "Insert";
                }
                else if (function == "Update" || function == "Read" || function == "Delete")
                {
                    SqlConnection MyConnection;
                    SqlCommand MyCommand;
                    SqlDataReader MyReader;

                    //GridView1
                    MyConnection = new SqlConnection();
                    MyConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ConnectionString;

                    MyCommand = new SqlCommand();
                    MyCommand.CommandText = "SELECT BusinessEntityID, PhoneNumber, PhoneNumberTypeID, ModifiedDate FROM Person.PersonPhone WHERE BusinessEntityID="+id;
                    MyCommand.CommandType = CommandType.Text;
                    MyCommand.Connection = MyConnection;

                    MyCommand.Connection.Open();
                    MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            txtID.Text = MyReader["BusinessEntityID"].ToString();
                            txtPhoneNumber.Text = MyReader["PhoneNumber"].ToString();
                            ddlPTypeID.SelectedValue = MyReader["PhoneNumberTypeID"].ToString();
                            txtDate.Text = MyReader["ModifiedDate"].ToString();
                            txtDate.Enabled = false;
                        }
                    }
                    MyCommand.Dispose();
                    MyConnection.Dispose();

                    if (function == "Update") //Update
                    {
                        Button1.Text = "Update";
                        txtDate.Text = DateTime.Now.ToString();
                        txtID.Enabled = false;
                    }
                    else if (function == "Read")//Read
                    {
                        Button1.Visible = false;
                        txtID.Enabled = false;
                        txtPhoneNumber.Enabled = false;
                        ddlPTypeID.Enabled = false;
                    }
                    else // Delete
                    {
                        Button1.Text= "Delete";
                        txtID.Enabled = false;
                        txtPhoneNumber.Enabled = false;
                        ddlPTypeID.Enabled = false;
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string function = ViewState["function"].ToString();

            if (Page.IsValid)
            {
                SqlConnection baglanti;
                SqlCommand komut;
                string baglanStr = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ConnectionString;
                baglanti = new SqlConnection(baglanStr);
                if (function == "Update")
                {
                    komut = new SqlCommand("UPDATE Person.PersonPhone SET PhoneNumber=@PhoneNumber, PhoneNumberTypeID=@PhoneNumberTypeID, ModifiedDate=@ModifiedDate WHERE BusinessEntityID=@BusinessEntityID", baglanti);
                }
                else if (function=="New")
                {
                    komut = new SqlCommand("INSERT INTO Person.PersonPhone (BusinessEntityID, PhoneNumber, PhoneNumberTypeID, ModifiedDate) VALUES(@BusinessEntityID, @PhoneNumber, @PhoneNumberTypeID, @ModifiedDate)", baglanti);
                }
                else // Delete
                {
                    komut = new SqlCommand("DELETE FROM Person.PersonPhone WHERE BusinessEntityID=@BusinessEntityID", baglanti);
                }
                try
                {
                    komut.Parameters.AddWithValue("@BusinessEntityID", Convert.ToInt32(txtID.Text));
                    if (function != "Delete")
                    {
                        komut.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        komut.Parameters.AddWithValue("@PhoneNumberTypeID", Convert.ToInt32(ddlPTypeID.SelectedValue));
                        komut.Parameters.AddWithValue("@ModifiedDate", Convert.ToDateTime(txtDate.Text));
                    }
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    if (function == "Update")
                    {
                        lblMesaj.Text = "Kayıt güncellendi";
                    }
                    else if(function == "New")
                    {
                        lblMesaj.Text = "Kayıt eklendi";
                    }
                    else
                    {
                        lblMesaj.Text = "Kayıt silindi.";
                    }
                }
                catch
                {
                    lblMesaj.Text = "Hata oluştu.";
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }
    }
}