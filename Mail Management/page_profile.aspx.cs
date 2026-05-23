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
    public partial class page_profile : System.Web.UI.Page
    {
        datacon cl= new datacon();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["a"].ToString();
            string s = "select * from udetail where email='" + Label1.Text + "'";
            DataSet ds= new DataSet();  
            ds= cl.getdata(s);
            Label1.Text= ds.Tables[0].Rows[0][0].ToString();
            Label2.Text= ds.Tables[0].Rows[0][1].ToString();
            Label3.Text= ds.Tables[0].Rows[0][2].ToString();
            Label4.Text= ds.Tables[0].Rows[0][3].ToString();
            Label5.Text= ds.Tables[0].Rows[0][4].ToString();
            Label6.Text= ds.Tables[0].Rows[0][5].ToString();
            Label7.Text= ds.Tables[0].Rows[0][6].ToString();
        }
    }
}