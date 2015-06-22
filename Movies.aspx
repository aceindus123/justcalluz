<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Movies.aspx.cs" Inherits="Movies" %>
<%@ Register Src="usercontrols/moviesearch.ascx" TagName="movie_search" TagPrefix="movsrch" %>
<%@ Register Src="usercontrols/right_Movie.ascx" TagName="rightmov" TagPrefix="ritemov" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Movie Masti</title>
<%--<link href="css/style.css" rel="stylesheet" type="text/css" />
--%>
<link href="includes/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="starrater.css" rel="Stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>
<script type="text/javascript">
$(function() {
$('#testRater');
});
</script>
<script type="text/javascript">function postbackFromJS(sender, e) 
{
var postBack = new Sys.Preview.PostBackAction();
postBack.set_target(sender);
postBack.set_eventArgument(e);
postBack.performAction();
}      
 </script>
 <script src="js/swfobject_modified(movie).js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
</div>
<%--<div class="signin">
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
</div>--%>
<%--<div class="logo" align="center" style="height:auto"></div>
--%>
<div class="logo" align="center" style="height:auto">
<table width="984" border="0" style=" background:url(images/justcalluz-movie-header-banner12.png) no-repeat;">
  <tr>
    <td height="216" align="center"><table width="612" border="0">
      <tr>
        <td height="100">&nbsp;</td>
      </tr>
      <tr>
        <td width="606" height="101"><object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="984" height="95">
          <param name="movie" value="images/justcalluz-movie-Add3-ani.swf" />
          <param name="quality" value="high" />
          <param name="wmode" value="opaque" />
          <param name="swfversion" value="6.0.65.0" />
          <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
          <param name="expressinstall" value="Scripts/expressInstall.swf" />
          <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
          <!--[if !IE]>-->
          <object type="application/x-shockwave-flash" data="images/justcalluz-movie-Add3-ani.swf" width="984" height="95">
            <!--<![endif]-->
            <param name="quality" value="high" />
            <param name="wmode" value="opaque" />
            <param name="swfversion" value="6.0.65.0" />
            <param name="expressinstall" value="Scripts/expressInstall.swf" />
            <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
            <div>
              <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
              <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" width="112" height="33" /></a></p>
            </div>
            <!--[if !IE]>-->
          </object>
          <!--<![endif]-->
        </object></td>
      </tr>
    </table></td>
  </tr>
</table>
<%--<a href="Default.aspx"><img src="images/real1.png" width="960" height="209" /></a>--%>
</div>
<div class="search" align="center" style="padding-top:10px; height:auto">
<movsrch:movie_search ID="searchmovie" runat="server" />
  
</div>
<!-- staart the Content-->
<div>
<div class="content_left" style="width:75%; padding-left:none;">

<table border="0" width="760px">
<tr>
<td colspan="2">
<asp:DataList ID="dlMovies" DataKeyField="mid" runat="server" Width="100%" 
                        BorderColor="Brown" BorderWidth="1px" OnItemDataBound="dlmovies_ItemDataBound"
    style="margin-left: 0px">
         
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%" border="0px" id="Movie">
                            <tr style="background-color:#D9F2FF;">
                            <td width="74%" class="movie" style="font-weight:none;">                                                       
                            <asp:Label ID="Movie_name" runat="server" Text='<%#Eval("Movie_Name")%>' Font-Size="17px"></asp:Label>  
                                &nbsp;<span style="font-size:17px;">(<asp:Label ID="Movie_Language" runat="server" Text='<%#Eval("Movie_Language")%>'></asp:Label> 
                                &nbsp;Movie)&nbsp;
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Certify")%>'></asp:Label><asp:Label ID="mcity" runat="server" Text='<%#Eval("City")%>' Visible="false"></asp:Label>  
                            </span>                        
                            </td>
                            <td width="26%" align="left"><asp:ImageButton ID="imgsendmail" AlternateText="SendEmailButton" runat="server" CommandArgument='<%#Eval("Movie_Name") + "," + Eval("Movie_Language")%>' ImageUrl="../images/save02.jpg"  OnCommand="imgsendmail" /></td>
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                            </tr>
                            <tr>
        <td style="border-bottom:1px solid #666;"><table width="100%" border="0" height="30">
  <tr>
    <td class="sub_menu">Rating:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
                                                <asp:Label ID="Label5" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                                    <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                                    </asp:Label>
                                                </asp:Label>            
                                            </asp:Label> </td>
    <td>&nbsp;</td>
  </tr>
