<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_MediaEdit.aspx.cs" Inherits="admin_Admin_MediaEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MediaHeader.ascx" TagName="MediaHeader" TagPrefix="Media" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Meadia Speak Update</title>
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
        <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/media.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>--%>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
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
                      <Media:MediaHeader id="media1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                     <tr>
                            <td colspan="2" align="right">
                               
                                 <a  target="_blank" href="http://www.justcalluz.com/media.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>   
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">To Update Media Speak <%--which is titled as--%></span> 
                        </td>
                      </tr>                     
                                                                  
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_Media.aspx" style="text-decoration:underline;">Back</a>                             
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
                        <tr>
                            <td>
                                <table width="100%">
                                    <tr>
                                        <td>
                                            <table width="100%">
                                                <tr class="adminform">
                                                    <td width="40%" align="right">
                                                        <asp:Label ID="Label1" runat="server" Text="Language of Media Speak" AssociatedControlID="ddlLang"></asp:Label>  
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlLang" runat="server" Width="200px" AutoPostBack="true" 
                                                            onselectedindexchanged="ddlLang_SelectedIndexChanged">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvddlLang" runat="server" 
                                                            ControlToValidate="ddlLang" ErrorMessage="Please select Language" 
                                                            InitialValue="Select Language" ValidationGroup="UpdateMediaSpeak"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform">
                                                    <td width="40%" align="right">
                                                       <asp:Label ID="Label2" runat="server" Text="Name of the Media" AssociatedControlID="ddlMediaName"></asp:Label>                                                       
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlMediaName" runat="server" Width="200px" 
                                                            AutoPostBack="true" onselectedindexchanged="ddlMediaName_SelectedIndexChanged">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvMediaName" runat="server" 
                                                            ControlToValidate="ddlMediaName" 
                                                            ErrorMessage="Select Name of the Media" InitialValue="Select Media Name" 
                                                            ValidationGroup="UpdateMediaSpeak"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trOtherCat" runat="server" visible="false">
                                                    <td colspan="2">                                                        
                                                    </td>                                                    
                                                    <td align="left" width="50%">
                                                        <asp:TextBox ID="txtOtherMedia" runat="server" Width="200px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform">
                                                    <td width="40%" align="right">                                                        
                                                        <asp:Label ID="Label3" runat="server" Text="Article Title" AssociatedControlID="txtTitle"></asp:Label>  
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:TextBox ID="txtTitle" runat="server" Width="200px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                                            ErrorMessage="Please Enter Title of the article" 
                                                            ControlToValidate="txtTitle" ValidationGroup="UpdateMediaSpeak"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform">
                                                    <td width="40%" align="right">
                                                        <asp:Label ID="Label4" runat="server" Text="Image Upload" AssociatedControlID="MediaImageUpload"></asp:Label>
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:FileUpload ID="MediaImageUpload" runat="server" />                                                       
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="2px"></td></tr>
                                                <tr>
                                                 <td colspan="3" height="2px" align="center">
                                                    <asp:Image ID="imgMediaSpeak" runat="server"/>
                                                 </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" height="2px">
                                                        <asp:Label ID="lblImgContent" runat="server" Visible="false"></asp:Label>
                                                        <asp:Label ID="lblImgContentType" runat="server" Visible="false"></asp:Label>
                                                    </td>
                                               </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="imgBtnUpdateMediaSpeak" runat="server" 
                                                ImageUrl="~/admin/images/update.png" onclick="imgBtnUpdateMediaSpeak_Click" 
                                                ValidationGroup="UpdateMediaSpeak" />
                                                 &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>
                                                
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
