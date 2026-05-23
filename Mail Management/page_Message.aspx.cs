using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_Message : System.Web.UI.Page
    {
        datacon cl = new datacon(); 
        protected void Page_Load(object sender, EventArgs e)
        {
           Label1.Text = DateTime.Now.ToShortDateString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "select * from udetail where email='" + TextBox1.Text + "'";
            DataSet ds= new DataSet();
            
            ds=cl.getdata(s);
            if (ds.Tables[0].Rows.Count!= 0 )
            {
                string f="", p;
                if (FileUpload1.HasFile)
                {
                    f = FileUpload1.FileName;
                    p = Server.MapPath("~/files/" + f);
                    FileUpload1.SaveAs(p);
                }
                string s1 = "insert into compose (sid,rid,subject,body,date,file,status) values('" + Session["a"] +"','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Label1.Text + "','files/"+f+ "','Image/p1.jpg')";
                cl.setdata(s1);
                Response.Write("<script>alert('Email Sent Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid Receiver Id')</script>");
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = "insert into draft(sid,rid,subject,body,date) values('" + Session["a"] + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Label1.Text + "')";
            cl.setdata(d);
            Response.Write("<script>alert('Message Added To Draft Successfully')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
        }
    }
}