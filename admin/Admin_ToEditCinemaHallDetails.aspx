<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToEditCinemaHallDetails.aspx.cs" Inherits="admin_Admin_ToEditCinemaHallDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update Theatre Details</title>
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
        .style40
        {
            height: 16px;
        }
        .style41
        {
            height: 23px;
        }
        .style42
        {
            height: 10px;
        }
        </style>
            
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
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
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px" style="margin-bottom: 0px">
                    <tr>
                    <td>                      
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Update Cinema Hall Details</span> 
                        </td>
                      </tr>                     
                        <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager><asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
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
                            <td height="20px"  colspan="2" align="right" style="padding-right:8px;">
                            <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_ViewHallsData.aspx"></asp:LinkButton>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                            <asp:TextBox ID="txtHallName" runat="server" onkeypress="return Alphabets(event);"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvHallName" runat="server" 
                                ControlToValidate="txtHallName" 
                                ErrorMessage="Please enter Name of the Cinema Hall" 
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="regpincode" runat="server" ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" 
                                ControlToValidate="txtPincode" ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" ValidationGroup="UpdateHallDetails"></asp:RegularExpressionValidator>
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
                            <asp:TextBox ID="txtMob" runat="server" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                                ControlToValidate="txtMob" ErrorMessage="Please enter Mobile number" 
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtMob" ErrorMessage="Please enter Mobile number" 
                                ValidationGroup="UpdateHallDetails">*</asp:RequiredFieldValidator>
                               <%-- <asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtMob" 
                            MaximumValue="1" ValidationGroup="UpdateHallDetails">*</asp:RangeValidator>--%>
                             <asp:RegularExpressionValidator ID="RegMob" runat="server" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtMob" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="UpdateHallDetails"></asp:RegularExpressionValidator>
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
                            <asp:TextBox ID="txtPhone" runat="server" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox> 
                             <asp:RangeValidator ID="rvPh" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtPhone" 
                            MaximumValue="1" ValidationGroup="UpdateHallDetails">*</asp:RangeValidator>
                           
                          <asp:RegularExpressionValidator ID="revPh" runat="server" 
                              ErrorMessage="Enter Phone number only ten digits(starting number should starts from 1 to 9 digits)" Display="Dynamic" ControlToValidate="txtPhone" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ValidationGroup="UpdateHallDetails"></asp:RegularExpressionValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RegularExpressionValidator>
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
                                ValidationGroup="UpdateHallDetails">*</asp:RegularExpressionValidator>
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
                        <td colspan="3" class="style42">                        
                        </td>
                     </tr>
                      <tr>            
                        <td align="center" colspan="3" class="style40">
                            <asp:ImageButton ID="imgbtnUpdate" runat="server" 
                                ImageUrl="~/admin/images/Update.png" onclick="imgbtnUpdate_Click" 
                                ValidationGroup="UpdateHallDetails" /> 
                                &nbsp; &nbsp;
                                <asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>
                        </td>
                      </tr>
                      <tr id="trMAP" runat="server">
                        <td colspan="3" class="style41">
                  
                        </td>
                      </tr>
                      <tr>
                        <td colspan="3" class="adminform" align="center">
                            <span style="font-weight:bold"> Please go through the Procedure to get Map URL</span>  
                        </td>
                      </tr>
                      <tr>
                        <td class="adminform" colspan="3">Step1:&nbsp;                       
                        Please Click on &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="http://maps.google.co.in/maps?hl=en&tab=wl">Get Map URL</asp:HyperLink>
                        </td>
                      </tr>
                      <tr>
                        <td colspan="3" class="adminform">
                            Step2: &nbsp;Please select image named Link then you will get a new box.
                        </td>
                      </tr>
                      <tr>
                        <td colspan="3"  class="adminform">
                            Step3:There is an option "Paste HTML to embed in website". Cpoy the url into "Map URL" field which is present below
                        </td>
                      </tr>
                      <tr>
                        <td height="10px" colspan="3"></td>
                      </tr>
                      <tr>                                      
                        <td align="right" class="adminform">
                            Map URL
                        </td>
                        <td align="center">
                            :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtMapURL" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvMapURL" runat="server" 
                                ControlToValidate="txtMapURL" ErrorMessage="Please enter Map URL" 
                                ValidationGroup="SaveHallmap">*</asp:RequiredFieldValidator>
                        </td>
                     </tr> 
                      <tr>
                        <td colspan="3" class="style41">
                            <asp:Label ID="lblSmallExceptLarge" runat="server" Visible="false"></asp:Label>
                        </td>
                      </tr>
                     <tr>            
                        <td align="center" colspan="3" class="style40">
                            <asp:ImageButton ID="imgbtnSave" runat="server" 
                                ImageUrl="~/admin/images/save.png" onclick="imgbtnSave_Click" 
                                ValidationGroup="SaveHallmap" /> 
                             <asp:ImageButton ID="imgbtnmapUpdate" runat="server" 
                                ImageUrl="~/admin/images/update.png" onclick="imgbtnSave_Click" 
                                ValidationGroup="SaveHallmap" /> 
                                &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>  
                        </td>
                      </tr>        
                 </table>                                                               
                </td>
            </tr> 
            <tr>
                <td height="20px">                    
                </td>
            </tr>           
            <tr>
                <td height="300px">
                    <asp:Label ID="lblMap" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <div id="divMap" runat="server">
                    
                    </div>
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
