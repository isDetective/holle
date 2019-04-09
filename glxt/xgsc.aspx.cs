using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class xgsc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GridViewBind();

    }
    public SqlConnection GetCon()
    {
        //实例化SqlConnection对象
        SqlConnection sqlCon = new SqlConnection();
        //实例化SqlConnection对象连接数据库的字符串
        sqlCon.ConnectionString = "server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew";
        return sqlCon;
    }
    public void GridViewBind()
    {
        SqlConnection myConn = GetCon();
        //定义SQL语句
        string SqlStr = "select * from sc";
        //实例化SqlDataAdapter对象
        SqlDataAdapter da = new SqlDataAdapter(SqlStr, myConn);
        //实例化数据集DataSet
        DataSet ds = new DataSet();
        da.Fill(ds, "s");
        //绑定DataList控件
        GridView1.DataSource = ds;//设置数据源，用于填充控件中的项的值列表
        GridView1.DataKeyNames = new string[] { "Sno","Cno" };
        GridView1.DataBind();//将控件及其所有子控件绑定到指定的数据源
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //设置GridView控件的编辑项的索引为选择的当前索引
        GridView1.EditIndex = e.NewEditIndex;
        //数据绑定
        GridViewBind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //设置GridView控件的编辑项的索引为－1，即取消编辑
        GridView1.EditIndex = -1;
        //数据绑定
        GridViewBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //取得编辑行的关键字段的值
        string stuID = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
        string cid = GridView1.DataKeys[e.RowIndex].Values[1].ToString();
        //取得文本框中输入的内容
        
        string Grade = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
        int gg = Convert.ToInt16(Grade);
        
        string sqlStr = "update sc set Grade=" + gg + "  where  Sno='" + stuID + "'and Cno = '"+cid+"'";
        SqlConnection myConn = GetCon();
        myConn.Open();
        SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
        myCmd.ExecuteNonQuery();
        myCmd.Dispose();
        myConn.Close();
        GridView1.EditIndex = -1;
        GridViewBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView theGrid = sender as GridView;
        int newPageIndex = 0;
        if (e.NewPageIndex == -3)
        {
            //点击了Go按钮
            TextBox txtNewPageIndex = null;

            //GridView较DataGrid提供了更多的API，获取分页块可以使用BottomPagerRow 或者TopPagerRow，当然还增加了HeaderRow和FooterRow
            GridViewRow pagerRow = theGrid.BottomPagerRow;

            if (pagerRow != null)
            {
                //得到text控件
                txtNewPageIndex = pagerRow.FindControl("txtNewPageIndex") as TextBox;
            }
            if (txtNewPageIndex != null)
            {
                //得到索引
                newPageIndex = int.Parse(txtNewPageIndex.Text) - 1;
            }
        }
        else
        {
            //点击了其他的按钮
            newPageIndex = e.NewPageIndex;
        }
        //防止新索引溢出
        newPageIndex = newPageIndex < 0 ? 0 : newPageIndex;
        newPageIndex = newPageIndex >= theGrid.PageCount ? theGrid.PageCount - 1 : newPageIndex;

        //得到新的值
        theGrid.PageIndex = newPageIndex;

        //重新绑定

        GridViewBind();
    }
}