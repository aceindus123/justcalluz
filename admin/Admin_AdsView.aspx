<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_AdsView.aspx.cs" Inherits="admin_Admin_AdsView" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Careers</title>
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
    testwindow = window.open("http://www.justcalluz.com/tv_ads.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                <td valign="top" style="padding:10px; padding-left:10px" class="style37">  
                    <table width="750px">
                    <tr>
                    <td>                      
                       <%--<Careers:CareersHeader ID="Careers" runat="server" />--%>
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Ads Home</span> 
                        </td>
                      </tr>                     
                        <tr>
                            <td colspan="2">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/><br />                               
                            </td>
                        </tr>                        
                        <tr>
                            <td>
                                <table width="100%">
                                    <tr>
                                        <td>
                                            
                                        </td>
                                    </tr>                                    
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
    </form>
</body>
</html>