</table>
</td>
      </tr>
       <tr>
        <td style="border-bottom:1px solid #666;" colspan="3"><table width="100%" border="0" height="30">
  <tr>
    <td class="select_menu">
     <%--<asp:HyperLink ID="ratemovie" runat="server" Text="Rate this movie" NavigateUrl='<%#String.Format("Postreview1.aspx?mname={0}&mlang={1}",Eval("Movie_Name"),Eval("Movie_Language"))%>'></asp:HyperLink>--%>
     <asp:HyperLink ID="ratemovie" runat="server" Text="Rate this movie" NavigateUrl='<%# GetRatingUrl(Eval("Movie_Name"),Eval("Movie_Language"))%>'></asp:HyperLink>
        &nbsp; | &nbsp;
    <%--<asp:HyperLink ID="readreview" runat="server" Text="Read Review" NavigateUrl='<%# string.Format("Movie_ReadReviews.aspx?mname={0}&mlang={1}&mcity={2}",Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>'></asp:HyperLink>--%>
    <asp:HyperLink ID="readreview" runat="server" Text="Read Review" NavigateUrl='<%# GetMReviewUrl(Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>'></asp:HyperLink>
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table></td>
      </tr>
                            <tr>
                            <td style="padding-left:5px;border-bottom:1px solid #666;" colspan="3">
                            <asp:DataList ID="dlMovieInfo" runat="server" onitemdatabound="dlMovieInfo_ItemDataBound" DataSource='<%# getHalls(Convert.ToString(Eval("Movie_Name")),Convert.ToString(Eval("Movie_Language"))) %>' Width="100%" >
                                <EditItemStyle ForeColor="#CC3300" />
                                <AlternatingItemStyle ForeColor="#CC3300" />
                                <SelectedItemStyle ForeColor="#CC3300" />
                                <ItemTemplate>      
                                <table border="0px" width="100%" style="border-bottom-width:thin; border-bottom-color:Gray;">
                                    <tr>
                                        <td style="line-height:2;"><span class="mid_menu">
                                             <asp:Button ID="lnkBtnHallName" runat="server" Font-Size="13px" Text='<%#Eval("CinemaHall_Name")%>' Font-Underline="true" 
                                             CommandArgument='<%#Eval("CinemaHall_Name") + "," + Eval("HallId")%>' OnCommand="lnkGoHallInfo" BorderStyle="None" BackColor="White" CssClass="pointer" />                                             
                                             &nbsp;                                             
                                            <asp:Label ID="lblURL" runat="server" Text='<%#Eval("URL")%>' Visible="false"></asp:Label>
                                            <%--<img  src="images/rat.png" width="60" height="11" />--%>
                                            <asp:Label ID="lblHallId" runat="server" Text='<%#Eval("HallId")%>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblHeading" runat="server" Font-Size="Large" ForeColor="#C910C9"></asp:Label>
                                            <%--(<asp:Label ID="lblrating" runat="server"></asp:Label>) --%>
                                            <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
                                                <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                                    <asp:Label ID="testSpan1" runat="server" CssClass="ui-rater-starsOn">
                                                    </asp:Label>
                                                </asp:Label>            
                                            </asp:Label>                                                                                      
                           
                                        </span></td>  
                                          <td width="10%" align=""><asp:ImageButton ID="imgmail" AlternateText="sms_emailButton" runat="server" ImageUrl="images/sms_email.png" CommandArgument='<%#Eval("CinemaHall_Name") + "," + Eval("HallId")%>' OnCommand="lnkGoHallInfo"/></td>                                    
                                    </tr>
                                    <tr>
                                        <td width="90%"><span class="list_data" style=" padding-right:10px; font: Georgia, 'Times New Roman', Times, serif">
                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Timings")%>' Font-Size="12px"></asp:Label> </span>
                                            &nbsp;
                                         <span class="list_data" style=" padding-right:10px;"> <span style="padding-top:10px;"></span></span>
                                         <asp:ImageButton ID="lnkBtnURL" AlternateText="buyTicketButton" runat="server" PostBackUrl='<%#Eval("URL") %>' ImageUrl="images/buy_ticket.png" Visible="false"></asp:ImageButton>
                                            
                                        </td>
                                        <td align="center"><asp:Label ID="lblstatus" runat="server" Text='<%#Eval("Movie_Type")%>' Font-Names="Times New Roman"></asp:Label></td>
                                    </tr>
                                </table>                                                                        
                                </ItemTemplate>
                            </asp:DataList>
                             </td>
                            </tr>
                            </table>
                            
                        </ItemTemplate>                        
                    </asp:DataList>
