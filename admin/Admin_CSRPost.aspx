<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CSRPost.aspx.cs" Inherits="admin_Admin_CSRPost" %>
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
    <script type="text/javascript">
        function Alphabets(nkey) {
            var keyval
            if (navigator.appName == "Microsoft Internet Explorer") {
                keyval = window.event.keyCode;
            }
            else if (navigator.appName == 'Netscape') {
                nkeycode = nkey.which;
                keyval = nkeycode;
            }
            //For A-Z
            if (keyval >= 65 && keyval <= 90) {
                return true;
            }
            //For a-z
            else if (keyval >= 97 && keyval <= 122) {
                return true;
            }
            //For Backspace
            else if (keyval == 8) {
                return true;
            }
            //For General
            else if (keyval == 0) {
                return true;
            }
            //For Space
            else if (keyval == 32) {
                return true;
            }
            else {
                return false;
            }
        } // End of the function
  
 </script>	
        <script type="text/javascript" src="js/tab.js"></script>
     <%--   <script type="text/javascript">
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
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">  Social Welfare Information - Post</span> 
                        </td>
                      </tr>                     
                                                               
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_CorporateSocial.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>
                        </tr>                          
                       <%-- <tr><td height="20px"></td></tr>  
                        <tr>
                            <td align="center">                                
                            </td>
                            
                        </tr>   --%>
                        <tr><td height="20px"></td></tr>                                          
                        <tr>
                            <td style="background-color:#F2FAFC" align="center">
                                <table width="100%">
                                    <tr>
                                        <td align="center">
                                            Post Data regarding   Social Welfare Information
                                        </td>
                                    </tr>  
                                    <tr><td height="5px"></td></tr>
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtIntroduction" runat="server" Width="500px" Height="50px" TextMode="MultiLine"></asp:TextBox>
                                           <AjaxToolkit:TextBoxWatermarkExtender ID="tweInt" runat="server" TargetControlID="txtIntroduction" WatermarkCssClass="water" WatermarkText="Please Enter Introduction"></AjaxToolkit:TextBoxWatermarkExtender> 
                                        </td>
                                    </tr> 
                                    <tr><td height="5px"></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtTitle" runat="server" Width="500px" onkeypress="return Alphabets(event);"></asp:TextBox>
                                           <AjaxToolkit:TextBoxWatermarkExtender ID="weTitle" runat="server" TargetControlID="txtTitle" WatermarkCssClass="water" WatermarkText="Please Enter Title"></AjaxToolkit:TextBoxWatermarkExtender> 
                                           
                                        </td>
                                    </tr> 
                                    <tr><td height="5px"> <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                                ErrorMessage="Please enter title" ControlToValidate="txtTitle" 
                                                ValidationGroup="PostCSRData"></asp:RequiredFieldValidator></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtData1" runat="server" TextMode="MultiLine" Width="500px" 
                                                Height="50px"></asp:TextBox>
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtData1" runat="server" TargetControlID="txtData1" WatermarkCssClass="water" WatermarkText="Please Enter 1st Paragraph"></AjaxToolkit:TextBoxWatermarkExtender> 
                                           
                                        </td>
                                    </tr> 
                                    <tr><td height="5px"> <asp:RequiredFieldValidator ID="rfvPara1" runat="server" 
                                                ErrorMessage="Please enter Data" ControlToValidate="txtData1" 
                                                ValidationGroup="PostCSRData"></asp:RequiredFieldValidator></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtData2" runat="server" TextMode="MultiLine" Width="500px" 
                                                Height="50px"></asp:TextBox>
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtData2" runat="server" TargetControlID="txtData2" WatermarkCssClass="water" WatermarkText="Please Enter 2nd Paragraph"></AjaxToolkit:TextBoxWatermarkExtender> 
                                        </td>
                                    </tr>  
                                    <tr><td height="5px"></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtData3" runat="server" TextMode="MultiLine" Width="500px" 
                                                Height="50px"></asp:TextBox>
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtData3" runat="server" TargetControlID="txtData3" WatermarkCssClass="water" WatermarkText="Please Enter 3rd Paragraph"></AjaxToolkit:TextBoxWatermarkExtender> 
                                        </td>
                                    </tr>  
                                    <tr><td height="5px"></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtData4" runat="server" TextMode="MultiLine" Width="500px" 
                                                Height="50px"></asp:TextBox>
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtData4" runat="server" TargetControlID="txtData4" WatermarkCssClass="water" WatermarkText="Please Enter 4th Paragraph"></AjaxToolkit:TextBoxWatermarkExtender> 
                                        </td>
                                    </tr>  
                                    <tr><td height="5px"></td></tr>   
                                    <tr>
                                        <td align="center">
                                            <asp:TextBox ID="txtData5" runat="server" TextMode="MultiLine" Width="500px" 
                                                Height="50px"></asp:TextBox>
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtData5" runat="server" TargetControlID="txtData5" WatermarkCssClass="water" WatermarkText="Please Enter 5th Paragraph"></AjaxToolkit:TextBoxWatermarkExtender> 
                                        </td>
                                    </tr>  
                                    <tr><td height="5px"></td></tr> 
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="imgBtnPostCSR" runat="server" 
                                    ImageUrl="~/admin/images/post.png"
                                    ValidationGroup="PostCSRData" onclick="imgBtnPostCSR_Click" />
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
