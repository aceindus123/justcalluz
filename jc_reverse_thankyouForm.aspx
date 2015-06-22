<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jc_reverse_thankyouForm.aspx.cs" Inherits="jc_reverse_thankyouForm" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: JC Recerse Auction</title>--%>
<title>JC Reverse Auction | JustCalluz</title>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/red_style.css" rel="stylesheet" type="text/css" media="screen" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
<script type="text/javascript">
$(function(){
	var slideHeight = 315; // px
	var defHeight = $('#wrap').height();
	if(defHeight >= slideHeight){
		$('#wrap').css('height' , slideHeight + 'px');
		$('#read-more').append('<a href="#">More</a>');
		$('#read-more a').click(function(){
			var curHeight = $('#wrap').height();
			if(curHeight == slideHeight){
				$('#wrap').animate({
				  height: defHeight
				}, "normal");
				$('#read-more a').html('Less');
				$('#gradient').fadeOut();
			}
			 else{
				$('#wrap').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more a').html('More');
				$('#gradient').fadeIn();
			}
			return false;
		});		
	}
});
$(function(){
	var slideHeight = 315; // px
	var defHeight = $('#wrap1').height();
	if(defHeight >= slideHeight){
		$('#wrap1').css('height' , slideHeight + 'px');
		$('#read-more1').append('<a href="#">More</a>');
		$('#read-more1 a').click(function(){
			var curHeight = $('#wrap1').height();
			if(curHeight == slideHeight){
				$('#wrap1').animate({
				  height: defHeight
				}, "normal");
				$('#read-more1 a').html('Less');
				$('#gradient1').fadeOut();
			}
			 else{
				$('#wrap1').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more1 a').html('More');
				$('#gradient1').fadeIn();
			}
			return false;
		});		
	}
});
$(function(){
	var slideHeight = 315; // px
	var defHeight = $('#wrap2').height();
	if(defHeight >= slideHeight){
		$('#wrap2').css('height' , slideHeight + 'px');
		$('#read-more2').append('<a href="#">More</a>');
		$('#read-more2 a').click(function(){
			var curHeight = $('#wrap2').height();
			if(curHeight == slideHeight){
				$('#wrap2').animate({
				  height: defHeight
				}, "normal");
				$('#read-more2 a').html('Less');
				$('#gradient2').fadeOut();
			}
			 else{
				$('#wrap2').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more2 a').html('More');
				$('#gradient2').fadeIn();
			}
			return false;
		});		
	}
});
</script>
</head>
<body>
 <form id="form1" runat="server">
  <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
  <div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%;"><table width="100%" border="0">
    <tr>
      <td height="65" valign="top">
       <asp:Image ID="imgJcrotate" AlternateText="Banner" ImageUrl="images/Jcrotate _banner.jpg" width="300" height="60" runat="server"/></td>
    </tr>
    <tr>
      <td height="60">Hi&nbsp; <asp:Label ID="lblName" runat="server" Font-Bold="true"></asp:Label>,<br />