</td>
</tr>
<tr>
<td>
<asp:DataList ID="dlsearchmovies" runat="server" Width="100%" 
                        BorderColor="Brown" BorderWidth="1px"
    style="margin-left: 0px" >
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%" border="0">
                            <tr style="background-color:#D9F2FF;">
                            <td width="74%" class="movie" style="font-weight:none;">                                                       
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Movie_Name")%>' Font-Size="17px"></asp:Label>  
                                &nbsp;<span style="font-size:17px;">(<asp:Label ID="Label2" runat="server" Text='<%#Eval("Movie_Language")%>'></asp:Label> 
                                &nbsp;Movie)&nbsp;
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Movie_Type")%>'></asp:Label>  
                            </span>                        
                            </td>
                            <td width="26%" align="left"><asp:ImageButton ID="imgsend" AlternateText="emailButton" runat="server" CommandArgument='<%#Eval("Movie_Name") + "," + Eval("Movie_Language")%>' ImageUrl="images/save1.png"  OnCommand="imgsendmail" /></td>
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                            </tr>
                            <tr>
        <td style="border-bottom:1px solid #666;"><table width="100%" border="0" height="30">
   <tr><td>
        <label for="rating">Overall Ratings (<asp:Label ID="lblrating" runat="server" Text="0"></asp:Label>
        )</label> &nbsp;&nbsp;&nbsp;&nbsp;       
        <span class="ui-rater">
        <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan"></span></span>
        <span class="ui-rater-rating" id="avgrating" runat="server"></span>&nbsp;<span class="ui-rater-rateCount" id="userscount" runat="server"></span>
        </span>
    </td></tr>
</table>
</td>
      </tr>
       <tr>
        <td style="border-bottom:1px solid #666;"><table width="100%" border="0" height="30">
  <tr>
    <td class="select_menu"><a href="#">Rate this movie</a>&nbsp; | &nbsp;<a href="#">Read Review</a></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table></td>
      </tr>
                            <tr>
                            <td style="padding-left:5px;border-bottom:1px solid #666;" colspan="2">
                            <asp:DataList ID="dlMovieInfo" runat="server" onitemdatabound="dlMovieInfo_ItemDataBound" DataSource='<%# getHalls(Convert.ToString(Eval("Movie_Name")),Convert.ToString(Eval("Movie_Language"))) %>' Width="100%" >
                                <EditItemStyle ForeColor="#CC3300" />
                                <AlternatingItemStyle ForeColor="#CC3300" />
                                <SelectedItemStyle ForeColor="#CC3300" />
                                <ItemTemplate>      
                                <table border="0px" width="100%" style="border-bottom-width:thin; border-bottom-color:Gray;">
                                    <tr>
                                        <td style="line-height:2;"><span class="mid_menu">
                                             <asp:Button ID="lnkBtnHallName" runat="server" Font-Size="13px" Text='<%#Eval("CinemaHall_Name")%>' Font-Underline="true" 
                                                CommandArgument='<%#Eval("CinemaHall_Name") + "," + Eval("HallId")%>' OnCommand="lnkGoHallInfo" BorderStyle="None" BackColor="White" />                                            
                                             &nbsp;                                             
                                            <asp:Label ID="lblURL" runat="server" Text='<%#Eval("URL")%>' Visible="false"></asp:Label>
                                            <img  src="images/rat.png" alt="RatingImage" width="60" height="11" />
                                            <asp:Label ID="lblHallId" runat="server" Text='<%#Eval("HallId")%>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblHeading" runat="server" Font-Size="Large" ForeColor="#C910C9"></asp:Label>
                                            <%--(<asp:Label ID="lblrating" runat="server"></asp:Label>) --%>
                                            <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
                                                <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                                    <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                                    </asp:Label>
                                                </asp:Label>            
                                            </asp:Label>                                                                                      
                           
                                        </span></td>  
                                          <td width="10%" align=""><input type="image" src="images/sms_email.png" width="68" height="26" /></td>                                    
                                    </tr>
                                    <tr>
                                        <td width="90%"><span class="list_data" style=" padding-right:10px; font: Georgia, 'Times New Roman', Times, serif">
                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Timings")%>' Font-Size="12px"></asp:Label> </span>
                                            &nbsp;
                                         <span class="list_data" style=" padding-right:10px;"> <span style="padding-top:10px;"></span></span><asp:ImageButton ID="lnkBtnURL" runat="server" ImageUrl="images/buy_ticket.png" Text="Buy Tickets" PostBackUrl='<%#Eval("URL") %>' Visible="false" />
                                            
                                        </td>
                                    </tr>
                                </table>                                                                        
                                </ItemTemplate>
                            </asp:DataList>
                             </td>
                            </tr>
                            </table>
                            
                        </ItemTemplate>                        
                    </asp:DataList>
                    
