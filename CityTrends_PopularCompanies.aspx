<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CityTrends_PopularCompanies.aspx.cs" Inherits="CityTrends_PopularCompanies" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/City_trends_LeftContent.ascx" TagName="LeftContent" TagPrefix="Citytrends" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title id="pgtitle" runat="server"></title>
   <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
   <link href="css/style.css" rel="Stylesheet" type="text/css" />
   <link href="starrater.css" type="text/css" rel="Stylesheet" />

    <style type="text/css" media="all">
	@import 'css/styles.css';
    </style>
    <script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>
<script type="text/javascript">
$(function() {
$('#testRater');
});
</script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<!--begin of buttons-->
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
<div class="topmenu">
  <div id="main-nav">
	<%--<ul>
		<li class="active"><a href="Default.aspx">Home</a></li>
		   <li> <a href="CityTrends_PopBusinesses.aspx">Popular Businesses</a></li>
		   <li> <a href="CityTrends_PopularCompanies.aspx">Popular Companies</a>
	  </li>
   </ul>--%>
   <ul>
		<li class="active"><a href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server"><asp:Label ID="lblHome" Text="Home" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularBusinesses%>" runat="server"><asp:Label ID="lblBusiness" Text="Popular Businesses" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularCompanies%>" runat="server"><asp:Label ID="lblCompanies" Text="Popular Companies" runat="server"></asp:Label></a>
	  </li>
   </ul>
	<div class="clear-both">&nbsp;</div>
  </div>
</div>
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
   <Citytrends:LeftContent id="LeftContent" runat="server"></Citytrends:LeftContent>
</div>
<div class="content_innermid" style="width:79%;">
 <table width="800" border="0">
  <tr>
    <td align="center"><h1>Justcalluz <asp:Label ID="lblCity" runat="server"></asp:Label></h1></td>
 </tr>
  <tr>
    <td style="width:100%;">
    <div id="local_trends">
      <table width="100%" border="0">
        <tr>
         <td valign="top" style="width:100%;" align="center">
         <%--<table width="100%" border="0" id="tblcate" runat="server">
         <tr>
             <td align="center" width="100%" valign="top">--%>
              <asp:Label ID="lblpopCompanies" runat="server" Font-Names="Arial" Font-Bold="true" Font-Size="Medium">Popular Companies Rated & Reviewed by Users!</asp:Label>&nbsp;
           <%--</td>
          </tr>
          </table>--%>
         </td>
        </tr>
        <tr>
          <td colspan="3" valign="top" style="padding-left:10px; width:100%;">
           <asp:DataList ID="DlMainInfo" runat="server" Width="100%" 
                  onitemdatabound="DlMainInfo_ItemDataBound">
                 <ItemTemplate>
                    <table width="100%" border="0">
                       <tr id="trMovies" runat="server">
                        <td width="10%" rowspan="3" style="padding-bottom:20px;" id="tdlogo" runat="server" visible="false" align="center">
                           <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
                           <asp:Image  ID="imgReviewer" AlternateText="companyLogo" runat="server"  ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>' 
                                Width="70"  Height="68"/>
                        </td>
                          <td height="31" colspan="6" valign="top">
                                <%--<a href="sessionstore.aspx?id=<%#Eval("id")%>" style="text-decoration:none;"> --%>  
                                <a href='<%# GetUrl(Eval("id"))%>' style="text-decoration:none;" runat="server">                                            
                                 <%--<span >--%>
                                  <h3>
                                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("company_name") %>'></asp:Label>
                                   </h3> 
                                <%-- </span>--%> 
                                 <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>         
                        <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                            <asp:Label ID="Label8" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                </asp:Label>
                            </asp:Label>            
                        </asp:Label>&nbsp;
                          <span class="sub_menu" style="color:Black">  <asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings</span>                           
                                </a>
                           </td>
                           <td align="right" style="padding-right:3px;"><strong>Follow Us On : </strong></td>
                           <td width="13%">
                               <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="Image7" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="Image8" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="Image9" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                           </td>                                                  
                        </tr>
                        <tr>
                            <td colspan="6">
                               <%-- <asp:Label ID="lblListing" runat="server" Text='<%#Eval("listings")%>' ForeColor="Maroon" Visible="false"></asp:Label>--%>
                                <%--<asp:Label ID="lbldataId" runat="server" Text='<%#Eval("dataIds_lang")%>' ForeColor="Maroon" Visible="false"></asp:Label>--%>
                            </td>
                        </tr>
                         <tr>
                             <td width="3%"><asp:Image ID="Image10" AlternateText="calenderIcon" ImageUrl="images/icons/Calendar-icon.png" width="16" height="16" runat="server" /></td>
                              <td width="13%"><asp:Label ID="Label3" runat="server" Text='<%#Eval("postdate") %>' Font-Size="Small"></asp:Label></td>
                              <td width="2%"><asp:Image ID="Image11" AlternateText="administratorIcon" ImageUrl="images/icons/Administrator-icon.png" width="16" height="16" runat="server" /></td>
                              <td colspan="2"><asp:Label ID="Label4" runat="server" Text='<%#Eval("UserLoginId") %>' Font-Size="Small"></asp:Label></td>
                              <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="67"><p style="text-align:justify;">
                                 <asp:Label ID="Label6" runat="server" Text='<%#Eval("company_profile")%>' Font-Bold="false"></asp:Label></p>
                            </td>
                       </tr>
                       <tr>
                            <td colspan="7">
                             <p style="text-align:justify;">
                                 <asp:Label ID="Label2" runat="server" Text='<%#Eval("Area")%>' Font-Bold="false"></asp:Label>,
                                 <asp:Label ID="Label5" runat="server" Text='<%#Eval("City")%>' Font-Bold="false"></asp:Label>,
                                 <asp:Label ID="Label7" runat="server" Text='<%#Eval("State")%>' Font-Bold="false"></asp:Label>
                             </p>
                            </td>
                       </tr>
                    </table><hr />
               </ItemTemplate>
             </asp:DataList>
          </td>
        </tr>
        <tr>
           <td align="right">
               <asp:Button ID="cmdPrev" runat="server" Text=" << NewerPosts " OnClick="cmdPrev_Click"></asp:Button>
         
              <asp:Button ID="cmdNext" runat="server" Text=" OlderPosts >> " OnClick="cmdNext_Click"></asp:Button>
           </td>
        </tr>
      </table>
    </div>
   </td>
  </tr>
 <%-- <tr>
    <td height="30">&nbsp;</td>
  </tr>
  <tr>
    <td align="center" >&nbsp;</td>
  </tr>--%>
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
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>
    </form>
</body>
</html>