Thank you for using JC Reverse Auction.<br />
Your details have been sent to the following vendors who will compete to give you 
the Best Deal. Alternatively, you can call the Vendors and negotiate.</td>
    </tr>
    <tr id="trCateRecords" runat="server" visible="false">
      <td style="border:1px #999 solid; padding:5px;">
        <table width="100%" border="0">
         <tr><td colspan="2">
              <h1><asp:Label ID="lblCategory" runat="server"></asp:Label></h1>
          </td></tr>
         <tr>
          <td>
          <div id="wrap">
          <div>
            <asp:DataList ID="DlCateRecords" runat="server" Width="100%" DataKeyField="id">
             <ItemTemplate>
              <table border="0" width="100%">
               <tr>
                  <td height="30" colspan="2" style="background:#EDF7FE">
                   <h2><asp:Label ID="lblCompName" runat="server" Text='<%#Eval("company_name")%>'></asp:Label></h2></td>
                </tr>
                <tr>
                  <td width="6%">
                   <asp:Image ID="imgcontact" AlternateText="contact" ImageUrl="images/conact.png" width="24" height="24" runat="server" />
                  </td>
                  <td width="94%" height="30">
                    <asp:Label ID="lblLandPhone" runat="server" Text='<%#Eval("landphno")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                  <asp:Image ID="imgMail" AlternateText="mail" ImageUrl="images/mail.png" width="24" height="24" runat="server" />
                 </td>
                  <td height="30">
                    <asp:Label ID="lblMail" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgWeb" AlternateText="website" ImageUrl="images/web.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblWebsite" runat="server" Text='<%#Eval("Website")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgHome" AlternateText="HomeNumber" ImageUrl="images/home.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("address")%>'></asp:Label>,
                    <asp:Label ID="lblVarea" runat="server" Text ='<%# Eval("area") %>' Visible="false"></asp:Label>,
                    <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>'></asp:Label>-
                    <asp:Label ID="lblPincode" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label>
                  </td>
                </tr>
               </table>
             </ItemTemplate>
            </asp:DataList>
            </div>
            <div id="gradient"></div>
            </div>
            <div id="read-more" align="right"></div>
          </td>
         </tr>
       </table>
       </td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr id="trCateRecords1" runat="server" visible="false">
       <td style="border:1px #999 solid; padding:5px;">
        <table width="100%" border="0">
         <tr><td colspan="2">
          <h1><asp:Label ID="lblCategory1" runat="server"></asp:Label></h1>
          </td></tr>
         <tr>
          <td>
          <div id="wrap1">
          <div>
            <asp:DataList ID="DlCateRecords1" runat="server" Width="100%" DataKeyField="id">
             <ItemTemplate>
              <table width="100%" border="0">
                <tr>
                  <td height="30" colspan="2" style="background:#EDF7FE">
                   <h2><asp:Label ID="lblCompName1" runat="server" Text='<%#Eval("company_name")%>'></asp:Label></h2></td>
                </tr>
                <tr>
                  <td width="6%">
                   <asp:Image ID="imgcontact" AlternateText="contactNo" ImageUrl="images/conact.png" width="24" height="24" runat="server" />
                  </td>
                  <td width="94%" height="30">
                    <asp:Label ID="lblLandPhone1" runat="server" Text='<%#Eval("landphno")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                  <asp:Image ID="imgMail" AlternateText="mailid" ImageUrl="images/mail.png" width="24" height="24" runat="server" />
                 </td>
                  <td height="30">
                    <asp:Label ID="lblMail1" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgWeb" AlternateText="imgwebsite" ImageUrl="images/web.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblWebsite1" runat="server" Text='<%#Eval("Website")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgHome" AlternateText="HomeNo" ImageUrl="images/home.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblAddress1" runat="server" Text='<%#Eval("address")%>'></asp:Label>,
                    <asp:Label ID="lblCity1" runat="server" Text='<%#Eval("City")%>'></asp:Label>-
                    <asp:Label ID="lblPincode1" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label>
                  </td>
                </tr>
                </table>
             </ItemTemplate>
            </asp:DataList>
            </div><div id="gradient1"></div>
            </div>
             <div id="read-more1" align="right"></div>
           </td>
         </tr>
     </table>
       </td>
    </tr>
    <tr>
     <td>&nbsp;</td>
    </tr>
     <tr id="trCateRecords2" runat="server" visible="false">
       <td style="border:1px #999 solid; padding:5px;">
        <table width="100%" border="0">
         <tr><td colspan="2">
          <h1><asp:Label ID="lblCategory2" runat="server"></asp:Label></h1>
          </td></tr>
         <tr>
          <td>
          <div id="wrap2"><div>
             <asp:DataList ID="DlCateRecords2" runat="server" Width="100%" DataKeyField="id">
             <ItemTemplate>
              <table width="100%" border="0">
               <tr>
                  <td height="30" colspan="2" style="background:#EDF7FE">
                   <h2><asp:Label ID="lblCompName2" runat="server" Text='<%#Eval("company_name")%>'></asp:Label></h2></td>
                </tr>
                <tr>
                  <td width="6%">
                   <asp:Image ID="imgcontact" AlternateText="CntactNo" ImageUrl="images/conact.png" width="24" height="24" runat="server" />
                  </td>
                  <td width="94%" height="30">
                    <asp:Label ID="lblLandPhone2" runat="server" Text='<%#Eval("landphno")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                  <asp:Image ID="imgMail" AlternateText="imgeMail" ImageUrl="images/mail.png" width="24" height="24" runat="server" />
                 </td>
                  <td height="30">
                    <asp:Label ID="lblMail2" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgWeb" AlternateText="imgWebsite" ImageUrl="images/web.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblWebsite2" runat="server" Text='<%#Eval("Website")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgHome" AlternateText="imgeHomeNo" ImageUrl="images/home.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblAddress2" runat="server" Text='<%#Eval("address")%>'></asp:Label>,
                   
                    <asp:Label ID="lblCity2" runat="server" Text='<%#Eval("City")%>'></asp:Label>-
                    <asp:Label ID="lblPincode2" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label>
                  </td>
                </tr>
                </table>
             </ItemTemplate>
            </asp:DataList>
            </div><div id="gradient2"></div></div>
            <div id="read-more2" align="right"></div>
           </td>
         </tr>
     </table>
        </td>
    </tr>

    <tr id="trCate" runat="server" visible="false">
       <td style="border:1px #999 solid; padding:5px;">
        <table width="100%" border="0">
         <tr><td colspan="2">
          <h1><asp:Label ID="Label1" runat="server"></asp:Label></h1>
          </td></tr>
         <tr>
          <td>
            <asp:DataList ID="DataList1" runat="server" Width="100%" DataKeyField="id">
             <ItemTemplate>
              <table width="100%" border="0">
               <tr>
                  <td height="30" colspan="2" style="background:#EDF7FE">
                   <h2><asp:Label ID="lblCompany" runat="server" Text='<%#Eval("company_name")%>'></asp:Label></h2></td>
                </tr>
                <tr>
                  <td width="6%">
                   <asp:Image ID="imgcontact" AlternateText="CntactNo" ImageUrl="images/conact.png" width="24" height="24" runat="server" />
                  </td>
                  <td width="94%" height="30">
                    <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("landphno")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                  <asp:Image ID="imgMail" AlternateText="imgeMail" ImageUrl="images/mail.png" width="24" height="24" runat="server" />
                 </td>
                  <td height="30">
                    <asp:Label ID="lblemail" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgWeb" AlternateText="imgWebsite" ImageUrl="images/web.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lblsite" runat="server" Text='<%#Eval("Website")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                   <asp:Image ID="imgHome" AlternateText="imgeHomeNo" ImageUrl="images/home.png" width="24" height="24" runat="server" />
                  </td>
                  <td height="30">
                    <asp:Label ID="lbladdrs" runat="server" Text='<%#Eval("address")%>'></asp:Label>,
                     <asp:Label ID="lblVarea" runat="server" Text ='<%# Eval("area") %>' Visible="false"></asp:Label>
                    <asp:Label ID="lblcatecity" runat="server" Text='<%#Eval("City")%>'></asp:Label>-
                    <asp:Label ID="lblcatePincode" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label>
                  </td>
                </tr>
                </table>
             </ItemTemplate>
            </asp:DataList>
           </td>
         </tr>
     </table>
        </td>
    </tr>
    <tr><td><strong>For your convenience, these details have been mailed to you and sent to you through SMS.</strong></td></tr><br />
  </table>
</div>
<div class="content_innerright">
   <asp:ImageButton ID="imgBtnBanner" AlternateText="RevBanner" ImageUrl="images/rev_banner.png" width="223" 
     PostBackUrl='<%# GetBannerUrl() %>' height="133" runat="server" />
</div>
</div>
<div class="content_midbootam" >
  <aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
   <aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>

<div align="center" style="padding-top:5px; " >
   <aa10:footer1 ID="footer1" runat="server" />
   <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
<!-- end of the content-->   
 </form>
</body>
</html>
