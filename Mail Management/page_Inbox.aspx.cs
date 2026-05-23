using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_Inbox : System.Web.UI.Page
    { 
        datacon cl = new datacon(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string s = "select * from compose where rid='" + Session["a"] +"'";
       
            DataSet ds = new DataSet(); 
            ds = cl.getdata(s);
            GridView1.DataSource = ds;
            
            GridView1.DataBind();   
        }

        protected void LinkButton_1_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandName;
            string s;
            s = "select status from compose where mid=" + id;
            DataSet ds = new DataSet();
            ds = cl.getdata(s);

            string fname = ds.Tables[0].Rows[0][0].ToString();
            if (fname == "Image/p1.jpg")
                s = "update compose set status='Image/p2.jpg' where mid=" + id;
            else
                s = "update compose set status='Image/p1.jpg' where mid=" + id;

            cl.setdata(s);

            Response.Redirect("page_inbox.aspx");            

        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            string id= e.CommandName;
            Response.Redirect("page_veiw.aspx?mid="+id);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}