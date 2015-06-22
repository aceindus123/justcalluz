<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lifestyle1.aspx.cs" Inherits="Lifestyle1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>

<link href="includes/style.css" rel="Stylesheet" type="text/css" />
<link href="includes/red_style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
<script type="text/javascript">
$(function(){
	var slideHeight = 250; // px
	var defHeight = $('#wrap').height();
	if(defHeight >= slideHeight){
		$('#wrap').css('height' , slideHeight + 'px');
		$('#read-more').append('<a href="#">Read More</a>');
		$('#read-more a').click(function(){
			var curHeight = $('#wrap').height();
			if(curHeight == slideHeight){
				$('#wrap').animate({
				  height: defHeight
				}, "normal");
				$('#read-more a').html('Less');
				$('#gradient').fadeOut();
			}else{
				$('#wrap').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more a').html('Read More');
				$('#gradient').fadeIn();
			}
			return false;
		});		
	}
});
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="layout">
<div class="signin">
  <table width="100%" border="0">
    <tr>
      <td width="77%" style="padding:10">&nbsp;</td>
      <td width="3%" align="center"><img src="images/icons/home-icon.png" width="24" height="24" /></td>
      <td width="4%" class="side_menu"><a href="#">Home</a></td>
      <td width="3%" align="center"><img src="images/icons/login.png" width="24" height="24" /></td>
      <td width="4%" class="side_menu" ><a href="#">Login</a></td>
      <td width="3%" align="center"><img src="images/icons/sign-icon.png" width="24" height="24" /></td>
      <td width="6%" class="side_menu" ><a href="#">Sign Up</a></td>
    </tr>
  </table>
</div>
<div class="logo" align="center"><a href="index.html"><img src="images/logo1.jpg" width="390" height="120" /></a></div>
<div class="topmenu" align="center"><table width="80%" border="0">
  <tr>
    <td width="9%" align="left"><a href="#">Builders</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="11%" align="left"><a href="#">Computer</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="11%" align="left"><a href="#">Education</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="9%" align="left"><a href="#">Travel</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="9%" align="left"><a href="#">Hotels</a></td>
    <td width="3%"><strong>|</strong></td>
    <td width="6%" align="left"><a href="#">Jobs</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="8%" align="left"><a href="#">Events</a></td>
    <td width="4%"><strong>|</strong></td>
    <td width="10%" align="left"><a href="#">Discounts</a></td>
  </tr>
</table></div>
<div class="search" align="center">
  <table width="98%" border="0">
    <tr>
      <td width="31" height="32">&nbsp;</td>
      <td width="189" align="left">Select City</td>
      <td width="107" align="left">Search for</td>
      <td width="300" align="left"><input type="radio" />&nbsp;       Company Name&nbsp;&nbsp;&nbsp;
        <input type="radio" /> &nbsp;Category</td>
      <td width="13" align="center">&nbsp;</td>
      <td width="280" align="left">Where in	Hyderabad</td>
    </tr>
    <tr>
      <td colspan="6" style="background:url(images/rectanglebox.jpg) top no-repeat;  width:935px; height:49px"><table width="100%" border="0">
  <tr>
    <td width="2%" height="48">&nbsp;</td>
    <td width="20%"><input  type="text" style="width:180px; height:20px" /></td>
    <td width="2%">&nbsp;</td>
    <td width="43%"><input  type="text" style="width:400px; height:20px" /></td>
    <td width="2%">&nbsp;</td>
    <td width="20%"><input  type="text" style="width:180px; height:20px" /></td>
    <td width="1%">&nbsp;</td>
    <td width="9%"><img src="images/search.jpg" width="62" height="25" /></td>
    <td width="1%">&nbsp;</td>
  </tr>
</table>
</td>
      </tr>
  </table>
