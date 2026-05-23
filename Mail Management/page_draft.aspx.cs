using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mail_Management
{
    public partial class page_draft : System.Web.UI.Page
    {
        datacon cl= new datacon();  
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select rid,subject,body,date from draft where sid='" + Session["a"] + "'";
            DataSet ds = new DataSet();
            
            ds= cl.getdata(s);

            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
                Response.Write("<script>alert('record not found')</script>");

        }
    }
}