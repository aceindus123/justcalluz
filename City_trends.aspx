<%@ Page Language="C#" AutoEventWireup="true" CodeFile="City_trends.aspx.cs" Inherits="City_trends1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/City_trends_LeftContent.ascx" TagName="LeftContent" TagPrefix="Citytrends" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title id="pgtitle" runat="server"></title>
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<style type="text/css" media="all">
	@import 'css/styles.css';
</style> 
</head>
<body>
 <form id="form1" runat="server">
  <asp:ScriptManager ID="ScriptManager1" runat="server">
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
<div class="topmenu">
  <div id="main-nav">
	<ul>
		<li class="active"><a href="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><asp:Label ID="lblHome" Text="Home" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularBusinesses %>" runat="server"><asp:Label ID="lblBusiness" Text="Popular Businesses" runat="server"></asp:Label></a></li>
		   <li> <a href="<%$RouteUrl:RouteName=CityTrends_PopularCompanies %>" runat="server"><asp:Label ID="lblCompanies" Text="Popular Companies" runat="server"></asp:Label></a>
	  </li>
   </ul>
	<div class="clear-both">&nbsp;</div>
  </div>
</div>
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
   <Citytrends:LeftContent id="LeftContent" runat="server"></Citytrends:LeftContent>
</div>
<div class="content_innermid" style="width:79%;">
 <table width="780px" border="0">
  <tr>
    <td align="center" style="padding-left:5px;"><h1>Justcalluz <asp:Label ID="lblCity" runat="server"></asp:Label></h1></td>
 </tr>
  <tr>
    <td>
    <div id="local_trends">
      <table width="100%" border="0">
        <tr>
         <td valign="top" style="width:100%;">
         <table width="100%" border="0" id="tblcate" runat="server">
         <tr>
             <td align="right" width="75%" valign="top" style="padding-left:5px;">
              <asp:Label ID="Label1" runat="server" Font-Names="Arial">Archive for the Category :</asp:Label>&nbsp;
             </td>
              <td align="left" width="25%"> 
                <asp:Label id="lblcate" runat="server" Font-Bold="true" Font-Names="Arial" ForeColor="Red"></asp:Label>
             </td>
          </tr>
          </table>
         </td>
        </tr>
         <tr>
          <td colspan="3" valign="top">
           <asp:DataList ID="DlMainInfo" runat="server" Width="100%" OnItemDataBound="DlMainInfo_ItemDataBound" >
                 <ItemTemplate>
                    <table width="100%" border="0px">
                       <tr id="trMovies" runat="server">
                          <td height="31" colspan="5" valign="top">
                                <%--<a href="City_TrendsDetails.aspx?ctId=<%#Eval("ctId")%>" style="text-decoration:none;"> --%> 
                                <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server">       
                                 <span >
                                  <h3>
                                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                    &nbsp;-&nbsp;
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("posteddate") %>' ></asp:Label>
                                  </h3> 
                                 </span>                                                    
                                </a>
                           </td>
                           <td align="right"><strong>Follow Us On : </strong></td>
                           <td width="13%">
                               <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="Image7" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="Image8" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="Image9" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                           </td>                                                  
                        </tr>
                        <tr id="trOther" runat="server">
                            <td height="31" colspan="5">
                               <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server"> 
                                 <span>
                                 <h3>
                                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>'  ></asp:Label> 
                                  </h3>                                                       
                                 </span>
                              </a>   
                            </td>
                            <td align="right"><strong>Follow Us On : </strong></td>
                            <td width="13%"> 
                             <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="Image4" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="Image5"  AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="Image6" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                            </td>                                                  
                        </tr>
                        <tr id="trBusiness" runat="server">
                          <td height="31" colspan="5">
                              <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server"> 
                                 <span>
                                   <h3>
                                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("title") %>'  ></asp:Label>
                                    &nbsp;-&nbsp;
                                    <asp:Label ID="lblBusList" runat="server" Text='<%#Eval("listings") %>'  ></asp:Label>                                                  
                                   </h3>
                                 </span>
                              </a>   
                          </td> 
                          <td align="right"><strong>Follow Us On : </strong></td>
                          <td width="13%"> 
                             <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="facebookIcon" AlternateText="facebook" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="imgLkdIn"  AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="TwitterIcon" AlternateText="twitter" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                          </td>                                                 
                        </tr>
                         <tr>
                            <td colspan="6">
                                <asp:Label ID="lblListing" runat="server" Text='<%#Eval("listings")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                                <asp:Label ID="lbldataId" runat="server" Text='<%#Eval("dataIds_lang")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                            </td>
                        </tr> 
                         <tr>
                             <td width="3%"><asp:Image ID="Image10" AlternateText="calenderIcon" ImageUrl="images/icons/Calendar-icon.png" width="16" height="16" runat="server" /></td>
                              <td width="13%"><asp:Label ID="Label3" runat="server" Text='<%#Eval("posteddate") %>' Font-Size="Small"></asp:Label></td>
                              <td width="2%"><asp:Image ID="Image11" AlternateText="administratorIcon" ImageUrl="images/icons/Administrator-icon.png" width="16" height="16" runat="server" /></td>
                              <td colspan="2"><asp:Label ID="Label4" runat="server" Text='<%#Eval("postedby") %>' Font-Size="Small"></asp:Label></td>
                              <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="7"><p style="text-align:justify;">
                                 <asp:Label ID="Label6" runat="server" Text='<%#Eval("description")%>' Font-Bold="false"></asp:Label></p>
                            </td>
                       </tr>
                      <tr id="trSubtitle" runat="server" visible="false">
                           <td colspan="6"><h2>
                              <asp:Label ID="lblsubtitle" runat="server" Text='<%#Eval("SubTitle")%>' ></asp:Label></h2>                                                    
                          </td>
                      </tr>
                      <tr><td height="5px"></td></tr>
                      <tr>
                        <td colspan="6">
                         <asp:DataList ID="DlMovieDetails" runat="server" Width="100%" Visible="false">
                             <ItemTemplate>
                               <table width="100%" border="0px">
                                 <tr id="trMovieDetails" runat="server"  >
                                    <td colspan="6">
                                    <%-- <a href="<%# string.Format("Movies.aspx?mname={0}&mlang={1}&mcity={2}",Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>" style="text-decoration:none;">--%>
                                    <a id="A1" href='<%# GetUrlMovies(Eval("Movie_Name"),Eval("Movie_Language"),Eval("City")) %>' runat="server" style="text-decoration:none;"> 
                                     <strong>
                                       <asp:Label ID="lblMname" runat="server" Text='<%#Eval("Movie_Name") %>' Font-Bold="false" ></asp:Label></strong></a>&nbsp;:&nbsp;                                                                                                   
                                       <asp:Label ID="lblMdes" runat="server" Text='<%#Eval("Movie_Desc") %>'  Font-Bold="false"></asp:Label>                                                                                                     
                                    </td>                                                  
                                 </tr>
                                 <tr><td height="5px"></td></tr>
                                </table>
                              </ItemTemplate>
                             </asp:DataList>
                             </td>
                            </tr>
                             <tr><td height="5px"></td></tr>
                             <tr id="trTheatre" runat="server" visible="false" >
                                 <td colspan="6">
                                     <h2>
                                       <asp:Label ID="lbltheatres" runat="server" Text="Theatres where these movies are playing"></asp:Label>
                                     </h2>
                                 </td>
                             </tr>
                             <tr><td height="5px"></td></tr>
                             <tr>
                              <td colspan="6">
                               <asp:DataList ID="DlTheatre" runat="server" Width="100%" Visible="false">
                                 <ItemTemplate>
                                 <table width="100%" border="0px">
                                  <tr id="trTheatreDetails" runat="server" >
                                   <td colspan="6">
                                        <%--<a href="<%# string.Format("Movies.aspx?mname={0}&mlang={1}&mcity={2}",Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>" style="text-decoration:none;"> --%>
                                        <a id="A2" href='<%# GetUrlMovies(Eval("Movie_Name"),Eval("Movie_Language"),Eval("City")) %>' runat="server" style="text-decoration:none;">
                                        <strong>
                                        <asp:Label ID="lblMoviename" runat="server" Text='<%#Eval("Movie_Name") %>' Font-Bold="false" ></asp:Label></strong></a>&nbsp;:&nbsp;                                                                                                   
                                        <asp:Label ID="lblcHall" runat="server" Text='<%#Eval("CinemaHall_Name") %>' 
                                                    Font-Bold="false"></asp:Label>&nbsp;
                                        <asp:Label ID="lblarea" runat="server" Text='<%#Eval("Area") %>'  Font-Bold="false"></asp:Label>
                                        <asp:Label ID="lblcomma" runat="server" Text="," ForeColor="Black" Font-Bold="false"></asp:Label> 
                                        
                                   </td>
                                  </tr>
                                  <tr><td height="5px"></td></tr>
                                  </table>
                                 </ItemTemplate>
                                </asp:DataList>
                                 </td> 
                             </tr>    
                            <tr>
                            <td colspan="6">
                             <asp:DataList ID="DlCompanyDetails" runat="server" Width="100%" Visible="false" >
                             <ItemTemplate>
                               <table width="100%" border="0px">
                                <tr id="trcmpyDetails" runat="server" >
                                   <td colspan="6">
                                     <%--<a href="sessionstore.aspx?id=<%#Eval("id")%>" style="text-decoration:none;">--%>
                                     <a href='<%# GetUrlCompName(Eval("id")) %>' style="text-decoration:none;" runat="server">
                                    <strong>
                                        <asp:Label ID="lblCname" runat="server" Text='<%#Eval("company_name") %>' Font-Bold="false"></asp:Label></strong></a>&nbsp;:&nbsp;                                                                                                   
                                        <asp:Label ID="lblCprofile" runat="server" Text='<%#Eval("company_profile") %>' Font-Bold="false"></asp:Label> 
                                       
                                   </td>                                                
                                </tr>
                                <tr><td height="10px"></td></tr>
                                </table>
                                </ItemTemplate>
                             </asp:DataList>
                             </td>
                             </tr>
                             <tr>
                              <td colspan="6">
                              <asp:DataList ID="DlOtherDetails" runat="server" Width="100%" Visible="false" >
                                 <ItemTemplate>
                                   <table width="100%" border="0px">
                                     <tr id="trMTitle" runat="server" >
                                       <td colspan="6"><h2>
                                          <asp:Label ID="lblmtitle" runat="server" Text='<%#Eval("MTitle")%>' ></asp:Label></h2>                                                    
                                       </td>
                                     </tr>
                                      <tr id="trMInfo" runat="server" >
                                        <td colspan="7">
                                         <p style="text-align:justify;">
                                           <asp:Label ID="lblminfo" runat="server" Text='<%#Eval("MInfo") %>' Font-Bold="false"></asp:Label>                 
                                         </p>  
                                        </td>
                                      </tr>
                                  </table>
                                </ItemTemplate>
                          </asp:DataList>
                        </td>
                    </tr>
                    <tr>
                        <td height="10" colspan="5" style="padding-left:8px;"> 
                               <asp:Label ID="lblloginfo" Text=" For more information log on to or call Justcalluz." runat="server" ForeColor="Black"></asp:Label>
                        </td>
                   </tr> 
                    <tr>
                     <td colspan="7" height="10">
                           <p style="text-align:justify;">
                                <asp:Label ID="lblCtId" runat="server" Text='<%#Eval("ctId") %>' Visible="false"></asp:Label>
                                 
                                   <%--<asp:button ID="lnkmode" runat="server" Text='<%#Eval("mod")%>' CommandName="select" BackColor="White"
                                       CommandArgument='<%#Eval("mod")%>' OnClick="lnkmode_Click" ForeColor="Red" BorderStyle="None" />--%>
                                  <asp:HyperLink ID="lnkmode" runat="server" Text='<%#Eval("mod")%>' NavigateUrl='<%# GetUrlMode(Eval("mod")) %>'></asp:HyperLink>
                                     &nbsp;&nbsp;
                                <asp:Repeater ID="rptlist" runat="server" EnableViewState="False">
                                  <ItemTemplate>    
                                  <%--<a href="City_TrendsDetails.aspx?CtId=<%#Eval("ctId")%>" style="text-decoration:none;">--%>
                                  <a href='<%# GetUrl(Eval("ctId")) %>' runat="server" style="text-decoration:none;">
                                      <asp:Label ID="Label9" runat="server" Text='<%#Eval("list")%>' ForeColor="#6699FF"></asp:Label>
                                  </a>                                                                                                                            
                                  </ItemTemplate>     
                                  <SeparatorTemplate><span style="color:#6699FF">,</span> </SeparatorTemplate>
                                </asp:Repeater>
                           </p> 
                     </td>
                   </tr>
                     </table><hr />
               </ItemTemplate>
             </asp:DataList>
        </td></tr>
        <tr>
          <td colspan="3" valign="top">
           <asp:DataList ID="dlCT" runat="server" Width="100%" onitemdatabound="dlCT_ItemDataBound">
                 <ItemTemplate>
                    <table width="100%" border="0px">
                        <tr>
                            <td valign="top">
                                <asp:Label ID="lblmod" runat="server" Text='<%#Eval("mod") %>' Visible="false" ></asp:Label>
                                <asp:Label ID="lblCtId" runat="server" Text='<%#Eval("ctId") %>' Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr id="trMovies" runat="server">
                          <td height="31" colspan="5" valign="top">
                                 <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server">        
                                 <span >
                                  <h3>
                                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>' ></asp:Label>
                                    &nbsp;-&nbsp;
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("posteddate") %>' ></asp:Label>
                                  </h3> 
                                 </span>                                                    
                                </a>
                           </td>
                           <td align="right"><strong>Follow Us On : </strong></td>
                           <td width="13%">
                               <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="Image7" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="Image8" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="Image9" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                           </td>                                                  
                        </tr>
                        <tr id="trOther" runat="server">
                            <td height="31" colspan="5">
                               <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server"> 
                                 <span>
                                 <h3>
                                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>'></asp:Label> <%--//ForeColor="#6699FF"--%>
                                  </h3>                                                       
                                 </span>
                              </a>   
                            </td>
                            <td align="right"><strong>Follow Us On : </strong></td>
                            <td width="13%"> 
                             <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="Image4" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="Image5" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="Image6" AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                            </td>                                                  
                        </tr>
                        <tr id="trBusiness" runat="server">
                          <td height="31" colspan="5">
                              <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server"> 
                                 <span>
                                   <h3>
                                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("title") %>'  ></asp:Label>
                                    &nbsp;-&nbsp;
                                    <asp:Label ID="lblBusList" runat="server" Text='<%#Eval("listings") %>'  ></asp:Label>                                                  
                                   </h3>
                                 </span>
                              </a>   
                          </td> 
                          <td align="right"><strong>Follow Us On : </strong></td>
                          <td width="13%"> 
                             <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image ID="imgfacebook" AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image ID="imgLkdIn" AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image ID="TwitterIcon" AlternateText="twitter" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                          </td>                                                 
                        </tr>
                        <tr><td height="5px" colspan="2"></td></tr>
                        <tr>
                             <td width="3%"><asp:Image ID="Image10" AlternateText="calender" ImageUrl="images/icons/Calendar-icon.png" width="16" height="16" runat="server" /></td>
                              <td width="13%"><asp:Label ID="Label3" runat="server" Text='<%#Eval("posteddate") %>' Font-Size="Small"></asp:Label></td>
                              <td width="2%"><asp:Image ID="Image11" AlternateText="administratorIcon" ImageUrl="images/icons/Administrator-icon.png" width="16" height="16" runat="server" /></td>
                              <td colspan="2"><asp:Label ID="Label4" runat="server" Text='<%#Eval("postedby") %>' Font-Size="Small"></asp:Label></td>
                              <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="7"><p style="text-align:justify;">
                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("Mdesc")%>' Font-Bold="false"></asp:Label></p>
                            </td>
                       </tr>
                          <tr><td height="5px" colspan="2"></td></tr>
                        <tr>
                            <td colspan="7">
                              <p style="text-align:justify;">
                                <span style="color:Red;">Tagged</span>&nbsp;
                                 <asp:Repeater ID="rptlist" runat="server" EnableViewState="False">
                                  <ItemTemplate>    
                                  <a href='<%# GetUrl(Eval("ctId")) %>' style="text-decoration:none;" runat="server">
                                      <asp:Label ID="Label9" runat="server" Text='<%#Eval("list")%>' ForeColor="#6699FF"></asp:Label>
                                  </a>                                                                                                                            
                                  </ItemTemplate>     
                                  <SeparatorTemplate><span style="color:#6699FF">,</span> </SeparatorTemplate>
                                </asp:Repeater>
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
<div align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
<!-- end of the content-->
</form>
</body>
</html>
