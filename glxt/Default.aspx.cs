using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected static PagedDataSource ps = new PagedDataSource();//创建一个分页数据源的对象且一定要声明为静态
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind(0);//数据绑定
        }
    }
    //进行数据绑定的方法
    public void Bind(int CurrentPage)
    {
        //实例化SqlConnection对象
        SqlConnection sqlCon = new SqlConnection();
        //实例化SqlConnection对象连接数据库的字符串
        sqlCon.ConnectionString = "server=S404-37\\SQLEXPRESS;uid=sa;pwd=1;database=libnew";
        //定义SQL语句
        string SqlStr = "select * from s order by 学号";
        //实例化SqlDataAdapter对象
        SqlDataAdapter da = new SqlDataAdapter(SqlStr, sqlCon);
        //实例化数据集DataSet
        DataSet ds = new DataSet();
        da.Fill(ds, "s");

        ps.DataSource = ds.Tables["s"].DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 4; //显示的数量
        ps.CurrentPageIndex = CurrentPage; //取得当前页的页码
       
        this.DataList1.DataSource = ps;
        this.DataList1.DataKeyField = "学号";
        this.DataList1.DataBind();
    }
   
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            //以下5个为 捕获用户点击 上一页 下一页等时发生的事件
            case "first"://第一页
                ps.CurrentPageIndex = 0;
                Bind(ps.CurrentPageIndex);
                break;
            case "pre"://上一页
                ps.CurrentPageIndex = ps.CurrentPageIndex - 1;
                Bind(ps.CurrentPageIndex);
                break;
            case "next"://下一页
                ps.CurrentPageIndex = ps.CurrentPageIndex + 1;
                Bind(ps.CurrentPageIndex);
                break;
            case "last"://最后一页
                ps.CurrentPageIndex = ps.PageCount - 1;
                Bind(ps.CurrentPageIndex);
                break;
            case "search"://页面跳转页
                if (e.Item.ItemType == ListItemType.Footer)
                {
                    int PageCount = int.Parse(ps.PageCount.ToString());
                    TextBox txtPage = e.Item.FindControl("txtPage") as TextBox;
                    int MyPageNum = 0;
                    if (!txtPage.Text.Equals(""))
                        MyPageNum = Convert.ToInt32(txtPage.Text.ToString());
                    if (MyPageNum <= 0 || MyPageNum > PageCount)
                        Response.Write("<script>alert('请输入页数并确定没有超出总页数！')</script>");
                    else
                        Bind(MyPageNum - 1);
                }
                break;
        }
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Footer)
        {
            //以下六个为得到脚模板中的控件,并创建变量
            Label CurrentPage = e.Item.FindControl("labNowPage") as Label;
            Label PageCount = e.Item.FindControl("labCount") as Label;
            LinkButton FirstPage = e.Item.FindControl("lnkbtnFirst") as LinkButton;
            LinkButton PrePage = e.Item.FindControl("lnkbtnFront") as LinkButton;
            LinkButton NextPage = e.Item.FindControl("lnkbtnNext") as LinkButton;
            LinkButton LastPage = e.Item.FindControl("lnkbtnLast") as LinkButton;
            CurrentPage.Text = (ps.CurrentPageIndex + 1).ToString();//绑定显示当前页
            PageCount.Text = ps.PageCount.ToString();//绑定显示总页数
            if (ps.IsFirstPage)//如果是第一页,首页和上一页不能用
            {
                FirstPage.Enabled = false;
                PrePage.Enabled = false;
            }
            if (ps.IsLastPage)//如果是最后一页"下一页"和"尾页"按钮不能用
            {
                NextPage.Enabled = false;
                LastPage.Enabled = false;
            }
        }
    }
}
