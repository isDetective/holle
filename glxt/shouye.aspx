<%@ Page Title="" Language="C#" MasterPageFile="~/mone.master" AutoEventWireup="true" CodeFile="shouye.aspx.cs" Inherits="shouye" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="App_Themes/主题1/StyleSheet.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript">
         var int = self.setInterval("change()", 2 * 1000);
         var time = self.setInterval("clock()", 3 * 1000);
         var i = 1;
         function clock() {
             i = i + 1;
             if (i == 5) {
                 i = 1;
             }
         }
         function change() {
             var a = document.getElementById("ContentPlaceHolder1_transImageBox");
             a.style.marginLeft = (1 - i) * 500 + "px";
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="xx" >
    <div class=" trans_box">
    <div id="transImageBox" class="trans_image_box" runat="server">
                <img class="trans_image" src="img/t001.jpg" />
                <img class="trans_image" src="img/t002.jpg" />
                <img class="trans_image" src="img/t003.jpg" />
                <img class="trans_image" src="img/t004.jpg" />
   </div>
   </div>
   
   </div>
</asp:Content>

