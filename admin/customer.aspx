<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customer.aspx.cs" Inherits="admin_customer" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin-Customercare</title>
   <link href="starrater.css" rel="Stylesheet" type="text/css" />
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .modalBackground
        {  
        	background-color: Gray;  
        	filter: alpha(opacity=50);  
        	opacity: 0.50;
        }
       .updateProgress
       {  
       	border-width: 1px; 
        border-style: solid; 
        background-color: White;  
        position: absolute;  
        width: 180px;  
        height: 65px;
       }  
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
     }
     </style>
    <style type="text/css">
        .style37
        {
            width: 750px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              
        <script type="text/javascript" src="js/tab.js"></script>
	
</head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
    <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr><td></td></tr>
                    <tr><td colspan="2" align="right">
                     <a href="http://www.justcalluz.com/Customer_Care.aspx" target="_blank">
                     <img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                    </td></tr>
                     <tr><td align="right" colspan="6" style="padding-right:5px;padding-bottom:10px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td></tr>
                    <tr><td colspan="3" align="left">
                    <asp:Label ID="lblheader" runat="server" Text="Customer Care" BackColor="Silver" Width="748px" Font-Bold="true" ForeColor="Black"></asp:Label>
                    </td></tr>
                    <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                    <tr>
                    <td colspan="3" align="left" style="padding-left:5px;">
                    <asp:DataList ID="dlcomment" runat="server" Width="750px">
                    <ItemTemplate>
                    <table width="100%">
                    <tr><td align="center" style="color:CadetBlue; font-weight:bold;">
                    <asp:Label ID="lblstatus" runat="server" Text="Status"></asp:Label>:
                    <asp:Label ID="lblstatusval" runat="server" Text='<%#Eval("solved_status")%>'></asp:Label>
                    </td></tr>
                    <tr>
                    <td>
                    Commented By&nbsp;&nbsp;"&nbsp;
                       <asp:Label ID="lblname" runat="server" Text='<%#Eval("Name")%>'></asp:Label> &nbsp;"
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Label ID="lblemail" runat="server" Text='<%#Eval("Email_Id")%>'></asp:Label>&nbsp;|&nbsp;
                        <asp:Label ID="lblmob" runat="server" Text='<%#Eval("Contact_No")%>'></asp:Label>
                    </td>
                    </tr>
                    
                    <tr>
                    <td>
                        <asp:Label ID="lblcomment" runat="server" Text='<%#Eval("Comment")%>'></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td align="right">
                    <asp:Label ID="lbldate" runat="server" Text='<%#Eval("postdate")%>' ForeColor="Silver"></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td align="right">
                    <asp:LinkButton ID="lnkdetails" runat="server" Text="View Details" ForeColor="Brown" CommandArgument='<%#Eval("dataid")%>' OnCommand="customerdetails"></asp:LinkButton>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    If you solved the problem <asp:LinkButton ID="lnkclick" runat="server" Text="Click Here" CommandArgument='<%#Eval("dataid")%>' OnCommand="click_solved"></asp:LinkButton> &nbsp; To mark it as solved .
                    </td>
                    </tr>
                    <tr><td><hr /></td></tr>
                    </table>
                    </ItemTemplate>
                    </asp:DataList>
                    </td>
                    </tr>
                    <tr>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Previous</asp:LinkButton>
                            </td>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Next</asp:LinkButton>
                            </td>
                        </tr>
                        <tr id="trlblMessage" runat="server">
                            <td align="right" colspan="2">
                                <asp:Label ID="lblCurrentPage" runat="server" Visible="false"></asp:Label>
                            </td>
                        </tr> 
                    </table>
                    </td>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    </table>
                    
    </div>
    </center>
    </form>
</body>
</html>
