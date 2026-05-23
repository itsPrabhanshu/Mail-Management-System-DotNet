using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_sent : System.Web.UI.Page
    {
        datacon cl=new datacon();   
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select rid,subject,date from compose where sid='" + Session["a"] + "'";
            DataSet ds = new DataSet(); 
            ds= cl.getdata(s);  
            GridView1.DataSource = ds;  
            GridView1.DataBind();   
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("sview.aspx");
        }
    }
}