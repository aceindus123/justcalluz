<%@ Page Language="C#" AutoEventWireup="true" CodeFile="computers.aspx.cs" Inherits="computers" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/linkcontroll_innerleft.ascx" TagName="innerleft" TagPrefix="link_innerleft" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title> Justcalluz | Are you looking for Computer and peripherals we provide updated information on all your local search</title>
<meta name='description' content='Computer and peripherals,find the contact of computer and peripherals provider in your city' />
<meta name='keywords' content='Justcalluz, Computer repair center,computer shops, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
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
     
<%--  <link href="style.css" rel="Stylesheet" type="text/css" />--%>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
<link href="css/tab.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="SpryAssets/accordian.pack.js"></script>
  <script src="~/jquery-latest.pack.js" type="text/javascript"></script>
<script src="~/jcarousellite_1.0.1c4.js" type="text/javascript"></script>
<script src="~/Scripts/swfobject_modified.js" type="text/javascript"></script>
<script type="text/javascript">
$(function() {
	$(".newsticker-jcarousellite").jCarouselLite({
		vertical: true,
		hoverPause:true,
		visible: 1,
		auto:500,
		speed:1000
	});
});
</script>
<style type="text/css">
/* Scroller */

.newsticker-jcarousellite { width:135px; }
.newsticker-jcarousellite ul li{ list-style:none; display:block; padding-bottom:1px; margin-bottom:5px; }
.newsticker-jcarousellite .thumbnail { float:left; width:135px; height:40px; }
.newsticker-jcarousellite .info { float:right; width:190px; }
.newsticker-jcarousellite .info span.cat { display: block; font-size:10px; color:#808080; }

</style>
<script type="text/javascript">function postbackFromJS(sender, e) 
          {
            var postBack = new Sys.Preview.PostBackAction();
            postBack.set_target(sender);
            postBack.set_eventArgument(e);
            postBack.performAction();
          }      
             </script>

<link href="starrater.css" type="text/css" rel="Stylesheet" />
</head>
<body>
<form id="f1" runat="server">
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
<!--begin of table-->
  <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
<div class="layout">
 <div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div>
<div class="header_search">
<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">
<!-- start the inner left-->
<div class="content_innerleft">
<link_innerleft:innerleft ID="content_inner" runat="server" />
<!-- ending the left -->
</div>
<div class="content_innermid">
<div class="contentmid_boxtop"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home>></a><asp:Label ID="Label11"
      runat="server" Text="Popular Search Categories"></asp:Label></div>
<div class="contentmid_boxmid">
<table width="100%" border="0">
<tr>
<td height="30">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    Result for&nbsp;<strong class="side_menu">
    :&nbsp;<asp:Label ID="Label10" runat="server"></asp:Label></strong>
</td>
<td>
        <asp:ImageButton ID="imgbtnSendMAIL" runat="server" AlternateText="btnSendMail" ImageUrl="images/send-_button.png" />          
   <cc1:ModalPopupExtender ID="ModalPopupExtender" runat="server"  
        TargetControlID="imgbtnSendMAIL" PopupControlID="Panel3" BackgroundCssClass="modalBackground" 
       OkControlID="imgCancel"
        DropShadow="false" PopupDragHandleControlID="panel4" ></cc1:ModalPopupExtender>
 </td>
</tr>
<%--<tr>
    
</tr>--%>
<tr>
<td align="center" valign="top" style="padding-top:10px" colspan="4">
<asp:DataList ID="DLBindCatData" DataKeyField="id" runat="server" Width="100%" 
    style="margin-left: 0px" onitemdatabound="DLBindCatData_ItemDataBound">
      <HeaderTemplate> 
       <table width="100%" border="0">   
    </HeaderTemplate>
      <ItemTemplate>  
      <tr><td height="4px"></td></tr>
          <tr>
            <td style="background:url(images/event_send03.png) no-repeat; height:200px;" valign="top" height="165px">    
            <table width="100%" cellpadding="0px" cellspacing="0px" border="0">  
                
                  <tr>
                    <td valign="middle" width="50%" colspan="2" class="sub_menu" style="padding:5px 5px 0px 10px; border-right-style:dashed; border-right-color:Gray; border-right-width:1px;" align="left">
                           <%-- <asp:HyperLink ID="hypCompany" runat="server" Text='<%# Eval("compname") %>' 
                                NavigateUrl='<%# string.Format("sessionstore.aspx?id=" + Eval("id").ToString()+"&cname="+Eval("company_name").ToString()) %>'></asp:HyperLink>--%>
                           <asp:HyperLink ID="hypCompany" runat="server" Text='<%# Eval("compname") %>' ToolTip='<%# Eval("company_name") %>' 
                                NavigateUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>'></asp:HyperLink>
                         </td> 
                        <td width="35%" style="padding-left:4px; padding-top:5px;" height="20" colspan="2" align="left">
                        <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>         
                        <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                            <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                </asp:Label>
                            </asp:Label>            
                        </asp:Label>&nbsp;
                          <span class="sub_menu" style="color:Black"><asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings</span>
                         </td>
                         <td width="15%" class="sub_menu" style="padding-top:5px; padding-right:8px">                                    
                             <%--<asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# string.Format("PostReviewCat.aspx?DataId=" + Eval("id").ToString()) %>'>Rate This</asp:HyperLink>--%>
                              <asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# GetRateUrl(Eval("id")) %>'>Rate This</asp:HyperLink>
                        </td>
                    </tr>
                    <tr><td colspan="3" height="10px"></td></tr>
                     <tr class="side_menu">
                        <td width="23%" rowspan="3" style="padding-bottom:20px; padding-left:15px;" id="tdlogo" runat="server" visible="false" align="center">
                           <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
                           <asp:Image  ID="imgReviewer"  runat="server" AlternateText="images" ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>' 
                                Width="99"  Height="68"/>
                        </td>
                        <td style="height:5px;padding-left:10px; height:30px;" colspan="4" align="left">
                           <asp:Label ID="lbladdress" runat="server" Text ='<%# Eval("address") %>'></asp:Label>
                            <asp:Label ID="lblcomma" runat="server" Text=","></asp:Label>
                             <asp:Label ID="lblVarea" runat="server" Text ='<%# Eval("area") %>' Visible="false"></asp:Label>
                            <asp:Label ID="lblcity" runat="server" Text ='<%# Eval("City") %>'></asp:Label>
                            <asp:Label ID="lblcomma1" runat="server" Text=","></asp:Label>
                            <asp:Label ID="lblstate" runat="server" Text ='<%# Eval("State") %>'></asp:Label>
                             <asp:Label ID="lblcomma2" runat="server" Text=","></asp:Label>
                            <asp:Label ID="lblpincode" runat="server" Text ='<%# Eval("Pincode") %>'></asp:Label><br />
                      </td>
                      </tr>
                      <tr class="side_menu">
                      <td  style="height:5px;padding-left:10px; height:30px;" colspan="4" align="left">
                            Contact&nbsp;:&nbsp;<asp:Label ID="lblmob" runat="server" Text ='<%# Eval("contact_person") %>'></asp:Label>&nbsp;|
                            <asp:Label ID="lbllandphone" runat="server" Text ='<%# Eval("mob") %>'></asp:Label>
                     </td>
                     </tr>
                     </tr>
                     <%-- <tr>
                     <td colspan="4" class="side_menu" align="left" style="height:30px;">
                      <span class="side_menu">View Map</span>&nbsp;|&nbsp;<asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# "sessionstore.aspx?id=" + Eval("id").ToString() %>'></asp:HyperLink>
                      </td>
                      </tr>--%>
                       <%--<tr><td colspan="4">&nbsp;</td></tr>--%>
                       <tr><td colspan="4">&nbsp;</td></tr>
                        <tr><td colspan="4">&nbsp;</td></tr>
                       <tr><td colspan="6" style="width:100%; height:30px;">
                       <table width="100%" border="0">
                          <tr>
                             <td width="408" align="left" style="padding-left:8px;"><asp:ImageButton ID="img1" AlternateText="btnSend" ImageUrl="images/send-_button.png" runat="server" width="120" height="24" PostBackUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>'/></td>
                            <td width="84" align="left" valign="top"><asp:HyperLink ID="hyp1" runat="server" Text="View Details" NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink></td>
                            <td width="9" align="left" valign="top"><asp:Label ID="lblSlash" runat="server" Text="|"></asp:Label></td>
                            <td width="81" align="left" valign="top"><asp:HyperLink ID="lnkmap" runat="server" ForeColor="#003366" CssClass="pointer">View Map</asp:HyperLink> </td>
                          </tr>
                       </table></td></tr>
                       <%-- <tr>
                         <td align="center" style="height:30px;" colspan="3">
                          <asp:ImageButton ID="img1" runat="server" AlternateText="btnSend" ImageUrl="images/send-_button.png" PostBackUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>' />
                         </td>
                         <td style="padding-right:10px; padding-top:15px; height:30px;" colspan="6" align="right">
                              <span class="side_menu"><asp:HyperLink ID="lnkmap" runat="server" ForeColor="#003366" CssClass="pointer">View Map</asp:HyperLink></span>&nbsp;<asp:Label ID="lblSlash" Text="|" runat="server"></asp:Label>&nbsp;<asp:HyperLink ID="hyp1" runat="server" Text="View Details" NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
                         </td>
                      </tr>--%>
                      <%-- <tr>
                         <td style="padding-right:10px; padding-top:15px; height:30px;" colspan="6" align="right">
                          <asp:ImageButton ID="img1" runat="server" AlternateText="btnSend" ImageUrl="images/send-_button.png" PostBackUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>' />
                              <span class="side_menu"><asp:HyperLink ID="lnkmap" runat="server" ForeColor="#003366" CssClass="pointer">View Map</asp:HyperLink></span>&nbsp;|&nbsp;<asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
                         </td>
                      </tr>--%>
                     <tr><td>&nbsp;</td></tr>
                  </table> 
              </td>
        </tr> 
        <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender3" runat="server" TargetControlID="lnkmap" BackgroundCssClass="modalbackground" PopupControlID="pnlmap" DropShadow="false" CancelControlID="cancel">
          </AjaxToolkit:ModalPopupExtender>                                
    </ItemTemplate>
     <FooterTemplate>  
     </table>        
    </FooterTemplate>
 </asp:DataList>
 </td></tr>
 <tr><td>&nbsp;</td></tr>
<tr id="trPaging" runat="server" visible="false">
<td colspan="4" align="right" style="padding-right:7px;">
    <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
</td></tr>
<tr>
<td>
    <asp:Label ID="lblDatanotfound" runat="server"></asp:Label>
</td>
</tr>
<tr>
    <td>
      <asp:Panel ID="pnlmap" runat="server">
     <fieldset>
     <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
     <ItemTemplate>
     <table border="0" width="100%">
     <tr>
      <td width="60%" class="bottam"><strong class="side_menu">
            <%#DataBinder.Eval(Container.DataItem, "map")%>
            </strong></td>
     </tr>
     </table>
     </ItemTemplate>
     </asp:DataList>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="cancel" runat="server" Text="Close" BackColor="#16C56E" />
     </fieldset></asp:Panel>
     </td>
</tr>
<tr>
 <td>
<asp:Panel ID="Panel3" runat="server" Width="350px">
 <asp:Panel ID="Panel4" runat="server">
 </asp:Panel>
<div class="dilogbox">
  <table width="350px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:3px;">Get Information by sms/email
        &nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="imgCancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
   </tr>
  <%-- <tr><td class="style24"></td></tr>--%>
   <tr>
   <td height="190" colspan="2">
    <table align="center" width="400px" style="height: 154px;">
     <tr style="margin-left:5px">
       <td align="right">
       <span class="star">*</span>
        <asp:Label ID="Label6" runat="server" Text="Name" Font-Bold="false" ForeColor="Black" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
       <td>
        <asp:TextBox ID="txtname" runat="server" ValidationGroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
            ControlToValidate="txtname" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
     </td>
     </tr>
      <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label9" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmob" runat="server" ValidationGroup="sendmail" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
            ControlToValidate="txtmob" ErrorMessage="Enter Mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
            ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="sendmail"></asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
            ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rgvtxtmob" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="sendmail">*</asp:RangeValidator>
        </td>
      </tr>
     <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
         <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtemail" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtemail" runat="server" ControlToValidate="txtemail" 
            ErrorMessage="please enter Email id"  ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxtemail" runat="server" 
            ErrorMessage="Incorrect Format of email address" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="sendmail" ControlToValidate="txtemail" >*</asp:RegularExpressionValidator>
              <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
              ValidationGroup="sendmail" ShowMessageBox="True" ShowSummary="False" />
        </td>
    </tr>
    </table>
    </td>
    </tr>
  <tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imgbtnGo" OnClick="imgbtnGo_Click" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="sendmail"/>
  </td>
</tr>
    </table>
</div>
</asp:Panel> 
 </td>
</tr>
</table>
</div>
<div class="contentmid_boxbottam">
</div>
</div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
  <tr>
  <td class="right_tab">
  
 <aa3:Splinks id="splinks1" runat="server" />  
      
 </td>
</tr>
</table>
<!--end of 3 column-->
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center">
<aa10:footer1 ID="bvu" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>
<%--</ContentTemplate>
</asp:UpdatePanel>--%>
</div>
 </form>
</body>
</html>


