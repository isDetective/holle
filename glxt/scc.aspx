﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mone.master" AutoEventWireup="true" CodeFile="scc.aspx.cs" Inherits="scc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" >
    <Columns>
    <asp:CommandField  ShowDeleteButton="true"/>
    </Columns>
    </asp:GridView>
</asp:Content>

