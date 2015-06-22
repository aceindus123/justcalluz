<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ViewReports.aspx.cs" Inherits="admin_Admin_ViewReports" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - View Reports</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              <script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeleteData.aspx?cid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected Classified has been deleted Successfully");
}
function alertaccept()
{
alert("Selected Classified has been Accepted");
}
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <div>
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
                <td valign="top" style=" padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                        <td>
                            <dataHead:dataHeader ID="datahead1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>                            
                        </td>
                    </tr>
                     <tr>
                        <td height="10px" align="right">
                            <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
                        </td>
                    </tr>
                      <tr>
                        <td align="center">
                            <asp:Label ID="lblHeading" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                      <tr>
                        <td height="10px">
                            
                        </td>
                    </tr>
                    <tr><td>
                                <asp:DataList ID="dlReport" DataKeyField="id" runat="server" Width="100%"
                                    style="margin-left: 0px" onitemdatabound="dlReport_ItemDataBound" AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB">
                                      <HeaderTemplate>                                      
                                    </HeaderTemplate>
                                      <ItemTemplate>
                                      <table width="100%" style="padding-left:10px" valign="top" border="0">
                                        <tr id="trName" runat="server">
                                            <td colspan="2">
                                                Name: &nbsp;<asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>                                         
                                            </td>                                                                                      
                                        </tr>
                                        <tr id="trEmailId" runat="server">
                                            <td  colspan="2">
                                                EmailId:&nbsp;<asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email_Id") %>'></asp:Label>                                         
                                            </td>
                                        </tr>
                                        <tr id="trContNo" runat="server">
                                            <td colspan="2">
                                                Contact Number :&nbsp;<asp:Label ID="lblContNo" runat="server" Text='<%#Eval("Contact_No") %>'></asp:Label>                                         
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width:95%">
                                                Report :&nbsp;<asp:Label ID="Label3" runat="server" Text='<%#Eval("Comment") %>'></asp:Label>                                         
                                            </td>  
                                            <td align="center" style="width:5%">
                                                <asp:LinkButton ID="lnlBtnDelete" runat="server" OnCommand="lnkDeleteReport" CommandArgument='<%#Eval("id") %>'>
                                                <img src='images/delete.gif' width='16' height='16' border='0'/>
                                                </asp:LinkButton>
                                                
                                            </td>                                           
                                        </tr>   
                                        <tr style="background-color:White"><td height="2px" colspan="2"></td></tr>                                     
                                        </table>
                                    </ItemTemplate>
                                     <FooterTemplate>                                     
                                    </FooterTemplate>
                                </asp:DataList>
                       </td>
                       </tr>
                        <tr id="trnextpre" runat="server">
          <td align="center">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr id="trlblMessage" runat="server">
            <td align="right">
                <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
            </td>
        </tr>
         <tr id="trlblMsg" runat="server">
            <td align="center">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
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
    </form>
</body>
</html>
