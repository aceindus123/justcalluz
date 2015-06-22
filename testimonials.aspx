<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testimonials.aspx.cs" Inherits="testimonials" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/media_left.ascx" TagName="lftmedia" TagPrefix="lmedia" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Testimonials page</title>--%>
<title>Testimonials & Reviews | JustCalluz</title>
<meta name='description' content='Find testimonials & reviews given by JustCalluz users  of website, application and WAP. Share your views & testimonials about JustCalluz.' />
<meta name='keywords' content='justcalluz testimonials, testimonials of justcalluz, justcalluz client reviews, reviews of justcalluz' />
		
<%--<link href="css/style.css" rel="stylesheet" type="text/css" />--%>
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
        <style type="text/css">
            .style1
            {
                height: 45px;
            }
            .style2
            {
                height: 38px;
            }
            .style3
            {
                width: 3%;
            }
            .style4
            {
                height: 45px;
                width: 3%;
            }
            .style5
            {
                height: 38px;
                width: 3%;
            }
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
 <script type="text/javascript" language="javascript" >
     String.prototype.startsWith = function (str) {
         return (this.indexOf(str) === 0);
     }
     function ChkValidChar() {
         var txtbx = document.getElementById("txtMobileNo").value;
         if (txtbx.startsWith("0")) // true
         {
             if (txtbx.startsWith("00")) {
                 alert("enter other than 0");

             }
         }

         else {
             document.getElementById("txtMobileNo").value = "";
             alert("you can not insert dot and zero as first character");
         }
     }

     $("#txtMobileNo").on('keydown', function (e) {
         $('label').text(e.keyCode);
     });
    </script>
 
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
  
