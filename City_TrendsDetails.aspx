<%@ Page Language="C#" AutoEventWireup="true" CodeFile="City_TrendsDetails.aspx.cs" Inherits="City_TrendsCate" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/City_trends_LeftContent.ascx" TagName="Leftcontent" TagPrefix="cityLeft_Cont" %>
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
    .style1
    {
        height: 19px;
    }
</style>
</head>
<body>
 <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
 <div class="layout">
<div>
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
    <%-- <ul>
		<li class="active"><a href="Default.aspx">Home</a></li>
		   <li> <a href="CityTrends_PopBusinesses.aspx">Popular Businesses</a></li>
		   <li> <a href="CityTrends_PopularCompanies.aspx">Popular Companies</a>
	  </li>
   </ul>  --%>
   <ul>
		<li class="active"><a id="A1" href="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><asp:Label ID="lblHome" Text="Home" runat="server"></asp:Label></a></li>
		   <li> <a id="A2" href="<%$RouteUrl:RouteName=CityTrends_PopularBusinesses %>" runat="server"><asp:Label ID="lblBusiness" Text="Popular Businesses" runat="server"></asp:Label></a></li>
		   <li> <a id="A3" href="<%$RouteUrl:RouteName=CityTrends_PopularCompanies %>" runat="server"><asp:Label ID="lblCompanies" Text="Popular Companies" runat="server"></asp:Label></a>
	  </li>
   </ul>
 <div class="clear-both">&nbsp;</div>
  </div>
</div>
<!-- staart the Content-->
 <div class="content" style="padding:0; margin:0;">
 <div class="content_innerleft">
   <cityLeft_Cont:Leftcontent id="leftcontent" runat="server"></cityLeft_Cont:Leftcontent>
 </div>  
<div class="content_innermid" style="width:79%;">
<table width="780px" border="0">
 <tr>
    <td align="center" style="padding-left:5px;"><h1>Justcalluz&nbsp;&nbsp;<asp:Label ID="lblCity" runat="server"></asp:Label></h1></td>
 </tr>
