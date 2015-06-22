<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit_LifeStyle.aspx.cs" Inherits="edit_LifeStyle" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Sp_Links" TagPrefix="spLinks_Right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Edit LifeStyle</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<style type="text/css">
<!--
.style9 {
        width: 20%;
        height: 10px;
    }
.style9 {        height: 10px;
        width: 372px;
}
    .style10
    {
        width: 20%;
    }
-->
</style>
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
<div class="signin">
<sig:signin ID="sig1" runat="server" />
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
<!-- start the mid Box-->
  <div class="content" style="padding:0; margin:0;">
<div style="width:100%" class="content_innerleft">
  <div class="contentmid_boxmid" style="width:77.5%; padding:none; background:none; border:dotted 1px #666">
  <table width="100%" border="0" bgcolor="#ECF9FF"> 
  <tr>
          <td height="35" colspan="3" style="background:url(images/search_midtop.png) no-repeat"><table width="100%" border="0">
<tr>
    <td class="location"  height="35" style="padding-left:15px; background:url(images/search_midtop.png) no-repeat "><font color="white">
        Welcome to Just Call Uz :: LifeStyle</font></td>
  </tr>
</table>
</td>
          </tr>
  <tr>
    <td valign="top"> 
     <div class="events">
       <table width="100%" border="0">
              <tr>
                <td height="25" align="left" style="padding-left:10px;"><label style="color:#000" ><span class="sub_menu"><b>
                    Post The Lifestyle </b></span></label>
                  <span class="sub_menu"></span></td>
              </tr>
              <tr>
                <td width="100%"><hr/><hr/></td>
                </tr>
              <tr>
                <td height="30" align="center" valign="top">
                 <table width="100%" border="0">
                  <tr><td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Category </span></td>
  <td align="center"><strong>:</strong></td>
      
  <td height="30" align="left"><span class="row"><asp:DropDownList ID="ddlcat" runat="server" Height="21px" 
          Width="203px" AutoPostBack="true" OnSelectedIndexChanged="ddlcat_selectedindexchanged"></asp:DropDownList>
       <%--<asp:RequiredFieldValidator ID="Reqcat" runat="server"  ControlToValidate="ddlcat" InitialValue="select" ErrorMessage="Please select category"  ValidationGroup="postevent"></asp:RequiredFieldValidator>--%>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Please select Category" ControlToValidate="ddlcat" 
          InitialValue="select" ValidationGroup="postevent">*</asp:RequiredFieldValidator>
          </span>
      </td>
 
  </tr>
  <tr><td class="style9"></td></tr>
  <tr><td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">SubCategory</span> </td>
