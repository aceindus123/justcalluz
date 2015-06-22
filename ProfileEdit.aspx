<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileEdit.aspx.cs" Inherits="ProfileEdit" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>ProfileEdit | Justcalluz</title>
<meta name='Title' content='Profile Edit | JustCalluz' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
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
      
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div>
<aa1:signin ID="awea" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="uye" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">

<!-- start the inner left-->
<div class="content_innerleft">
<div class="contentbox_top">Update Profile</div>
<div class="contentbox_mid"> <table width="100%" border="0">
  <tr>
    <%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>--%>
   <td width="84%" height="22" class="side_menu">
     <ul><li><%--
    <asp:LinkButton ID="lnkBtnMyProfile" runat="server" Font-Underline="false" OnClick="lnkBtnCancel_Click">My Profile</asp:LinkButton>--%>
    <a id="lnkBtnMyProfile" runat="server" onserverclick="lnkBtnCancel_Click">My Profile</a>
    </li></ul>
    </td>
  </tr>
  <tr>
<%--   <td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>--%>
    <td class="side_menu" height="22">
    <ul><li>
     <%--<asp:LinkButton ID="lnkBtnChangePW" runat="server" Font-Underline="false" onclick="lnkBtnChangePW_Click">Change Password</asp:LinkButton>--%>
     <a id="lnkBtnChangePW" runat="server" onserverclick="lnkBtnChangePW_Click">Change Password</a>
     </li></ul>
    </td>
  </tr>
   <tr>
    <td height="22" colspan="2" style=" padding-left:8px;">&nbsp;</td>
    
  </tr>
