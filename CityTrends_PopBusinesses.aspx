<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CityTrends_PopBusinesses.aspx.cs" Inherits="CityTrends_PopBusinesses" %>
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
		<li class="active"><a href="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><asp:Label ID="lblHome" Text="Home" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularBusinesses %>" runat="server"><asp:Label ID="lblBusiness" Text="Popular Businesses" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularCompanies %>" runat="server"><asp:Label ID="lblCompanies" Text="Popular Companies" runat="server"></asp:Label></a>
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
    <td align="center" style="padding-left:10px;"><h1>Justcalluz <asp:Label ID="lblCity" runat="server"></asp:Label></h1></td>
 </tr>
  <tr>
    <td>
    <div id="local_trends">
      <table width="100%" border="0">
        <tr>
         <td valign="top" style="width:100%;">
         <table width="100%" border="0" id="tblcate" runat="server">
         <tr>
             <td align="center" width="100%" valign="top" style="padding-left:10px;">
              <asp:Label ID="lblpopBusinesses" runat="server" Font-Names="Arial" Font-Bold="true" Font-Size="Medium">Popular Businesses</asp:Label>&nbsp;
             </td>
          </tr>
          </table>
         </td>
        </tr>
       <tr>
         <td colspan="3" valign="top" style="padding-left:10px;">
           <asp:DataList ID="DlBusinesses" runat="server" Width="100%">
                 <ItemTemplate>
                   <table width="100%" border="0px">
                     <tr id="trTitle">
                       <td height="31" colspan="4">
                       <span>
                         <h3>
                           <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("title")%>' ></asp:Label>
                            &nbsp;-&nbsp;
                           <asp:Label ID="lblCityName" runat="server" Text='<%#Eval("cname") %>' ></asp:Label>
                         </h3></span>                                                    
                       </td>
                      <td align="right"><strong>Follow Us On : </strong></td>
                      <td width="13%"> 
                         <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="FacebookIcon" AlternateText="facebook" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                         <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="imgLkdIn" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                         <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="TwitterIcon" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                      </td>  
                     </tr>
                     <tr id="trDesc">
                        <td colspan="7">
                         <p style="text-align:justify;">
                           <asp:Label ID="lblCDescription" runat="server" Text='<%#Eval("city_desc") %>' Font-Bold="false"></asp:Label>                 
                        </p>  
                        </td>
                    </tr>
                     <tr id="trSTitle">
                        <td height="31" colspan="4">
                        <span>
                          <h2>
                            <asp:Label ID="lblSTitle" runat="server" Text='<%#Eval("subTitle") %>'></asp:Label>
                         </h2> 
                         </span>                
                        </td>
                    </tr>
                      <tr id="tr1">
                        <td colspan="7">
                         <p style="text-align:justify;">
                           <asp:Label ID="Label2" runat="server" Text='<%#Eval("subTitle1") %>' Font-Bold="false"></asp:Label>                 
                        </p>  
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                          <asp:Label ID="Label1" runat="server" Text="You will find top businesses voted & rated by consumers on" Font-Bold="false"></asp:Label>&nbsp;
                          <%--<asp:HyperLink ID="lnkBusiness" Text='<%# "Businesses in " + Eval("cname") %>' runat="server" ForeColor="Red" NavigateUrl='<%# string.Format("Default.aspx?city="+Eval("cname").ToString()) %>'></asp:HyperLink>--%>
                          <asp:HyperLink ID="lnkBusiness" Text='<%# "Businesses in " + Eval("cname") %>' runat="server" ForeColor="Red" NavigateUrl='<%# GetUrlHome(Eval("cname")) %>'></asp:HyperLink>
                        </td>
                   </tr>
               </table>
             </ItemTemplate>
          </asp:DataList>
        </td>
       </tr>
       </table>
    </div>
   </td>
  </tr>
  <tr>
    <td height="30">&nbsp;</td>
  </tr>
  <tr>
    <td align="center" >&nbsp;</td>
  </tr>
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
