using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class sview : System.Web.UI.Page
    {
        datacon cl = new datacon(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select rid,subject,body,date,file from compose where sid='" + Session["a"] + "'";
            DataSet ds = new DataSet(); 
            ds= cl.getdata(s);  
            Label1.Text = ds.Tables[0].Rows[0][0].ToString();
            Label2.Text = ds.Tables[0].Rows[0][1].ToString();
            Label3.Text = ds.Tables[0].Rows[0][2].ToString();
            Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            HyperLink1.NavigateUrl = ds.Tables[0].Rows[0][4].ToString();

        }
    }
}