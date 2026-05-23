using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Mail_Management
{
    public class datacon
    {
        MySqlCommand cmd;
        MySqlConnection con;
        MySqlDataAdapter da;
        
        

        public datacon()
        {
            con = new MySqlConnection("server=localhost;user=root;database=mail");
            con.Open();
        }

        public void setdata(string s)
        {
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
        }

        public DataSet getdata(string s)
        {
            da = new MySqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }

    }