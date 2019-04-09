using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class load : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection sqlconn = new SqlConnection("server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew");
        string id = TextBox1.Text;
        string pw = TextBox2.Text;
        string idd = "";
        string pww = "";
        string sqltext = "select id,pw from gl where id='" + id + "'and pw ='" + pw + "'";
        SqlCommand cmd = new SqlCommand(sqltext, sqlconn);
        sqlconn.Open();
        SqlDataReader sdr = cmd.ExecuteReader();
        while (sdr.Read()) 
        {
            idd = sdr["id"].ToString();
            pww = sdr["pw"].ToString();
        }
        sqlconn.Close();
        if (idd != "" && pww != "")
        {
            Server.Transfer("shouye.aspx");
        }
        else 
        {
            Response.Write("<script>alert('用户名或密码错误')</script>");
        }
    }
}