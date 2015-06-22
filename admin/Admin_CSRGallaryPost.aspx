<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CSRGallaryPost.aspx.cs" Inherits="admin_Admin_CSRGallaryPost" %>
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
        </style>
      <script language="javascript" type="text/javascript">

          function confirm_delete(uid) {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  document.location = 'Admin_DeleteAd.aspx?cid=' + uid;
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
      <%--  <script type="text/javascript">
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
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td colspan="3">                      
                       <CSR:CSRHead ID="CSRHead2" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px" colspan="3"></td></tr> 
                      <tr>
                            <td colspan="3" align="right">
                                <asp:ScriptManager ID="ScriptManager2" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/Corporate_social.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>    
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">  Social Welfare Information - Upload Gallery</span> 

                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="Label1" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_CorporateSocial.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="Label2" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="3">
                                <br />                               
                            </td>
                        </tr>                          
                        <tr><td height="20px" colspan="3"></td></tr>                                              
                        <tr>
                            <td style="background-color:#F2FAFC" align="center" colspan="3">
                                <table width="100%">                                
                                <tr><td height="5px" colspan="3"></td></tr>
                                <tr>
                                    <td align="center">
                                        <asp:FileUpload ID="ImgUpload" runat="server" />
                                       
                                                 
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                         <asp:RequiredFieldValidator ID="rfvPhoto" runat="server" 
                                            ErrorMessage="Please upload images" ValidationGroup="PostCSRImg" 
                                            ControlToValidate="ImgUpload"></asp:RequiredFieldValidator>
                                            <asp:CustomValidator ID="CVImgUpload" runat="server" 
                                                ErrorMessage="CV" ControlToValidate="ImgUpload" ValidateEmptyText="true" Display="Dynamic" 
                                                onservervalidate="CVImgUpload_ServerValidate" ValidationGroup="PostCSRImg"></asp:CustomValidator>
                                    </td>
                                </tr>
                                <tr><td  align="center"><asp:Label ID="lblImageUploadStatus" runat="server" Visible="false"></asp:Label>
                                </td></tr>
                                <tr><td height="5px" colspan="3"></td></tr>
                                <tr>
                                    <td  align="center">
                                        <asp:ImageButton ID="imgBtnPostCSR" runat="server" 
                                ImageUrl="~/admin/images/post.png"
                                ValidationGroup="PostCSRImg" onclick="imgBtnPostCSR_Click" /> 
                                &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr><td height="20px" colspan="3"></td></tr>
                        <tr><td colspan="3" align="center">
                            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="Large"></asp:Label>
                        </td></tr>
                        <tr>
                            <td width="10%" align="right">
                                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Previous</asp:LinkButton>
                            </td>
                            <td width="80%" align="center">
                           <%-- <div style="overflow-y:hidden;overflow-x:scroll;POSITION:relative;width: 200px;">--%>
                                <asp:DataList ID="dlPhotos" runat="server" RepeatDirection="Horizontal">
                                    <ItemTemplate> 
                                        <table>
                                            <tr>
                                                <td>
                                                <asp:Image ID="ImgPhoto" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("ImgName", "~/CSR_Photos\\{0}") %>' />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                     <%#DataBinder.Eval(Container.DataItem,"ImgName") %>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("Id") %>' OnCommand="DeleteCSRImg">Delete</asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>                                    
                                                                                                                      
                                    </ItemTemplate>                                   
                                </asp:DataList>
                                <%--</div>--%>
                            </td>
                            <td width="10%" align="left">
                                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Next</asp:LinkButton>
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
