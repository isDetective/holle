using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class tjc : System.Web.UI.Page
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
        string kch= TextBox1.Text;
        string kcm = TextBox2.Text;
        double xf =  Convert.ToDouble( TextBox3.Text);
        double kkxq = Convert.ToDouble(TextBox4.Text);
        string xxkc = TextBox5.Text;
        int pxz = Convert.ToInt16(TextBox6.Text);
        string sqltext = "insert into c(课程号,课程名,学分,开课学期,先修课程,排序值) values ('" + kch + "','" + kcm + "'," + xf + "," + kkxq + ",'" + xxkc + "',"+pxz+")";
        //  Label1.Text = sqltext;
        SqlCommand cmd = new SqlCommand(sqltext, sqlconn);
        sqlconn.Open();

        int countrecord = cmd.ExecuteNonQuery();

        string sqltext2 = "select * from c";
        SqlCommand cmd2 = new SqlCommand(sqltext2, sqlconn);

        SqlDataReader sdr = cmd2.ExecuteReader();

        GridView2.DataSource = sdr;

        GridView2.DataBind();
        sqlconn.Close();

        TextBox1.Text = TextBox2.Text = TextBox3.Text = "";}

       protected void GridViewDataBind()
    {
        SqlConnection sqlconn = new SqlConnection("server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew");

        string sqltext = "select * from c";
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
