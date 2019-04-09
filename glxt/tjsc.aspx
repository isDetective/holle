<%@ Page Title="" Language="C#" MasterPageFile="~/mone.master" AutoEventWireup="true" CodeFile="tjsc.aspx.cs" Inherits="tjsc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
sno<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
cno<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
grade<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>

