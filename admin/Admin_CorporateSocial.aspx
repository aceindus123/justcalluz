<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CorporateSocial.aspx.cs" Inherits="admin_Admin_CorporateSocial" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CSRHead.ascx" TagName="CSRHead" TagPrefix="CSR" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Ads Home</title>
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
        </style>
    <style type="text/css">
        .style39
        {
            width: 100px;
        }  
        .stylealign
        {
           align:center
        }        
        .style40
        {
            height: 23px;
        }
        </style>
      <script language="javascript" type="text/javascript">

          function confirm_delete() {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  return true;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected Ad has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected Ad has been Accepted");
          }
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>
  <%--      <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Corporate_social.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td>                      
                       <CSR:CSRHead ID="CSRHead1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <a  target="_blank" href=" http://www.justcalluz.com/Corporate_social.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                               
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>     
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">  Social Welfare Information</span> 
                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td >
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                           
                              <div style="float:right; width:50px; padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>                            
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td class="style40">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2" class="style40">
                                <br />                               
                            </td>
                        </tr>                          
                        <tr><td height="20px"></td></tr>                                              
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                        <td>
                                            <asp:DataList ID="dlCSR" runat="server" Width="100%" 
                                                onitemdatabound="dlCSR_ItemDataBound">
                                                <ItemTemplate>
                                                    <table width="100%" style="border-color:#B50808;" border="1">
                                                        <tr>
                                                            <td>
                                                               <table width="100%">
                                                                    <tr height="30px" style="border-width:0px">
                                                                        <td align="center" valign="middle" width="85%">
                                                                       <span style="color:Blue"><strong><%#DataBinder.Eval(Container.DataItem,"Title") %></strong></span>
                                                                        </td> 
                                                                        <td align="center">
                                                                        <a href="Admin_CSREdit.aspx?csrid=<%# DataBinder.Eval(Container, "DataItem.csrId")%>">
                                                                            <img src='images/edit.gif' width='16' height='16' border='0' id="imgedit" runat="server" />                                                                                                   
                                                                        </a>
                                                                        &nbsp;&nbsp;
                                                                            <asp:ImageButton ID="imgbtnDelete" runat="server" ImageUrl="~/admin/images/delete.gif" OnClientClick="return confirm_delete();" OnCommand="lnBtnDeleteCSR" CommandArgument='<%#Eval("csrId") %>' />                                                                
                                                                            
                                                                        </td>                                                           
                                                                    </tr>
                                                                    <tr><td height="5px" colspan="2"></td></tr>
                                                                    <tr>
                                                                        <td align="left" colspan="2" style="padding-left:10px" valign="top">
                                                                          <span style="color:DarkSlateGray"> 
                                                                           <%#DataBinder.Eval(Container.DataItem,"para1") %>
                                                                         </span>
                                                                        </td>                                                                                                                       
                                                                    </tr>
                                                                     <tr><td height="5px" colspan="2"></td></tr>
                                                                    <tr style="background-color:Ivory; color:DeepSkyBlue; height:25px">
                                                                        <td align="left" style="padding-left:20px">
                                                                            <a href="Admin_CSRGallaryPost.aspx?csrid=<%# DataBinder.Eval(Container, "DataItem.csrId")%>" target="_blank" style="text-decoration:none">Click here to delete or upload Photos</a>
                                                                        </td> 
                                                                        <td align="right" style="padding-right:20px">
                                                                            <a href="Admin_CSRView.aspx?csrid=<%# DataBinder.Eval(Container, "DataItem.csrId")%>" target="_blank" style="text-decoration:none">View Details</a>
                                                                        </td>                                                           
                                                                    </tr>                                                        
                                                                </table>                                                                 
                                                            </td>
                                                        </tr>
                                                    </table>
                                                   
                                                </ItemTemplate>
                                            </asp:DataList>
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
    </center>
    </form>
</body>
</html>
