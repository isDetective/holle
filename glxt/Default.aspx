<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
      <style type="text/css">
        #DataList1 img
        {
            width:200px;
            height:230px;
            border:1px solid #eaeaea;
            padding:2px;
            margin-left:20px;
            margin-right:10px;
            
            
            
            }#DataList1 tr{
            border-bottom:1px solid #eeaadd;
            margin-bottom:5px;
            
            }
            
            #DataList1 tr td
            {color:#666;
             font-family:微软雅黑;
             font-size:12px;
             padding:5px;
             
                }
         #DataList1 tr td:hover
         {  background:#efefe1;
             }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 590px; height: 218px; margin:0px auto;" cellpadding="0" cellspacing="0"  >
            <tr>
                <td style="width: 112px; height: 240px">
                    <asp:DataList ID="DataList1" runat="server" Width="239px" CellPadding="0" 
                        Height="61px" onitemcommand="DataList1_ItemCommand"   RepeatColumns="2" 
                        onitemdatabound="DataList1_ItemDataBound" RepeatDirection="Horizontal">
                     
                        <ItemTemplate>
                          
                                 <table>
                                 <tr>
                                       <td>
                                   
                                    学号：<asp:Label ID="lblStuID" runat="server" Text='<%# Eval("学号") %>'></asp:Label> </td> </tr>
                                   
                                       <tr>
                                       <td>   姓名：<asp:Label ID="lblStuName" runat="server" Text='<%# Eval("姓名") %>'></asp:Label></td> </tr>
                                   
                                       <tr>
                                       <td>  性别： <asp:Label ID="lblStuSex" runat="server" Text='<%# Eval("性别") %>'></asp:Label></td> </tr>
                                       <tr>
                                       <td>  年龄： <asp:Label ID="lblstuage" runat="server" Text='<%# Eval("年龄") %>'></asp:Label></td> </tr>
                                        <tr>
                                       <td>   所在系：<asp:Label ID="lblstuHobby" runat="server" Text='<%# Eval("所在系") %>'></asp:Label></td> </tr>
                                    <tr> <td>    <asp:Image ID="image1" runat="server" ImageUrl='<%# Eval("照片") %>' /></td> </tr>
                                   
                                    
                                     <tr>
                                       <td>   <a href='editrecord.aspx?xuehao=<%#Eval("学号")%>'>编辑</a></td> </tr>
                              </table>
                        </ItemTemplate>
                        <FooterTemplate>
                            <table style="width: 550px" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 76px; height: 4px" valign="middle">
                                        共有<asp:Label ID="labCount" runat="server" ForeColor="#FF3300" Width="12px"/>页</td>
                                    <td style="width: 78px; height: 4px" valign="middle">
                                        当前<asp:Label ID="labNowPage" runat="server" ForeColor="Brown">1</asp:Label>页</td>
                                    <td style="width: 50px; height: 4px" valign="middle">
                                        <asp:LinkButton ID="lnkbtnFirst" runat="server" CommandName="first"
                                            Font-Underline="False" ForeColor="Black" Width="43px">首页</asp:LinkButton></td>
                                    <td style="width: 60px; height: 4px" valign="middle">
                                        <asp:LinkButton ID="lnkbtnFront" runat="server" CommandName="pre" 
                                            Font-Underline="False" ForeColor="Black" Width="62px">上一页</asp:LinkButton></td>
                                    <td style="width: 56px; height: 4px" valign="middle">
                                        <asp:LinkButton ID="lnkbtnNext" runat="server" CommandName="next"
                                            Font-Underline="False" ForeColor="Black" Width="61px">下一页</asp:LinkButton></td>
                                    <td style="width: 36px; height: 4px" valign="middle">
                                        <asp:LinkButton ID="lnkbtnLast" runat="server" Font-Overline="False" CommandName="last"
                                            Font-Underline="False" ForeColor="Black" Width="38px">尾页</asp:LinkButton></td>
                                    <td style="width: 200px; height: 4px" valign="middle">&nbsp;&nbsp; 跳转至：<asp:TextBox ID="txtPage" runat="server" Width="25px" Height="21px"></asp:TextBox>
                                        <asp:Button ID="Button1" runat="server" CommandName="search" Text="GO" 
                                            Height="19px" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ControlToValidate="txtPage" ErrorMessage="请输入数字（除了数值0）" 
                                            ValidationExpression="[1-9]+(\d)*"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </table>
                        </FooterTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td style="width: 112px; height: 12px">
                    
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
