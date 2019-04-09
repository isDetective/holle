<%@ Page Language="C#" AutoEventWireup="true" CodeFile="load.aspx.cs" Inherits="load" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登陆系统</title>
    <link href="load.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="box">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="请输入账号" CssClass="a"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="请输入密码"  TextMode="Password" CssClass="a"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="登陆" onclick="Button1_Click" CssClass="b" />
    </div>
    </div>
    </form>
</body>
</html>