</div>
<!-- start the Content-->
<div class="content">
<div class="content_left" style="width:75%">
<table width="100%" border="0">
  
  <tr>
    <td><table width="100%" border="0">
  <tr>
    <td width="16%" align="center"><img  src="images/jewellery.gif" width="100" height="100" /></td>
    <td width="16%" align="center"><img src="images/car.gif" width="100" height="100" /></td>
    <td width="17%" align="center"><img src="images/luggage.gif" width="100" height="100" /></td>
    <td width="17%" align="center"><img src="images/wrist_watch.gif" width="100" height="100" /></td>
    <td width="18%" align="center"><img src="images/fashion_designer_stores.gif" width="100" height="100" /></td>
    <td width="16%" align="center"><img src="images/sunglass.gif" width="100" height="100" /></td>
  </tr>
  <tr>
    <td align="center" class="side_menu"><a href="#">Jewellery</a></td>
    <td align="center" class="side_menu"><a href="#">Car</a></td>
    <td align="center" class="side_menu"><a href="#">Luggage</a></td>
    <td align="center" class="side_menu"><a href="#">Wrist Watch</a></td>
    <td align="center" class="side_menu"><a href="#">Fashion Designer Stores</a></td>
    <td align="center" class="side_menu"><a href="#">Sunglass</a></td>
  </tr>
</table>
</td>
  </tr>
  <tr><td>
 <table id="subrelated" runat="server" visible="false">
  <tr><td class="sub_menu" height="30">
  Select any option from the below list
  <br />
  <br />
  <asp:DataList ID="dlsubcat" DataKeyField="SubCategeory" runat="server" Width="100%" Height="100%"
         RepeatColumns="1" CellSpacing="0">
         
          <ItemTemplate>
                        <table border="0">
                            <tr>
                                <td style="width:100%" colspan="2">
                                    <asp:LinkButton ID="linkcor" runat="server" CommandArgument='<%#Eval("SubCategeory") %>' Text='<%#Eval("SubCategeory") %>' PostBackUrl='<%# string.Format("Lifestylehome.aspx?cat=" + Eval("SubCategeory").ToString())%>'  ForeColor="#003366" Font-Names="Arial" CommandName="select"></asp:LinkButton>                 
                                </td>
                            </tr>
                        </table>    
                                           
                        </ItemTemplate>                         
                   </asp:DataList>
  </td></tr>
  </table>
 </td></tr>
</table>
 </div>
 <div class="content_right" style="width:20%">
  <table width="100%" border="0">
    <tr>
      <td  align="center"><img src="images/image_gallery.gif" width="160" height="600" /></td>
    </tr>
    <tr>
      <td align="center" style="padding-top:8px;"><img src="images/sample.gif" width="160" height="600" /></td>
    </tr>
    <tr>
      <td align="center" style="padding-top:8px;">&nbsp;</td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ><hr/></td>
  </tr>