<tr>
 <td>
   <table width="100%" border="0" id="tblcate" runat="server">
         <tr>
             <td align="right" width="75%">
              <asp:Label ID="Label1" runat="server" Font-Names="Arial">Archive for the Category :</asp:Label>
                 &nbsp;
             </td>
              <td align="left" width="25%"> 
              <asp:Label id="lblcate" runat="server" Font-Bold="true" Font-Names="Arial" ForeColor="Red"></asp:Label>
             </td>
          </tr>
          </table>
  </td>
 </tr>
    <tr>
      <td colspan="3">
             <asp:DataList ID="dlCT" runat="server" Width="787px" 
                     onitemdatabound="dlCT_ItemDataBound">
                 <ItemTemplate>
                    <table width="787px" border="0px">
                        <tr>
                            <td>
                                <asp:Label ID="lblmod" runat="server" Text='<%#Eval("mod") %>' Visible="false" ></asp:Label>
                                <asp:Label ID="lblCtId" runat="server" Text='<%#Eval("ctId") %>' Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr id="trMovies" runat="server">
                          <td height="31" colspan="5">
                                 <span>
                                  <h3>
                                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>' ></asp:Label>
                                      &nbsp;-&nbsp;
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("posteddate") %>' ></asp:Label>
                                  </h3> 
                                 </span>                                                    
                               
                           </td>
                           <td align="right"><strong>Follow Us On : </strong></td>
                           <td width="13%">
                              <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>                              
                              <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                              <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                           </td>                                                  
                        </tr>
                        <tr id="trOther" runat="server">
                            <td height="31" colspan="6">
                                 <span>
                                 <h3>
                                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>' ></asp:Label> 
                                  </h3>                                                       
                                 </span>
                            </td>
                            <td align="right"><strong>Follow Us On : </strong></td>
                            <td width="13%">
                               <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                               <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                            </td>                                                  
                        </tr>
                        <tr id="trBusiness" runat="server">
                          <td height="31" colspan="6">
                                 <span>
                                   <h3>
                                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("title") %>' ></asp:Label>
                                       &nbsp;-&nbsp;
                                    <asp:Label ID="lblBusList" runat="server" Text='<%#Eval("listings") %>' ></asp:Label>                                                  
                                   </h3>
                                 </span>
                          </td> 
                          <td align="right"><strong>Follow Us On : </strong></td>
                          <td width="13%">
                             <a target="_blank" href="http://www.facebook.com/Justcalluz"><asp:Image AlternateText="facebookIcon" ImageUrl="images/icons/facebook-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="http://www.linkedin.com/pub/justcalluz/64/710/555?trk=tbr"><asp:Image AlternateText="LinkedInIcon" ImageUrl="images/icons/linkedin-icon.png" width="24" height="24" style="padding-right:5px;" runat="server" /></a>
                             <a target="_blank" href="https://twitter.com/justcalluz"><asp:Image AlternateText="twitterIcon" ImageUrl="images/icons/twitter-icon.png" width="24" height="24" runat="server" /></a>
                          </td>                                                 
                        </tr>
                        <tr><td height="5px" colspan="2"></td></tr>
                        <tr>
                              <td width="3%"><asp:Image AlternateText="calenderIcon" ImageUrl="images/icons/Calendar-icon.png" width="16" height="16" runat="server" /></td>
                              <td width="13%"><asp:Label ID="Label3" runat="server" Text='<%#Eval("posteddate") %>' ></asp:Label></td>
                              <td width="2%"><asp:Image AlternateText="administratorIcon" ImageUrl="images/icons/Administrator-icon.png" width="16" height="16" runat="server" /></td>
                              <td colspan="2"><asp:Label ID="Label4" runat="server" Text='<%#Eval("postedby") %>'></asp:Label></td>
                              <td>&nbsp;</td>
                        </tr>
                       <tr><td height="5px" colspan="2"></td></tr>
                        <tr>
                          <td  colspan="7"><p style="text-align:justify;">
                               <asp:Label ID="Label6" runat="server" Text='<%#Eval("description")%>'></asp:Label></p>
                          </td>
                        </tr>
                        <tr>
                            <td height="5px" colspan="2">
                                <asp:Label ID="lblListing" runat="server" Text='<%#Eval("listings")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                                <asp:Label ID="lbldataId" runat="server" Text='<%#Eval("dataIds_lang")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                            </td>
                        </tr> 
                        <tr id="trSubtitle" runat="server" visible="false">
                          <td colspan="6"><h2>
                              <asp:Label ID="lblsubtitle" runat="server" Text='<%#Eval("SubTitle")%>'></asp:Label></h2>                                                    
                          </td>
                        </tr>
                     </table>
                 </ItemTemplate>
             </asp:DataList>                                
          </td>
       </tr>
    <tr id="trvisible" runat="server" visible="false">
            <td style="width:100%;">
                <asp:Label ID="lblListings" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblDataIds" runat="server" Visible="false"></asp:Label>
           </td>
           <td></td>
      </tr>
  <%-- <tr>
       <td height="10px"></td><td></td>
   </tr> --%>
   <tr>
        <td style="padding-left:7px;">
            <asp:DataList ID="dlMovieDetails" runat="server" Width="100%" >
                <ItemTemplate>
                    <table width="100%" border="0px">
                        <tr>
                            <td colspan="12">
                           <a href="<%# string.Format("MovieDetails-{0}-{1}-{2}",Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>" style="text-decoration:none;">
                              <%-- <a href='<%# GetUrlMovies(Eval("Movie_Name"),Eval("Movie_Language"),Eval("City")) %>' runat="server" style="text-decoration:none;">--%>
                                <strong>
                                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("Movie_Name") %>' Font-Bold="false" ></asp:Label></strong></a>
                                &nbsp;:&nbsp;                                                                                                  
                               <p style="text-align:justify;"> <asp:Label ID="Label2" runat="server" Text='<%#Eval("Movie_Desc") %>' Font-Bold="false"></asp:Label> </p>                                                                                                    
                             </td> 
                            <td></td>                                               
                        </tr>
                        <tr><td height="5px"></td></tr>
                     </table>
                </ItemTemplate>
            </asp:DataList>
         </td>
        <%-- <td></td>--%>
   </tr>
   <tr id="trTheatre" runat="server">
              <td style="padding-left:7px;width:100%;">
                <h2>
                   <asp:Label ID="lbltheatres" runat="server" Text="Theatres where these movies are playing"></asp:Label>
                </h2>
              </td>
              <td></td>
          </tr>
   <tr><td height="5px"></td></tr>
  <tr>
      <td style="padding-left:7px;width:100%;">
        <asp:DataList ID="DlTheatres" runat="server" Width="100%">
            <ItemTemplate>
             <table>
              <tr>
               <td colspan="6">
              
               <a href="<%# string.Format("MovieDetails-{0}-{1}-{2}",Eval("Movie_Name"),Eval("Movie_Language"),Eval("City"))%>" style="text-decoration:none;">
                 <%--<a href='<%# GetUrlMovies(Eval("Movie_Name"),Eval("Movie_Language"),Eval("City")) %>' runat="server" style="text-decoration:none;">--%>
                  <strong>
                    <asp:Label ID="lblmname" runat="server" Text='<%#Eval("Movie_Name") %>' Font-Bold="false"></asp:Label></strong></a>
                     &nbsp;:&nbsp;                                                                                                   
                    <asp:Label ID="lblcHall" runat="server" Text='<%#Eval("CinemaHall_Name") %>' 
                                Font-Bold="false"></asp:Label>
                    <asp:Label ID="lblcomma" runat="server" Text="," ></asp:Label> 
                    <asp:Label ID="lblarea" runat="server" Text='<%#Eval("Area") %>'></asp:Label>
                </td>
              <td></td>
             </tr>
                <tr><td height="10px"></td></tr>
            </table>    
            </ItemTemplate>
        </asp:DataList>
       </td>
   </tr>
   <tr id="trmoreinfo2" runat="server">
                <td style="padding-left:5px;"> 
                       <asp:Label ID="Label5" Text=" For more information log on to or call Justcalluz." runat="server" ForeColor="Black" ></asp:Label>
                </td>
                <td>&nbsp;</td>
       </tr>
   <tr id="trcate2" runat="server">
               <td style="padding-left:5px;">                
                    <asp:Label ID="lblpost" Text="This entry was posted in" runat="server" ></asp:Label>
                    <a id="lnkmodcate2" runat="server" onserverclick="lnkmodcate2_Click" style="color:Red;"><asp:Label ID="lblmodcate2" runat="server"></asp:Label></a>
              </td>
              <td>&nbsp;</td>
      </tr> 
   <tr>
      <td style="padding-left:7px;">
            <asp:DataList ID="dlBusinesDetails" runat="server" Width="100%" >
                <ItemTemplate>
                    <table width="100%" border="0px">
                        <tr>
                           <td colspan="6">
                          
                             <%-- <a href="sessionstore.aspx?id=<%#Eval("id")%>" style="text-decoration:none;">--%>
                             <a href='<%# GetUrlCompName(Eval("id")) %>' runat="server" style="text-decoration:none;">
                              <strong> 
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("company_name") %>' Font-Bold="false" ></asp:Label></strong></a>
                               &nbsp;:&nbsp;                                                                                                   
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("company_profile") %>'></asp:Label> 
                            
                           </td>                                                
                        </tr>
                        <tr><td height="10px"></td></tr>
                     </table>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td></td>
   </tr>
   <tr id="trmoreinfo1" runat="server">
                <td style="padding-left:5px;"> 
                       <asp:Label ID="Label10" Text=" For more information log on to or call Justcalluz." runat="server" ForeColor="Black" ></asp:Label>
                </td>
                <td>&nbsp;</td>
          </tr> 
    <tr id="trcate1" runat="server">
           
            <td style="padding-left:5px;"> 
                <asp:Label ID="Label11" Text="This entry was posted in" runat="server" ></asp:Label>
               <a id="lnkmodcate1" runat="server" onserverclick="lnkmodcate1_Click" style="color:Red;"><asp:Label ID="lblmodcate1" runat="server"></asp:Label></a>
            </td>
            <td>&nbsp;</td>
         </tr> 
    <tr>
    <td style="padding-left:7px;">
        <asp:DataList ID="dlOtherCatDetails" runat="server" Width="100%" >
            <ItemTemplate>
                <table width="100%" border="0px">
                    <tr>
                        <td height="31" colspan="4"><h3>                                                                                                                                                        
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("MTitle") %>'></asp:Label></h3>                 
                        </td>                                                
                    </tr>
                    <%--<tr><td height="2px"></td></tr>--%>
                    <tr>
                        <td colspan="12">
                          <p style="text-align:justify;">
                            <asp:Label ID="Label9" runat="server" Text='<%#Eval("MInfo") %>'></asp:Label>                 
                          </p>
                        </td>                                                
                    </tr>
              <%--<tr><td height="5px"></td></tr>--%>
                 </table>
            </ItemTemplate>
        </asp:DataList>
     </td>
     <td></td>
  </tr>
   <tr id="trmoreinfo" runat="server">
            <td style="padding-left:5px;"> 
                <asp:Label ID="Label12" Text=" For more information log on to or call Justcalluz." runat="server" ForeColor="Black" ></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr> 
      <tr id="trcate" runat="server">
             <td style="padding-left:5px;"> 
                <asp:Label ID="Label13" Text="This entry was posted in" runat="server" ></asp:Label>
                <a id="lnkmodcate" runat="server" onserverclick="lnkmodcate_Click" style="color:Red;"><asp:Label ID="lblmodcate" runat="server"></asp:Label></a>
              </td>
              <td>&nbsp;</td>
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
</form>
</body>
</html>
