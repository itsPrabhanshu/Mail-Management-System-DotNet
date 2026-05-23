using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_imp : System.Web.UI.Page
    {
        datacon cl= new datacon();  
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select sid,rid,subject,body,date from compose where status='Image/p2.jpg' and rid='" + Session["a"] + "'";
            DataSet ds= new DataSet();  
            ds= cl.getdata(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();   
        }
    }
}