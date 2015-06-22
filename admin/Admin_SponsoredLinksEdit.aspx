<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SponsoredLinksEdit.aspx.cs" Inherits="admin_Admin_SponsoredLinksEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Update Sponsored links</title>

    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />    
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }        
        .style40
        {
            height: 22px;
        }
        </style>
        <script type="text/javascript" src="js/tab.js"></script>
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
 <script type="text/javascript">
     function onlyNos(e, t) {
         try {
             if (window.event) {
                 var charCode = window.event.keyCode;
             }
             else if (e) {
                 var charCode = e.which;
             }
             else { return true; }
             if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                 return false;
             }
             return true;
         }
         catch (err) {
             alert(err.Description);
         }
     }
        </script>
      <%--  <script type="text/javascript">
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
            <table cellpadding="0" cellspacing="0" width="745px">
              <tr>
                <td class="style39" valign="top" style="padding-top:10px; background-color:#F2FAFC">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC" align="center">  
                    <table width="745px">
                   <tr>
                        <td>
                            
                        </td>
                   </tr>
                    <tr><td colspan="3" align="right">
                     <a href="http://www.justcalluz.com/Home" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/></a>
                    <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                    </td></tr>
                    <tr>
                        <td align="center" colspan="3" style="height:100px; color:#0404B4; font-size:medium; font-family:Algerian">
                           Update Sponsored Links :
                             <div style="float:right; width:50px; padding-right:20px; font-family:Verdana ">
                            <a href="Admin_SponsoredLinks.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                        </td>
                    </tr>
                   <tr>
                        <td align="right" class="style42" width="35%">Sponser Name</td>
                        <td align="center">:</td>
                        <td>
                            <asp:TextBox ID="txtSponLink" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvSponLink" runat="server" 
                            ControlToValidate="txtSponLink" ErrorMessage="Please Enter Name" 
                            ValidationGroup="PostLink">*</asp:RequiredFieldValidator>
                        </td>
                   </tr>
                     <tr>
                        <td align="right" class="style42">Company Name</td>
                        <td align="center">:</td>
                        <td>
                            <asp:TextBox ID="txtspcmp" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtSponLink" ErrorMessage="Please enter the company name" 
                            ValidationGroup="PostLink">*</asp:RequiredFieldValidator>
                        </td>
                   </tr>
                   <tr>
                        <td align="right" class="style43">Contact Number</td>
                        <td align="center" class="style44">:</td>
                        <td class="style44"><asp:TextBox ID="txtno" runat="server" Width="200px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtno" ErrorMessage="Please enter Contact Number" 
                            ValidationGroup="PostLink">*</asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="regcn" runat="server" ErrorMessage="Enter Contact number only ten digits(starting number should starts from 1 to 9 digits)" 
                              ControlToValidate="txtno" ValidationGroup="PostLink" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"></asp:RegularExpressionValidator></td>
                   </tr>
                   
                   <tr>
                   <td align="right">
                   Module
                   </td>
                   <td align="center">
                   :
                   </td>
                   <td>
                   <asp:DropDownList ID="ddlmod" runat="server" Width="200px" AutoPostBack="true" 
                           onselectedindexchanged="ddlmod_SelectedIndexChanged">
                   <asp:ListItem>Select</asp:ListItem>
                   <asp:ListItem>Category</asp:ListItem>
                   <asp:ListItem>B2B Category</asp:ListItem>
                   <asp:ListItem>Jobs</asp:ListItem>
                   <asp:ListItem>Events</asp:ListItem>
                   <asp:ListItem>Discounts</asp:ListItem>
                   <asp:ListItem>LifeStyle</asp:ListItem>
                   <asp:ListItem>Movies</asp:ListItem>
                   </asp:DropDownList>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="ddlmod" ErrorMessage="Please select the module" 
                            ValidationGroup="PostLink" InitialValue="Select">*</asp:RequiredFieldValidator></td>
                   </tr>
                   <tr>
                   <td align="right">
                   Category
                   </td>
                   <td align="center">
                   :
                   </td>
                   <td>
                   <asp:DropDownList ID="ddlcat" runat="server" Width="200px" AutoPostBack="false">
                   <asp:ListItem>Select Category</asp:ListItem>
                   </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlcat" ErrorMessage="Please select the category" 
                            ValidationGroup="PostLink" InitialValue="Select Category">*</asp:RequiredFieldValidator>
                   </td>
                   </tr>
                   <tr>
                   <td align="right" class="style42">Type of Ad</td>
                   <td align="center">:</td>
                   <td>
                   <asp:DropDownList ID="ddladtype" runat="server" Width="200px" AutoPostBack="true" 
                           onselectedindexchanged="ddladtype_SelectedIndexChanged">
                   <asp:ListItem>Select</asp:ListItem>
                   <asp:ListItem>Linked ads</asp:ListItem>
                   <asp:ListItem>Banner ads</asp:ListItem>
                   </asp:DropDownList>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="ddladtype" ErrorMessage="Please select the type of ad" 
                            ValidationGroup="PostLink" InitialValue="Select">*</asp:RequiredFieldValidator>
                   </td>
                   </tr>
                   <tr id="trbanner" runat="server">
                   <td align="right" class="style42">
                   Upload Banner
                   </td>
                   <td align="center">:</td>
                   <td><asp:FileUpload ID="bnr" runat="server" Height="26px" Width="200px"/>
                   <%--<asp:LinkButton ID="lnkchange" runat="server" Text="change banner" 
                           onclick="lnkchange_Click"></asp:LinkButton>--%>
                   </td>
                   </tr>
                    <tr>
                        <td align="right" class="style42">Address</td>
                        <td align="center">:</td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="200px" 
                                Height="70px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvAddress" runat="server"
                             ControlToValidate="txtAddress" ErrorMessage="Please enter Address"
                              ValidationGroup="PostLink" >*</asp:RequiredFieldValidator>
                        </td>                       
                    </tr>
                    <tr>
                        <td align="right" class="style42">WebSite</td>
                        <td align="center">:</td>
                        <td>
                            <asp:TextBox ID="txtWebsite" runat="server" Width="200px"></asp:TextBox>(ex: http://www.justcalluz.com)
                            <asp:RequiredFieldValidator ID="rfvWebsite" runat="server"
                              ControlToValidate="txtWebsite" ErrorMessage="Please Enter WebSite">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revWebsite" runat="server" 
                            ControlToValidate="txtWebsite" ErrorMessage="Please enter valid website" 
                            ValidationGroup="PostLink" 
                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center" style="height:50px">
                            <asp:Button ID="btnUpdateSponLinks" runat="server"
                             Text="Update Sponsored Link" OnClick="btnUpdateSponLinks_Click" ValidationGroup="UpdateLink"/>
                             &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelUpdate" runat="server" Text="Cancel Update" OnClick="btnCancelUpdate_Click" />
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