</table></div>
<div class="contentbox_bottam"></div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid" style="width:70%"> 
  <div class="searchmid_boxtop1"><a href="<%$RouteUrl:RouteName=HomeRoute %>" style="text-decoration:none;color:White" runat="server">Home</a>&gt;&gt;Update Profile</div>
  <div class="searchmid_boxmid1">
    <table width="100%" border="0">
      <tr id="trHeading" runat="server" class="sub_menu">
        <td colspan="3" align="center">
        &nbsp;
        </td>
      </tr>
      <tr>
        <td colspan="3" align="center">
         <table width="100%" border="0">         
          <tr>                   
           <td colspan="3" align="center">
            <table width="100%" border="0">             
                <tr><td colspan="3">
               <asp:Label ID="lblMessage" runat="server"></asp:Label></td></tr>     
             <tr id="trPerInfo" runat="server">
                <td colspan="3" align="center" class="sub_menu">
                    <asp:Label ID="Label20" runat="server" Text="Personal Information"></asp:Label>
                </td>
             </tr>
             <tr id="trFirstName" runat="server" class="side_menu">
                <td align="right" style="width:150px">First Name</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtFName" runat="server" Width="260px" onkeypress="return Alphabets(event);"></asp:TextBox>                   
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="please enter First Name" ControlToValidate="txtFName" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                </td>
                </tr>
          <tr id="trLastName" runat="server" class="side_menu">
                <td align="right">Last Name</td>
                <td style="width:5px">:</td>
                <td align="left" style="width:300px" >
                    <asp:TextBox ID="txtLName" runat="server" Width="260px" onkeypress="return Alphabets(event);"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ErrorMessage="please enter Last Name" ControlToValidate="txtLName" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>                  
                </td>
            </tr> 
             <tr id="trEmail" runat="server" class="side_menu">
                <td align="right">Email Id</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtEmail" runat="server" Width="260px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="please enter Email ID." ControlToValidate="txtEmail" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Please Enter the Email Address" ControlToValidate="txtEmail" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="UpdateProfile">*</asp:RegularExpressionValidator>                        
                </td>
            </tr>
             <tr id="trAdres" runat="server" class="side_menu">
                <td align="right">Address</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtAddress" runat="server" Width="260px"></asp:TextBox>                    
                </td>
            </tr>
             <tr id="trLmark" runat="server" class="side_menu">
                <td align="right">Land Mark</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtLandMark" runat="server" Width="260px"></asp:TextBox>               
                </td>
            </tr> 
             <tr id="trState" runat="server" class="side_menu">
                <td align="right">State</td>
                <td>:</td>
                <td align="left">
                   <asp:DropDownList ID="ddlState" runat="server" Width="260px" 
                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                           <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                        ControlToValidate="ddlState" ErrorMessage="Plese select State" 
                        InitialValue="Select State" ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>                                       
                </td>
            </tr>
         <tr id="trCity" runat="server" class="side_menu">
                <td align="right">City</td>
                <td>:</td>
                <td align="left">
                   <asp:DropDownList ID="ddlCity" runat="server" Width="260px">
                          </asp:DropDownList>  
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ErrorMessage="Please Select City" ControlToValidate="ddlCity" 
                            InitialValue="Select City" ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>               
                </td>
            </tr>           
             <tr id="trPincode" runat="server" class="side_menu">
                <td align="right">Pincode</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtPinCode" runat="server" Width="260px" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvPinCode" runat="server" 
                ErrorMessage="Please enter PinCode" ControlToValidate="txtPinCode" 
                ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ErrorMessage="Please Enter pincode of 6 digits only" Display="Dynamic" 
                    ControlToValidate="txtPinCode" ValidationExpression="\d{6}" 
                    ValidationGroup="UpdateProfile">*</asp:RegularExpressionValidator> 
                </td>
            </tr>
             <tr id="trMobNo" runat="server" class="side_menu">
                <td align="right">Mobile Number</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtMob" runat="server" Width="260px" MaxLength="11"  onkeypress="return onlyNos(event,this);" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                         ErrorMessage="please enter Mob no." ControlToValidate="txtMob" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>  
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                ErrorMessage="Please enter mobile number of 11 digits" 
                                ControlToValidate="txtMob" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" 
                                ValidationGroup="UpdateProfile">*</asp:RegularExpressionValidator>                     
                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtMob" 
                            MaximumValue="1" ValidationGroup="UpdateProfile">*</asp:RangeValidator>
                        <asp:Label ID="Label12" CssClass="text4" runat="server" Text="Eg: 09847562355" Font-Size="Smaller"></asp:Label>
                </td>
            </tr>
           <tr id="trPhNo" runat="server" class="side_menu">
                <td align="right">Phone Number</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtPhNo" runat="server" Width="260px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" 
                                                ControlToValidate="txtPhNo" ValidationExpression="\d{11}"  ValidationGroup="UpdateProfile" 
                                                ErrorMessage="enter 11 digits number">*</asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="Phone number should start with zero" ControlToValidate="txtPhNo" 
                        ValidationGroup="UpdateProfile">*</asp:RangeValidator> 
                </td>
            </tr>
              <tr id="trFax" runat="server" class="side_menu">
                <td align="right">Fax</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtFax" runat="server" Width="260px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="Fax should start with zero" ControlToValidate="txtFax" 
                        ValidationGroup="UpdateProfile">*</asp:RangeValidator>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                        ErrorMessage="Please enter fax number of 11 digits" 
                        ControlToValidate="txtFax" ValidationExpression="\d{11}" 
                        ValidationGroup="UpdateProfile">*</asp:RegularExpressionValidator> 
                </td>
            </tr>                      
            
            
            <tr id="trHeadBus" runat="server"><td colspan="3" align="center" class="sub_menu"><asp:Label ID="Label21" runat="server" Text="Business Information"></asp:Label></td></tr>            
           <tr id="trbName" runat="server" class="side_menu">
                <td align="right">Business Name</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtBName" runat="server" Width="260px" onkeypress="return Alphabets(event);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="please enter Business Name" ControlToValidate="txtBName" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                    
                </td>
            </tr>
           <tr id="trBusDesc" runat="server" class="side_menu">
                <td align="right">Business Profile</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtBDesc" runat="server" Width="260px"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ErrorMessage="please enter Business Description." ControlToValidate="txtBDesc" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr id="trKOB" runat="server" class="side_menu">
                <td align="right">Kind of Business</td>
                <td>:</td>
                <td align="left">
                    <asp:DropDownList ID="ddlCategory" runat="server" Width="260px">
                          </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="please select Kind of Business" ControlToValidate="ddlCategory" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                </td>
            </tr>                       
          <tr id="trURL" runat="server" class="side_menu">
                <td align="right">WebSite</td>
                <td>:</td>
                <td align="left">
                    <asp:TextBox ID="txtWebSite" runat="server" Width="260px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                            ErrorMessage="Please enter url Eg: http:www.justcalluz.com" 
                            ControlToValidate="txtWebSite" 
                            ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                            ValidationGroup="UpdateProfile">*</asp:RegularExpressionValidator>                    
                </td>
            </tr>
             <tr><td colspan="3" align="center">
              <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ValidationGroup="UpdateProfile" ShowMessageBox="true" ShowSummary="false" /> 
            </td></tr>
            <tr><td colspan="3" align="center">&nbsp;</td></tr>
            <tr>
            <td colspan="3" align="center">
           
                <asp:ImageButton ID="ImgBtnUpdate" runat="server" AlternateText="UpdateButton" 
                    ImageUrl="images/update.png" onclick="ImgBtnUpdate_Click" ValidationGroup="UpdateProfile"/>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;           
                <asp:ImageButton ID="ImgBtnCancel" runat="server" AlternateText="CancelButton" 
                    ImageUrl="images/cancel-button.png" onclick="ImgBtnCancel_Click"/>
            </td>
           </tr>
           </table> 
           </td></tr>
           </table>
        </td>
        
      </tr>
    </table>
  </div>
  <div class="searchmid_boxbottam1"></div>
  </div>

<!-- end of the mid Box-->
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>

<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />

</div>

<div class="footer" align="center">
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
    </form>
</body>
</html>
