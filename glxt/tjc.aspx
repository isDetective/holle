<%@ Page Title="" Language="C#" MasterPageFile="~/mone.master" AutoEventWireup="true" CodeFile="tjc.aspx.cs" Inherits="tjc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
课程号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
课程名<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
学分<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
开课学期<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
先修课程<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
排序值<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>