<div class="layout">
<div class="signin">
  <aa1:signin ID="signIn" runat="server" />
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<lmedia:lftmedia ID="leftmedia" runat="server" />
</div>
 <div class="content_innermid" style="width:79%;">
    <table width="100%" border="0">
   <tr>
      <td style="background:url(images/Testimonials.png) no-repeat;" height="39">
     <table width="100%" border="0">
     <tr>
    <td width="60%" class="bottam" style="padding:0px 5px 10px 5px;">
    <font color="#FFFFFF">Testimonials</font>
    </td>
    <td width="40%" style="padding:0px 0px 10px 5px;">
      <asp:Image ImageUrl="images/pencial.png" width="20" height="20" runat="server" AlternateText="imagePencial" />
      <font color="#FFFFFF">Free Listing Share Your Views about Justcalluz</font>
    </td>
    </tr>
     </table>
    </td>
  </tr>
  <tr>
     <td style="padding-left:10px;">
      <asp:Label ID="lblResult" runat="server"></asp:Label>
     </td>
    </tr>
   </table> 
    <table id="Testimonials" width="100%">
      <tr>
      <td >
        <asp:DataList ID="DlData" runat="server" Font-Bold="True" ForeColor="Black" Width="100%">  
          <ItemTemplate >
            <table border="0" width="100%" style="padding-left:15px;">
                 <tr>
                   <td width="10%" style="padding-top:5px;">
                       <asp:Image ID="image1"  runat="server" ImageUrl='<%#Eval("ImageName","../testimonial_images\\{0}")%>' Width="46" Height="51" />
                   </td>
                   <td width="90%" class="mid_menu" valign="top" style="padding-top:5px;">
                      <asp:Image ImageUrl="images/leftquote.gif" runat="server"/>&nbsp;<%#DataBinder.Eval(Container.DataItem, "Views")%>&nbsp;<asp:Image ImageUrl="images/rightquote.gif" runat="server"/>
                   </td>
                  </tr>
             </table>
             <table border="0" width="100%" style="padding-left:15px;">
                   <tr>
                       <td height="36" class="mid_menu">
                           <%#DataBinder.Eval(Container.DataItem, "nick_name")%>
                       </td>
                        <td align="right" style="padding-right:10px;" class="headings1">
                           <%#DataBinder.Eval(Container.DataItem, "PostDate")%>                       
                        </td>
                   </tr>
                   <tr class="headings1">
                       <td>
                          <%#DataBinder.Eval(Container.DataItem, "EmailAddress")%>
                        </td>
                        <td align="right" class="headings1" style="padding-right:10px;">
                           <%#DataBinder.Eval(Container.DataItem, "City")%>,
                           <%#DataBinder.Eval(Container.DataItem, "State")%>
                       </td>
                   </tr> 
             </table>
            <tr>
             <td style="padding-left:10px;"><hr/></td>
            </tr> 
         </ItemTemplate>
        </asp:DataList>
       </td>
      </tr>
    </table> 
    <table border="0" width="100%" id="tblpaging" runat="server">
        <tr>
          <td align="right" style="padding-right:13px;">
            <asp:ImageButton ID="imgPrevious" runat="server" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
          </td>
        </tr>
       </table>      
      <table id="shareViews" width="100%">
      <tr>    
       <td class="bottam" height="40" style="padding-left:11px;">Share Your Views About Justcalluz</td></tr>
      <tr>
        <td style="padding-left:8px;"><hr/></td>
      </tr>         
      <tr>
        <td style="padding-left:8px;">
       <table width="100%" border="0" style="background-color:#E1F5FF; border:dotted 1px #666">
         
        <tr>
          <td height="30" colspan="3" class="headings" style="padding-left:10px;">
          <span class="headings" style="padding-left:10px;">Denotes mandatory fields</span></td>
        </tr>
        <tr>
          <td colspan="3"><hr/></td>
          </tr>
        <tr>
          <td width="25%" height="30" align="right"><span class="star">*</span><span class="list">Your Name</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td width="73%" height="30" align="left" >
          <asp:TextBox ID="txtName" runat="server" 
                     Width="189px" style="margin-left: 9px" onkeypress="return Alphabets(event);"></asp:TextBox>
                 &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rf1" runat="server" 
                  ErrorMessage="please enter Name" ControlToValidate="txtName" ValidationGroup="testimonials">*</asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
          <td width="25%" height="30" align="right"><span class="star">*</span><span class="list">Your Nick Name</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td width="73%" height="30" align="left">
          <asp:TextBox ID="txtNickName" runat="server" 
                     Width="189px" style="margin-left: 9px" onkeypress="return Alphabets(event);"></asp:TextBox>
                 &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvNickName" runat="server" 
                  ErrorMessage="please enter nick Name" ControlToValidate="txtNickName" ValidationGroup="testimonials">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
          <td height="30" align="right" width="25%"><span class="star">*</span><span class="list">Your Email Address</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
           <td width="73%" height="30" align="left">
             <asp:TextBox ID="txtEmailAddress" 
                      runat="server" Width="189px" style="margin-left: 9px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvtxtEmailAddress" runat="server" ErrorMessage="please enter email address" 
                  ControlToValidate="txtEmailAddress" ValidationGroup="testimonials">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revtxtEmailAddress" runat="server" 
                    ErrorMessage="Please enter valid email address" ControlToValidate="txtEmailAddress" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="testimonials">*</asp:RegularExpressionValidator>
          </td>
        </tr>
        <tr>
          <td height="30" align="right" width="25%"><span class="star">*</span><span class="list">Your Mobile No</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td height="30" align="left">
           <asp:TextBox ID="txtMobileNo" runat="server" 
                       Width="189px" MaxLength="11" style="margin-left: 9px" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="color:#093; font-size:11px;">(E.g:- 09989756590)</b> 
                <asp:RequiredFieldValidator ID="rfvtxtMobileNo" runat="server" 
                   ErrorMessage="enter only 11 digit number,starts with 1-9 numbers" ControlToValidate="txtMobileNo" 
                   ValidationGroup="testimonials">*</asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="revtxtMobileNo" runat="server" 
                   ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits) " 
                   ControlToValidate="txtMobileNo" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" 
                   ValidationGroup="testimonials"></asp:RegularExpressionValidator>
                  <asp:RangeValidator ID="rvtxtMobileNo" runat="server" MaximumValue="1" MinimumValue="0" 
                      ErrorMessage="please enter mobile number" ControlToValidate="txtMobileNo" 
                       ValidationGroup="testimonials"></asp:RangeValidator>
                       


          </td>
        </tr>
        <tr>
          <td height="30" align="right" width="25%"><span class="star">*</span><span class="list">Your State</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td height="30" align="left">
             <asp:DropDownList ID="ddlState" runat="server" 
                        Width="191px" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" 
                        AutoPostBack="true" style="margin-left: 9px">
                      </asp:DropDownList> 
                    <asp:RequiredFieldValidator ID="rfvddlState" runat="server" 
                       ErrorMessage="please Select state" ControlToValidate="ddlState" 
                        ValidationGroup="testimonials" InitialValue="Select State">*</asp:RequiredFieldValidator>
          
          </td>
        </tr>
        <tr>
          <td align="right" width="25%" height="30"><span class="star">*</span><span class="list">Your City</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td align="left" height="30">
            <asp:DropDownList ID="ddlCity" runat="server" 
                        Width="191px" AutoPostBack="false" style="margin-left: 9px">
                        <asp:ListItem Text="Select city"></asp:ListItem>
                        </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="rfvddlCity" runat="server" 
                          ErrorMessage="please Select City" ControlToValidate="ddlCity" 
                         ValidationGroup="testimonials" InitialValue="Select city">*</asp:RequiredFieldValidator>
         
          </td>
        </tr>
        <tr>
          <td align="right" height="30" width="25%"><span class="list">Your Photo</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td align="left" height="30">
             <asp:FileUpload ID="photo" 
                         runat="server"  Width="192px" style="margin-left: 9px"/>
          
          </td>
        </tr>
      
        <tr>
          <td height="86" align="right" valign="middle"><span class="star">*</span><span class="list">Your Views</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td height="86" align="left" >
               
              <asp:TextBox ID="txtViews" runat="server" TextMode="MultiLine" Width="360px" Height="120px"
                  style="margin-left: 9px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvtxtViews" runat="server" 
                   ErrorMessage="please enter Your Views" ControlToValidate="txtViews" 
                   ValidationGroup="testimonials">*</asp:RequiredFieldValidator>
            
          </td>
        </tr>
        <tr>
          <td height="27" colspan="3" style="padding-left:170px; padding-top:4px;" align="center">
           <asp:ImageButton ID="btnSubmit" runat="server" ImageUrl="images/submit1.png" 
                  Height="27px" Width="110px" onclick="btnSubmit_Click" ValidationGroup="testimonials" AlternateText="SubmitButton"/>
          </td>
        </tr>
        <tr>
          <td colspan="3" align="right">&nbsp;</td>
         </tr>
         <tr align="center">
           <td>
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                      ShowMessageBox="True" ShowSummary="False" ValidationGroup="testimonials" />
           </td>
         </tr>
        </table>
      </td>      
      </tr>
      <tr>
        <td></td>      
      </tr>
      <tr>
        <td></td></tr>
    </table>
    </div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
</form>
</body>
</html>