<td align="center"><strong>:</strong></td>
  <td height="30" align="left"><span class="row"><asp:DropDownList ID="ddlsubcat" runat="server" 
          AutoPostBack="true" Height="21px"  
          Width="203px" ValidationGroup="postevent" Enabled="false"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqsubcat" runat="server" ControlToValidate="ddlsubcat" 
          ErrorMessage="Please select SubCategory" ValidationGroup="postevent" 
          InitialValue="select">*</asp:RequiredFieldValidator>
          </span>
      </td>
      
  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">State</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlstate" 
          runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" OnSelectedIndexChanged="ddlstate_selectedindexchanged" 
          ></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqstate" runat="server" 
          ErrorMessage="Please select state" ControlToValidate="ddlstate"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
                   </span></td>
                    </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">&nbsp;city</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" ValidationGroup="events"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqcity" runat="server" 
          ErrorMessage="Please select city" ControlToValidate="ddlcity"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
                       </span></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Area</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtarea" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events" ></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqara" runat="server" 
          ErrorMessage="please enter area" ControlToValidate="txtarea"  
          ValidationGroup="postevent">*</asp:RequiredFieldValidator> </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Company 
                        Name</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtevename" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events" ></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqcmpnme" runat="server" 
          ErrorMessage="please specify the event name" ControlToValidate="txtevename"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                            
                  
                 
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Address</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtadd" runat="server" Height="20px" 
          Width="203px" TextMode="MultiLine" ValidationGroup="events"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
          ErrorMessage="Enter the address" ControlToValidate="txtadd"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star"></span>&nbsp;<span class="list">LandMark</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtlndm" runat="server" Height="20px" Width="203px"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Pincode</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtpin" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="6"></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
          ErrorMessage="Please enter pincode" ControlToValidate="txtpin" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator>
        
                      </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">&nbsp;Contact 
                        Person</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtcntp" runat="server" Height="20px" Width="203px"></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
          ControlToValidate="txtcntp" ErrorMessage="Please name of the contact person" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Email</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtemail" runat="server" Height="20px" 
          Width="203px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="txtemail" ErrorMessage="please enter the email address" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ErrorMessage="Incorrect Format" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="postevent" ControlToValidate="txtemail" >*</asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star"></span>&nbsp;<span class="list">LandLine</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtph" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="11">
  
  </asp:TextBox>
  <b style="color:#093; font-size:11px;">(E.g:- 04066136226)</b><asp:RangeValidator ID="RangeValidator2" runat="server" 
          ErrorMessage="Number must start with 0" ControlToValidate="txtph"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postevent">*</asp:RangeValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
          ControlToValidate="txtph" ErrorMessage="phone number must be numbers only" 
          ValidationExpression="\d{11}">*</asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span>&nbsp;<span class="list">Mobile</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left" class="mid1_menu">
                    <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
                    <asp:TextBox ID="txtmob" runat="server" Height="20px" 
          Width="203px" MaxLength="10" onkeypress="return onlyNos(event,this);" ValidationGroup="events"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="please enter the mobile number" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator>
          <b style="color:#093; font-size:11px;">(E.g:- 9000465921)</b>
      <%--<asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage="Number must start with 0" ControlToValidate="txtmob"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postevent">*</asp:RangeValidator>--%>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="mobile number must be numbers only" 
          ValidationExpression="\d{10}">*</asp:RegularExpressionValidator></td>
                  </tr>                  
                  <tr>
                    <td align="right" class="style10"><span class="star"></span>&nbsp;<span class="list">fax</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtfax" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox>
   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
          ControlToValidate="txtfax" ErrorMessage="fax must be numbers only" 
          ValidationExpression="\d{11}">*</asp:RegularExpressionValidator>
                      </td>
                  </tr>
                  <tr>
                    <td align="right" valign="top" class="style10"><span class="star"></span><span class="list">
                        website</span></td>
                    <td align="center" valign="top"><strong>:</strong></td>
                    <td height="30" align="left" class="mid1_menu"> <asp:TextBox ID="txtweb" runat="server" Height="20px" Width="203px"></asp:TextBox>
  <b style="color:#093; font-size:11px;">(E.g:- http://www.Justcalluz.com )</b>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="txtweb" ErrorMessage="Invalid format of website" 
          ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
          ValidationGroup="postevent">*</asp:RegularExpressionValidator>
     
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="postevent" ShowMessageBox="True" ShowSummary="False" /></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10">&nbsp;</td>
                   
                    
                  </tr>
                  
                  <tr><td colspan="3">
                  <table width="100%">
                            <tr>
                                <td style="font-family:Arial" colspan="2">
                                    To upload Logo
                                </td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="uploadLogo" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnlogo" runat="server" Text="UploadLogo" OnClick="btnlogo_Click" />
                                    
                                </td>
                               
                            </tr>
                            <tr><td>
                            <asp:Image ID="ImgLogo" AlternateText="CompanyLogo" runat="server" Width="100px" Height="75px" />
                            </td></tr>
                           
                            <tr>
                            <td colspan="4"></td>
                            </tr>
                           
                            <tr>
                                <td style="font-family:Arial" colspan="2">
                                    To upload Photos 
                                </td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="uploadPhotos" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnUploadPhotos" runat="server" Text="Upload Photos" 
                                        onclick="btnUploadPhotos_Click" />
                                </td>
                                
                            </tr>
                            
                             <tr>
                            <td colspan="2"></td>
                            <td colspan="2">
                                <asp:DataList ID="ddlphoto" runat="server" RepeatDirection="Horizontal">
                                    <ItemTemplate>                                     
                                        <asp:Image ID="Imgphoto" AlternateText="CompanyPhotos" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("PhotoName", "../Photos\\{0}") %>' /> 
                                        <asp:Button ID="lnkdelphoto" runat="server" Text="Delete" OnCommand="lnkdelphoto" BorderStyle="None" BackColor="#ECF9FF" 
                                          CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm(Are you Sure ! To delete this photo)" />                                                                             
                                    </ItemTemplate>                                   
                                </asp:DataList>
                                <asp:Label ID="lblNoLogo" runat="server" ForeColor="Green"></asp:Label>
                            </td>
                            </tr>
                            <tr>
                            <td colspan="4"></td>
                            </tr>
                            <tr>
                                <td style="font-family:Arial" colspan="2">
                                    To upload Videos
                                </td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="uploadVedios" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnUploadVedios" runat="server" Text="Upload Vedios" 
                                        onclick="btnUploadVedios_Click" />
                                </td>
                               
                            </tr>
                            <tr>
                            <td colspan="5">
                            <asp:Button ID="lnkplayved" runat="server" BorderStyle="None" BackColor="#ECF9FF"
                                Text="Click here to view existing video" OnClick="lnkplayved_Click" />
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            <asp:Label ID="lblException" runat="server"></asp:Label>
                           <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            </td>
                            </tr>
                            <%--<tr><td>
                            <asp:Panel ID="pnlvideo" runat="server">
                            <fieldset>
                            <table>
                            <tr>
                            <td>
                             <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                            </td></tr>
                            <tr><td align="center" colspan="3">
                            <asp:Button ID="close" runat="server" Text="Close" />
                            </td></tr>
                            </table>
                            </fieldset>
                            </asp:Panel>
                            </td></tr>--%>
                        </table>
                  </td></tr>
                  
                  <%--<AjaxToolkit:ModalPopupExtender ID="popvideo" runat="server" PopupControlID="pnlvideo" TargetControlID="lnkplayved" CancelControlID="close" BackgroundCssClass="modalBackground" DropShadow="false"></AjaxToolkit:ModalPopupExtender>--%>
                  <tr>
                  <td colspan="3">
                                 <table width="100%">
                                    <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">
                                        Hours of Operation :</td></tr>
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Monday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlMonday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvMon" runat="server" 
                                          ControlToValidate="ddlMonday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" SkinID="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trMonDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlMonHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlMonMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlMonType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlMonHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlMonMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlMonType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          <%--<asp:TextBox ID="txtMonHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtMonMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtMonHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtMonMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm   --%>                                   
                                          &nbsp;<%--<asp:LinkButton ID="lnkMonTimings" runat="server" ForeColor="Red" 
                                              onclick="lnkMonTimings_Click">Add Timings</asp:LinkButton>--%>
                                              <a id="lnkMonTimings" runat="server" style="color:Red;" onserverclick="lnkMonTimings_Click">Add Timings</a>  
                                          <asp:Label ID="lblLnkMon" runat="server" Visible="false"></asp:Label>
                                      </td>
                                  </tr>
                                  <tr id="trLstMon" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrMonTime" runat="server"></asp:Literal>   
                                     <%--<asp:LinkButton ID="lnkBtnClearMonTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearMonTimings_Click"
                                             >Clear Timings</asp:LinkButton> --%> 
                                     <a id="lnkBtnClearMonTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearMonTimings_Click">Clear Timings</a>                                 
                                                                     
                                    </td>
                                    <td>
                                           <asp:Label ID="lblMonTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Tuesday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlTuesday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvTues" runat="server" 
                                          ControlToValidate="ddlTuesday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>                                  
                                  <tr id="trTuesDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlTuesHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlTuesMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlTuesType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlTuesHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlTuesMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlTuesType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkTuesTimings" runat="server" ForeColor="Red" 
                                              onclick="lnkTuesTimings_Click">Add Timings</asp:LinkButton>--%>
                                           <a id="lnkTuesTimings" runat="server" style="color:Red;" onserverclick="lnkTuesTimings_Click">Add Timings</a>                                             
                                          <asp:Label ID="lblLnkTues" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtTuesHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtTuesMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtTuesHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtTuesMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr>
                                  <tr id="trLstTues" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrTuesTime" runat="server"></asp:Literal>   
                                    <%-- <asp:LinkButton ID="lnkBtnClearTuesTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearTuesTimings_Click"
                                             >Clear Timings</asp:LinkButton> --%> 
                                     <a id="lnkBtnClearTuesTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearTuesTimings_Click">Clear Timings</a>
                                     </td>
                                    <td>
                                           <asp:Label ID="lblTuesTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Wednesday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlWednesday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvWed" runat="server" 
                                          ControlToValidate="ddlWednesday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trWedDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlWedHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlWedMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlWedType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlWedHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlWedMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlWedType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkWedTimings" runat="server" ForeColor="Red" onclick="lnkWedTimings_Click" 
                                             >Add Timings</asp:LinkButton>--%>
                                          <a id="lnkWedTimings" runat="server" style="color:Red;" onserverclick="lnkWedTimings_Click">Add Timings</a>                                                                
                                          <asp:Label ID="lblLnkWed" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtWedHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtWedMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtWedHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtWedMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr>
                                  <tr id="trLstWed" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle" style="font-family:Arial">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrWedTime" runat="server"></asp:Literal>       
                                     <%--<asp:LinkButton ID="lnkBtnClearWedTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearWedTimings_Click"
                                             >Clear Timings</asp:LinkButton> --%>
                                      <a id="lnkBtnClearWedTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearWedTimings_Click">Clear Timings</a>                                                                                                                                      
                                                                    
                                    </td>
                                    <td>
                                           <asp:Label ID="lblWedTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr id="Thurs" runat="server">
                                  <td class="adminform" style="font-family:Arial" align="right">Thursday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlThursday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvThurs" runat="server" 
                                          ControlToValidate="ddlThursday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trThursDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlThursHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlThursMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlThursType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlThursHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlThursMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlThursType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkThursTimings" runat="server" ForeColor="Red" onclick="lnkThursTimings_Click" 
                                             >Add Timings</asp:LinkButton>--%>
                                           <a id="lnkThursTimings" runat="server" style="color:Red;" onserverclick="lnkThursTimings_Click">Add Timings</a>                                                                                                                                                                             
                                           
                                          <asp:Label ID="lblLnkThurs" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtThursHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtThursMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtThursHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtThursMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr>
                                  <tr id="trLstThurs" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrThursTime" runat="server"></asp:Literal>
                                    <%-- <asp:LinkButton ID="lnkBtnClearThursTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearThursTimings_Click" 
                                             >Clear Timings</asp:LinkButton>  --%> 
                                      <a id="lnkBtnClearThursTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearThursTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                                        
                                    </td>
                                    <td>
                                           <asp:Label ID="lblThursTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Friday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlFriday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvFri" runat="server" 
                                          ControlToValidate="ddlFriday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trFriDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlFriHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlFriMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlFriType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlFriHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlFriMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlFriType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkFriTimings" runat="server" ForeColor="Red" onclick="lnkFriTimings_Click" 
                                             >Add Timings</asp:LinkButton>--%>
                                        <a id="lnkFriTimings" runat="server" style="color:Red;" onserverclick="lnkFriTimings_Click">Add Timings</a>                                                                                                                                                                             
                                            
                                          <asp:Label ID="lblLnkFri" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtFriHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtFriMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtFriHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtFriMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr>
                                  <tr id="trLstFri" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrFriTime" runat="server"></asp:Literal>     
                                     <%--<asp:LinkButton ID="lnkBtnClearFriTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearFriTimings_Click"
                                             >Clear Timings</asp:LinkButton> --%> 
                                      <a id="lnkBtnClearFriTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearFriTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                                    
                                    </td>
                                    <td>
                                           <asp:Label ID="lblFriTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Saturday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlSaturday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvSat" runat="server" 
                                          ControlToValidate="ddlSaturday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trSatDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlSaturHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlSaturMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSaturType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlSaturHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlSaturMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSaturType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkSaturTimings" runat="server" ForeColor="Red" onclick="lnkSaturTimings_Click" 
                                             >Add Timings</asp:LinkButton>--%>
                                              <a id="lnkSaturTimings" runat="server" style="color:Red;" onserverclick="lnkSaturTimings_Click">Add Timings</a>                                                                                                                                                                             
                                            
                                          <asp:Label ID="lblLnkSatur" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtSaturHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtSaturMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtSaturHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtSaturMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr> 
                                  <tr id="trLstSatur" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrSaturTime" runat="server"></asp:Literal>
                                      <%--<asp:LinkButton ID="lnkBtnClearSatTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSatTimings_Click"
                                             >Clear Timings</asp:LinkButton>--%>
                                     <a id="lnkBtnClearSatTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSatTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                                          
                                    </td>
                                    <td>
                                           <asp:Label ID="lblSaturTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>                                                                                  
                                  <tr>
                                  <td class="adminform" style="font-family:Arial" align="right">Sunday</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlSunday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="rfvSun" runat="server" 
                                          ControlToValidate="ddlSunday" ErrorMessage="RequiredFieldValidator" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
                                  </td>
                                  </tr>
                                  <tr id="trSunDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle" style="font-family:Arial">
                                          <asp:DropDownList ID="ddlSunHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlSunMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSunType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlSunHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlSunMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSunType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<%--<asp:LinkButton ID="lnkSunTimings" runat="server" ForeColor="Red" onclick="lnkSunTimings_Click" 
                                             >Add Timings</asp:LinkButton>--%>
                                          <a id="lnkSunTimings" runat="server" style="color:Red;" onserverclick="lnkSunTimings_Click">Add Timings</a>                                                                                                                                                                             
                                           
                                          <asp:Label ID="lblLnkSun" runat="server" Visible="false"></asp:Label>
                                          <%--<asp:TextBox ID="txtSunHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtSunMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                                          &nbsp;&nbsp;
                                          <asp:TextBox ID="txtSunHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                                          <asp:TextBox ID="txtSunMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                                      </td>
                                  </tr>
                                  <tr id="trLstSun" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrSunTime" runat="server"></asp:Literal>   
                                     <%--<asp:LinkButton ID="lnkBtnClearSuntimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSuntimings_Click"
                                             >Clear Timings</asp:LinkButton>--%>  
                                    <a id="lnkBtnClearSuntimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSuntimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                                      
                                    </td>
                                    <td>
                                           <asp:Label ID="lblSunTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                 <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">
                                     Mode Of Payment :</td></tr>
                                  <tr id="trPayment" runat="server">
                                      <td colspan="2"></td>
                                      <td align="left" style="font-family:Arial">
                                          <asp:CheckBoxList ID="modecheck" runat="server" RepeatColumns="2" Font-Names="Arial">
                                          <asp:ListItem> American Express Card</asp:ListItem>
                                          <asp:ListItem> Cash</asp:ListItem>
                                          <asp:ListItem> Cheques</asp:ListItem>
                                          <asp:ListItem> Credit Card</asp:ListItem>
                                          <asp:ListItem> Debit Card</asp:ListItem>
                                          <asp:ListItem> Financind Available</asp:ListItem>
                                          <asp:ListItem> Master Card</asp:ListItem>
                                          <asp:ListItem> Money Orders</asp:ListItem>
                                          <asp:ListItem> Travelers Check</asp:ListItem>
                                          <asp:ListItem> Visa Card</asp:ListItem>
                                        
                                          
                                          </asp:CheckBoxList>
                                      </td>
                                  </tr>
                                  <tr><td colspan="3" style="font-family:Arial; font-size:medium;" align="left">Additional Information:</td></tr>
                                  <tr id="tr2" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:TextBox ID="txtAdtInfo" runat="server" TextMode="MultiLine" Width="196px"></asp:TextBox>
                                      </td>
                                  </tr>
                                  
                                  <tr><td></td></tr>
                                  <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">
                                      Company Profile :</td></tr>
                                  <tr><td></td></tr>
                                  <tr><td style="font-family:Arial" align="right">Year Of Establishment </td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlyearestablish" runat="server" Width="197px">
                                      </asp:DropDownList>
                                                                        </td>
                                  </tr>
                                  <tr><td style="font-family:Arial" align="right">Professional Association</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left"><asp:TextBox ID="txtprofass" runat="server" Width="196px"></asp:TextBox></td>
                                  </tr>
                                  <tr>
                                  <td style="font-family:Arial" align="right">Certification</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left"><asp:TextBox ID="txtcertificate" runat="server" Width="196px"></asp:TextBox></td>
                                  </tr>
                                  <tr><td style="font-family:Arial" align="right">No.of.Employees</td>
                                  <td align="center"><strong>:</strong></td>
                                  <td align="left"><asp:TextBox ID="txtemp" runat="server" Width="196px"></asp:TextBox></td>
                                  </tr>
                                  <tr><td></td></tr>
                                  <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">
                                      Verification Code :</td></tr>
                                   <tr><td></td></tr>
                                   <tr>
  <td align="right">
 <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
      <ContentTemplate> 
        
        <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
        CaptchaBackgroundNoise="None" CaptchaHeight="35" CaptchaLength="4" 
        CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
        CaptchaMaxTimeout="200" Width="90px" />
       </ContentTemplate>
       </asp:UpdatePanel>
        </td>
        <td ><strong>:</strong></td>
        <td align="left">
            <asp:TextBox ID="txtvid" runat="server" Width="196px"></asp:TextBox>
        </td>
  </tr>
  <tr><td></td></tr>
                                 <%-- <tr>
                                    <td colspan="3">
                                        <asp:Button ID="btnAddMoreInfo" runat="server" Text="To Add More Info" 
                                            onclick="btnAddMoreInfo_Click" ValidationGroup="HRO" />
                                        <asp:Button ID="btnUpdateMoreInfo" runat="server" Text="Update More Info" 
                                            onclick="btnUpdateMoreInfo_Click" ValidationGroup="HRO" />&nbsp;&nbsp;
                                        <asp:Button ID="btnSkip" runat="server" Text="Skip" onclick="btnSkip_Click" />
                                  </tr>--%>
                                </table>
                            </td>
                  </tr>
                                  
                  <tr>
                    <td height="30" colspan="3"><table width="100%" border="0">
                      <tr>
                        <td width="36%" align="right" height="40" style="padding-right:3px;">
                        <asp:ImageButton ID="updatebtn" runat="server" ImageUrl="../images/update.png" AlternateText="UpdateButton"
                              onclick="updatebtn_Click" ValidationGroup="postevent" /></td>
                        
                        <td width="40%" align="left"><asp:ImageButton ID="cancel" AlternateText="CancelButton" runat="server" ImageUrl="../images/cancel-button.png" onclick="cancel_Click"
         
           /></td>
                      </tr>
                    </table></td>
                    </tr>
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:5px;"><font class="side_menu" color:"#005B88">
                        Dear Guest, kindly submit all the &nbsp; marked details. Its kind of</font>&nbsp; <span class="mid_menu"><strong class="mid_menu"><font color="#E84B00">
                        mandatory</font></strong>. </span><span class="side_menu">What to</span> <span class="side_menu">
                        do! Its not our fault. We are here to provide the best of our services<strong>&nbsp;</strong></span><span class="mid_menu"><strong><font color="#E84B00"> 
                        24*7</font></strong></span></td>
                  </tr>
                  <tr>
                    <td height="30" colspan="3" align="right">&nbsp;</td>
                    </tr>
                  </table>
                </td>
              </tr>            
        </table>
       </div>
     </td>
  </tr>
  </table>
  </div>
 <div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
 <table width="100%" border="0">
    <tr>
      <td width="100%" align="center" valign="top" class="right_tab">
       <spLinks_Right:Sp_Links ID="Ads" runat="server" />
      </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
 <%-- <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
     <img src="images/event/add2.png" alt="LifestyleSponseredAds" width="175" height="600" /><br />
      <img src="images/event/search-job-2.png" alt="LifestyleSponseredAds" width="175" height="400" /><br />
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>--%>
</div>
<div class="contentbox_bottam"></div>
</div>
 </div>
 <div class="footer"></div> 
<!-- end of the mid Box-->  
<div class="content_midbootam" >
<bcm:contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:bottomcontent ID="bottomcontent" runat="server" />

</div>

<div class="footer" align="center" style="padding-top:5px; " >
    <aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
</div>
  
  </div>
  </div>

    </form>
</body>
</html>
