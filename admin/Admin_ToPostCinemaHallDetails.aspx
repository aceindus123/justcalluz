<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToPostCinemaHallDetails.aspx.cs" Inherits="admin_Admin_ToPostCinemaHallDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Post Theatre details</title>
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
        <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>   
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Post Cinema Hall Details</span> 
                        </td>
                      </tr>                     
                                                                  
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_Movies.aspx" style="text-decoration:underline;">Back</a>                             
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
                <td colspan="2"> 
                 <table width="100%">
                     <tr>
                        <td align="right" class="adminform">
                          Category  
                        </td>
                        <td align="center">:</td>
                        <td align="left">
                            <asp:DropDownList ID="ddlCat" runat="server">
                                <asp:ListItem>Cinema Halls</asp:ListItem>
                                <asp:ListItem>Multiplex Cinema Halls</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                ErrorMessage="Please select category" ControlToValidate="ddlCat" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>                        
                     </tr>                    
                     <tr>
                        <td align="right" class="adminform">
                           Cinema Hall Name 
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtHallName" runat="server" onkeypress="return Alphabets(event);" ></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvHallName" runat="server" 
                                ControlToValidate="txtHallName" 
                                ErrorMessage="Please enter Name of the Cinema Hall" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                     <tr>
                        <td align="right" class="adminform">
                           Address
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                                ControlToValidate="txtAddress" ErrorMessage="Please enter address" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                     <tr>
                        <td align="right" class="adminform">
                          Landmark
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtLandMark" runat="server"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvLandMark" runat="server" 
                                ControlToValidate="txtLandMark" ErrorMessage="Please enter Landmark" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                      
                      <tr>
                        <td align="right" class="adminform">
                          State
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlState" runat="server" 
                                onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList> 
                            <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                                ControlToValidate="ddlState" ErrorMessage="Please select state" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          City
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlCity" runat="server" 
                                onselectedindexchanged="ddlCity_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                ControlToValidate="ddlCity" ErrorMessage="Please select city" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                     <tr>
                        <td align="right" class="adminform">
                          Area
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlArea" runat="server">
                            </asp:DropDownList> 
                            <asp:RequiredFieldValidator ID="rfvArea" runat="server" 
                                ControlToValidate="ddlArea" ErrorMessage="Please Select Area" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          Pincode
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtPincode" runat="server" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvPincode" runat="server" 
                                ControlToValidate="txtPincode" ErrorMessage="Please enter Pincode" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regpincode" runat="server" ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" ValidationGroup="PostHallDetails" ControlToValidate="txtPincode"></asp:RegularExpressionValidator>
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          Mobile Number
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                        <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
                            <asp:TextBox ID="txtMob" runat="server"  MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                                ControlToValidate="txtMob" ErrorMessage="Please enter Mobile number" 
                                ValidationGroup="PostHallDetails">*</asp:RequiredFieldValidator>
                                <%--<asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtMob" 
                            MaximumValue="1" ValidationGroup="PostHallDetails">*</asp:RangeValidator>
                           --%>
                          <asp:RegularExpressionValidator ID="revMob" runat="server" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtMob" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="PostHallDetails"></asp:RegularExpressionValidator>
                               
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          Phone Number
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtPhone" runat="server" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox> 
                             <asp:RangeValidator ID="rvPh" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtPhone" 
                            MaximumValue="1" ValidationGroup="PostHallDetails">*</asp:RangeValidator>
                           
                          <asp:RegularExpressionValidator ID="revPh" runat="server" 
                              ErrorMessage="Enter Phone number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtPhone" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="PostHallDetails"></asp:RegularExpressionValidator>
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          Email
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> 
                            
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                                ControlToValidate="txtEmail" ErrorMessage="Please enter valid email id" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ValidationGroup="PostHallDetails">*</asp:RegularExpressionValidator>
                            
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                          Website
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtWebsite" runat="server"></asp:TextBox> 
                            <asp:RegularExpressionValidator ID="revweb" runat="server" 
                                ControlToValidate="txtWebsite" ErrorMessage="Please enter valid URL" 
                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                                ValidationGroup="PostHallDetails">*</asp:RegularExpressionValidator>
                        </td>
                     </tr>
                     <tr>
                        <td align="right" class="adminform">
                          Upload logo (optional)
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                           <asp:FileUpload ID="Imgupload" runat="server" />
                        </td>
                     </tr>
                     <tr>
                        <td height="10px" colspan="3">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                ShowMessageBox="True" ShowSummary="False" ValidationGroup="PostHallDetails" />                        
                        </td>
                     </tr>
                      <tr>            
                        <td align="center" colspan="3">
                            <asp:ImageButton ID="imgbtnPost" runat="server" 
                                ImageUrl="~/admin/images/post.png" onclick="imgbtnPost_Click" 
                                ValidationGroup="PostHallDetails" /> 
                        </td>
                      </tr>   
                 </table>           
                                                    
                </td>
            </tr>            
            <tr><td>
          
        </td></tr>
           
                                                    
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
