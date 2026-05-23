using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Mail_Management
{
    public partial class page_login : System.Web.UI.Page
    {
        datacon cl= new datacon();  
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select * from udetail where email='"+TextBox2.Text+"'";
            DataSet ds= new DataSet();  
            ds=cl.getdata(s);

            if (ds.Tables[0].Rows.Count!=0)
            {
                Session["a"] = TextBox2.Text;
                Response.Redirect("page_profile.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Id Or Password')</script>");
            }
            

        }
    }
}