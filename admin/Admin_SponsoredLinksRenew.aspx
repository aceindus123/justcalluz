<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SponsoredLinksRenew.aspx.cs" Inherits="admin_Admin_SponsoredLinksRenew" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Renew Sponsored links</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }        
        .style41
        {
            width: 39px;
        }
        </style>
        <script type="text/javascript" src="js/tab.js"></script>
        <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>--%>
</head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
        <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0" width="770px">
              <tr>
                <td class="style39" valign="top" >                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC ">  
                   <table width="750px">      
                    <tr><td colspan="2" align="right"><a href="http://www.justcalluz.com/Home" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                                </td></tr>             
                   <tr>
                   <td align="left">
                       <asp:LinkButton ID="lnkBtnSponsorLinksHome" runat="server" ForeColor="Blue" Font-Bold="true" Font-Size="Medium"
                            onclick="lnkBtnSponsorLinksHome_Click">Home for Sponsored Links</asp:LinkButton>
                   </td>
                    <td align="right" style="height:50px"> 
                        <asp:LinkButton ID="lnkbtnPostsponslinks" runat="server" ForeColor="Blue" Font-Bold="true" Font-Size="Medium"
                            onclick="lnkbtnPostsponslinks_Click">To Post Sponsored Links</asp:LinkButton>
                    </td>
                   </tr>
                   <tr><td colspan="2" align="center" style="height:50px;  font-size:medium;">To Renew the sponsored Links:
                     <div style="float:right; width:50px; padding-right:20px; font-size:10pt; font-family:Verdana ">
                            <a href="Admin_SponsoredLinks.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                   </td></tr>
                    <tr>
                        <td align="center" colspan="2">
                            <table width="100%">
                                <tr>
                                    <td align="right" width="33%">
                                       No. of Days 
                                    </td>
                                    <td class="style41">:</td>
                                    <td align="left">
                                        <asp:TextBox ID="txtDays" runat="server" Width="180"></asp:TextBox>
                                    </td>
                                    
                                </tr>
                                <tr><td></td></tr>
                                <tr>
                                    <td colspan="3" align="center">
                                        <asp:Button ID="btnRenew" runat="server" Text="Renew Sponsored Link" 
                                            onclick="btnRenew_Click" />
                                    </td>
                                </tr>
                                <tr><td></td></tr>
                               
                            </table>
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
