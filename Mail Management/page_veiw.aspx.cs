using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mail_Management
{
    public partial class page_veiw : System.Web.UI.Page
    {
        datacon cl= new datacon();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            { 
            Label6.Text = Request.QueryString["mid"];
            string s = "select sid,rid,subject,body,date,file from compose where mid='"+Label6.Text+"'";
            DataSet ds = new DataSet();
            ds = cl.getdata(s);
            Label1.Text = ds.Tables[0].Rows[0][0].ToString();
            Label2.Text = ds.Tables[0].Rows[0][1].ToString();
            Label3.Text = ds.Tables[0].Rows[0][2].ToString();
            Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            Label5.Text = ds.Tables[0].Rows[0][4].ToString();

            HyperLink1.NavigateUrl = ds.Tables[0].Rows[0][5].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string s = "delete from compose where mid='" + Label6.Text + "'";
            cl.setdata(s);
            Response.Redirect("page_Inbox.aspx");
           
        }
    }
}