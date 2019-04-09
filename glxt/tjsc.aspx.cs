using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class tjsc : System.Web.UI.Page
{
    SqlConnection sqlconn = new SqlConnection("server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridViewDataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sno = TextBox1.Text;
        string cno = TextBox2.Text;
        double g= Convert.ToDouble(TextBox3.Text);
        string sqltext = "insert into sc(Sno,Cno,Grade) values ('" + sno + "','" + cno + "','" + g + "')";
        //  Label1.Text = sqltext;
        SqlCommand cmd = new SqlCommand(sqltext, sqlconn);
        sqlconn.Open();

        int countrecord = cmd.ExecuteNonQuery();

        string sqltext2 = "select * from sc";
        SqlCommand cmd2 = new SqlCommand(sqltext2, sqlconn);

        SqlDataReader sdr = cmd2.ExecuteReader();

        GridView2.DataSource = sdr;

        GridView2.DataBind();
        sqlconn.Close();

        TextBox1.Text = TextBox2.Text = TextBox3.Text = "";}

       protected void GridViewDataBind()
    {
        SqlConnection sqlconn = new SqlConnection("server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew");

        string sqltext = "select * from sc";
        SqlCommand cmd = new SqlCommand(sqltext, sqlconn);
        // SqlDataReader datar;

        sqlconn.Open();


        SqlDataAdapter ad = new SqlDataAdapter(sqltext, sqlconn);

        DataSet ds = new DataSet();
        ad.Fill(ds, "s");
        GridView2.DataSource = ds;
        GridView2.DataBind();


        sqlconn.Close();



    }
    }