</td>
</tr>
<tr><td>
<asp:Label ID="lblmsg" runat="server" Text="Sorry ! Matching data not found , Try again" Font-Bold="true" Font-Size="Medium" ForeColor="Maroon"></asp:Label>
</td></tr>
<tr><td>&nbsp;<input id="btndummy" runat="server" type="button" style="display:none;" /></td></tr>
</table>
<cc1:ModalPopupExtender ID="modpopupmail" runat="server" TargetControlID="btndummy" BackgroundCssClass="modalBackground" 
          OkControlID="imgcancel"
        DropShadow="false" PopupControlID="pnlmail"></cc1:ModalPopupExtender>
<asp:Panel ID="pnlmail" runat="server" Width="350px">
 <div class="dilogbox">
<table width="350px">
<tr>
<td colspan="3" align="center" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">&nbsp; Get Information by sms/email 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton AlternateText="sms/emailButton" ID="imgcancel" runat="server" ImageUrl="images/panel/cencel.png" /></td>
</tr>
<%--<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>--%>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td align="right"><asp:Label ID="lblname" runat="server" 
   Font-Names="Arial" Text="Name"></asp:Label></td>
<td><strong>&nbsp;:&nbsp;</strong></td>
<td><asp:TextBox ID="txtname" runat="server" Width="160px" Height="25px"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="please enter your name" ControlToValidate="txtname"  
                            ValidationGroup="share">*</asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td align="right">
 <asp:Label ID="lblmobile" runat="server" 
                   Font-Names="Arial" Text="Mobile no"></asp:Label>
</td>
<td><strong>&nbsp;:&nbsp;</strong></td>
<td><asp:TextBox ID="txtmob" runat="server" Width="160px" Height="25px" MaxLength="11"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="\d{11}" ValidationGroup="share">*</asp:RegularExpressionValidator>
          <asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
                            MaximumValue="1" MinimumValue="0" 
          ValidationGroup="share">*</asp:RangeValidator>
          
</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td align="right"><asp:Label ID="lblmail" runat="server"
    Font-Names="Arial" Text="Email Id"></asp:Label>
</td>
<td><strong>&nbsp;:&nbsp;</strong></td>
<td><asp:TextBox ID="txtmail" runat="server" Width="160px" Height="25px"></asp:TextBox>
 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ErrorMessage="Incorrect Format of email address" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="share" ControlToValidate="txtmail" >*</asp:RegularExpressionValidator>
          <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
          ValidationGroup="share" ShowMessageBox="True" ShowSummary="False" />
</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>

</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>

</tr>
<tr>
<td colspan="3" align="right" height="41" style="padding-right:5px;">
<asp:ImageButton ID="imggo" runat="server" AlternateText="GoButton" ImageUrl="images/dialog_buttan.png" onclick="imggo_Click" ValidationGroup="share" /></td>
</tr>
</table>
</div>
</asp:Panel>
 </div>
<div class="content_right" style="width:23%; padding:0px;">
  <ritemov:rightmov ID="right_Movie" runat="server" />
</div>
</div>

<script type="text/javascript">

//swfobject.registerObject("FlashID");
////-->
</script>
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
    </form>
</body>
</html>
