using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_signin : System.Web.UI.Page
    {
        datacon cl = new datacon(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string g = "select email from udetail where email='" + TextBox1.Text + "'";
            DataSet ds = new DataSet();
            ds = cl.getdata(g);
            string g1;
            if(RadioButton3.Checked==true)
            {
                g1 = "Male";
            }
            else if(RadioButton4.Checked==true)
            {
                g1= "Female";
            }
            else
            {
                g1= "";
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                string s = "insert into udetail values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + g1 + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
                cl.setdata(s);
                Response.Write("<script>alert('Account Has Been Created Successfully')</script>");

            }
            else
            {
                Response.Write("<script>alert('This Email Has Already Associated With Another Account ')</script>");
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox1.Focus();   
        }
    }
}