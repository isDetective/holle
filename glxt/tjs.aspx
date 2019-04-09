<%@ Page Title="" Language="C#" MasterPageFile="~/mone.master" AutoEventWireup="true" CodeFile="tjs.aspx.cs" Inherits="tjs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="insertquyu"   >
          
   请输入学号： <asp:TextBox ID="TextBox1" runat="server"  placeholder="填入学号"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ControlToValidate="TextBox1" ErrorMessage="学号不允许为空！" Display="Dynamic" 
          SetFocusOnError="True" ValidationGroup="r_inserte" ForeColor="Red" ></asp:RequiredFieldValidator>
   &nbsp&nbsp&nbsp&nbsp
  
     请输入姓名： <asp:TextBox ID="TextBox2" runat="server"  placeholder="填入姓名"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp
     
请选择性别：<asp:RadioButton ID="RadioButton1" runat="server"  GroupName="sex" Text="男" Checked="true"/>
<asp:RadioButton ID="RadioButton2" runat="server"   GroupName="sex" Text="女"/>
<hr  style=" margin-top:10px; margin-bottom:10px;"/>

       请输入年龄：  <asp:TextBox ID="TextBox3" runat="server"  placeholder="填入年龄整数"></asp:TextBox> 
      <asp:RangeValidator ID="RangeValidator1" runat="server"  MinimumValue="12" 
          MaximumValue="80" Type="Integer"  ErrorMessage="年龄为12——80之间的整数" 
          ControlToValidate="TextBox3" Display="Dynamic" SetFocusOnError="True" 
          ValidationGroup="r_inserte" ForeColor="Red"></asp:RangeValidator>&nbsp&nbsp&nbsp&nbsp
      
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="所在系" DataValueField="所在系" 
        AppendDataBoundItems="True">
            <asp:ListItem Value="xuanze">--请选择所在系--</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:libnewConnectionString2 %>" 
        SelectCommand="SELECT distinct [所在系] FROM [s]"></asp:SqlDataSource>
        <br/>
         <br/>

          <asp:Button ID="Button1" runat="server" Text="确定"    ValidationGroup="r_inserte"
            style="height: 21px" onclick="Button1_Click" />
            </div>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>