</table>
</div>
<div class="content_bootam_center"><table width="100%" border="0">
  <tr>
    <td style="padding:8px;"><table width="100%" border="0">
  <tr>
    <td width="15%" class="mid_menu" height="30">About us</td>
    <td width="13%" class="mid_menu">Media Speak</td>
    <td width="14%" class="mid_menu">Popular Cities</td>
    <td width="12%">&nbsp;</td>
    <td width="14%" class="mid_menu">Sitemap</td>
    <td width="18%">&nbsp;</td>
    <td width="14%">&nbsp;</td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Overview </a></td>
    <td class="bottam_menu" ><a href="#">English</a></td>
    <td class="bottam_menu"><a href="#">Ahmedabad</a></td>
    <td class="bottam_menu" ><a href="#">Kolkata</a></td>
    <td class="bottam_menu"><a href="#">Home</a></td>
    <td class="bottam_menu"><a href="#">Amitabh Bachchan</a></td>
    <td class="bottam_menu"><a href="#">Terms of Use</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Ads</a></td>
    <td class="bottam_menu" ><a href="#">Hindi</a></td>
    <td class="bottam_menu"><a href="#">Bangalore</a></td>
    <td class="bottam_menu" ><a href="#">Mumbai</a></td>
    <td class="bottam_menu"><a href="#">Movies</a></td>
    <td class="bottam_menu"><a href="#">JD On Mobile</a></td>
    <td class="bottam_menu"><a href="#">Privacy Policy</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Testimonials</a></td>
    <td class="bottam_menu" ><a href="#">Kannada</a></td>
    <td class="bottam_menu"><a href="#">Chandigarh</a></td>
    <td class="bottam_menu" ><a href="#">Mysore</a></td>
    <td class="bottam_menu"><a href="#">Events</a></td>
    <td class="bottam_menu"><a href="#">Free Listing</a></td>
    <td class="bottam_menu"> <a href="#">Media</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Share Your Views</a></td>
    <td class="bottam_menu" ><a href="#">Tamil </a></td>
    <td class="bottam_menu"><a href="#">Chennai</a></td>
    <td class="bottam_menu" ><a href="#">Nagpur</a></td>
    <td class="bottam_menu"><a href="#">Restaurants</a></td>
    <td class="bottam_menu"><a href="#">Advertise</a></td>
    <td class="bottam_menu"><a href="#"> Reseller</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">About Justdial</a></td>
    <td class="bottam_menu" ><a href="#">Bengali</a></td>
    <td class="bottam_menu"><a href="#">Coimbatore</a></td>
    <td class="bottam_menu" ><a href="#">Nashik</a></td>
    <td class="bottam_menu"><a href="#">Hotels</a></td>
    <td class="bottam_menu"><a href="#">Tag Your Friend</a></td>
    <td class="bottam_menu"><a href="#">White Pages</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Success Stories</a></td>
    <td class="bottam_menu" ><a href="#">Gujarati</a></td>
    <td class="bottam_menu"><a href="#">Delhi / Ncr</a></td>
    <td class="bottam_menu" ><a href="#">Pune</a></td>
    <td class="bottam_menu"><a href="#">Lifestyle</a></td>
    <td class="bottam_menu"><a href="#">Jd Reverse Auction</a></td>
    <td class="bottam_menu"><a href="#">City Trends</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Careers</a></td>
    <td class="bottam_menu" ><a href="#">Marathi</a></td>
    <td class="bottam_menu"><a href="#">Ernakulam</a></td>
    <td class="bottam_menu" ><a href="#">Surat</a></td>
    <td class="bottam_menu"><a href="#">JD Trends</a></td>
    <td class="bottam_menu"><a href="#">Search Tips</a></td>
   <td width="14%" class="mid_menu">Follow us</td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Contact us</a></td>
    <td class="bottam_menu" ><a href="#">Telugu</a></td>
    <td class="bottam_menu"><a href="#">Goa</a></td>
    <td class="bottam_menu" ><a href="#">Vadodara</a></td>
    <td class="bottam_menu"><a href="#">69999999</a></td>
    <td class="bottam_menu"><a href="#">Search Not Found</a></td>
    <td class="bottam_menu"> <a href="#"><img src="images/Twitter-icon.png" width="16" height="16" />&nbsp;Twitter</a></td>
  </tr>
  <tr>
    <td class="bottam_menu" ><a href="#">Customer Care</a></td>
    <td class="bottam_menu" ><a href="#">Punjabi</a></td>
    <td class="bottam_menu"><a href="#">Hyderabad</a></td>
    <td class="bottam_menu" ><a href="#">Vizag</a></td>
    <td class="bottam_menu"><a href="#">08888888888</a></td>
    <td class="bottam_menu"><a href="#">Disclaimer</a></td>
    <td class="bottam_menu"> <a href="#"><img src="images/facebook.png" width="16" height="16" />&nbsp;Facebook</a></td>
  </tr>
</table>
</td>
  </tr>
</table>
</div>

<div class="content_bootam" align="center"><img src="images/text1.jpg" width="236" height="155" /></div>
<div class="footer" align="center" style="padding-top:5px; " >
  <table width="100%" border="0"  bgcolor="#002F5E">
    <tr>
      <td width="6%" align="center" ><a href="#"><font color="#FFFFFF">Home</font></a></td>
      <td width="1%" ><font color="#FFFFFF">|</font></td>
      <td width="7%" align="center"><a href="#"><font color="#FFFFFF">About Us</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><a href="#"><font color="#FFFFFF">Disclaimer</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="7%" align="center"><a href="#"><font color="#FFFFFF">Feedback</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="10%" align="center"><a href="#"><font color="#FFFFFF">Privacy Policy</font></a></td
      >
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><a href="#"><font color="#FFFFFF">Education</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="5%" align="center"><a href="#"><font color="#FFFFFF">Travel</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><a href="#"><font color="#FFFFFF">Computer</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="7%" align="center"><a href="#"><font color="#FFFFFF">Builders</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><a href="#"><font color="#FFFFFF">Discounts</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="5%" align="center"><a href="#"><font color="#FFFFFF">Events</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="10%" align="center"><a href="#"><font color="#FFFFFF">Contact Us</font></a></td>
    </tr>
  </table>
  <table width="100%" border="0" >
    <tr>
      <td align="center" style="padding-top:5px;">All rights reserved © 2012   Justcalluz.</td>
    </tr>
  </table>
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
