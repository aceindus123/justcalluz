<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Home_right.ascx.cs" Inherits="usercontrols_Home_right" %>
<%@ Import Namespace="System.Web.Routing" %>

<table width="100%" border="0">
<asp:UpdatePanel ID="update" runat="server">
<ContentTemplate>
<%--<asp:ScriptManager ID="scrpt" runat="server"></asp:ScriptManager>--%>
   <%--<tr>
      <td colspan="3" class="headings">Reviews &amp; Ratings<hr /></td>
    </tr>--%>
    <tr style="font-weight:bold; font-size:14px;background-color:#435a68; color:White;">
     <%-- <td width="14%" colspan="2"><img alt="JustcalluzLogo" src="images/icons/people-icon.png" width="32" height="32" /></td>--%>
      <td width="82%" style="font-weight:bold; font-size:14px;background-color:#435a68; color:White;text-align:center;" colspan="3"><img alt="JustcalluzLogo" src="images/icons/people-icon.png" width="32" height="32" />
       Click here for ratings</td>
    </tr>
    <tr>
      <td colspan="3" style="padding-left:8px;">
     
        <asp:DataList ID="dlReview" runat="server" Width="200px"  OnItemDataBound="dlReview_ItemDataBound">
             <ItemTemplate>
                <table width="100%" border="0" style="border-bottom:#036 1px groove; padding:5px; top:repeat-x; height:auto">
                 <tr><td height="1px"></td></tr>
                 <tr>                  
                   <td style="width:80%"> 
                    <table width="100%" border="0" style="color:#007ab8">                       
                        <tr class="headings2">
                           <td height="26" align="left" valign="top" colspan="3" style="color:#005B88">                           
                                   <%--<asp:HyperLink  ID="Linkbutton3" runat="server" NavigateUrl='<%# string.Format("../sessionstore.aspx?id=" + Eval("dataid").ToString()+"&cname="+Eval("title").ToString()) %>' 
                                   Font-Underline="false" ForeColor="#005B88" >     --%>    
                                   <asp:HyperLink  ID="Linkbutton3" runat="server" NavigateUrl="<%$RouteUrl:RouteName=sessionstore %>" Font-Underline="false" ForeColor="#005B88" >                                                                                  
                               <asp:Label ID="lblname" runat="server" Text='<%#Eval("title") %>'></asp:Label>,<br />
                                <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City") %>'></asp:Label>  
                                </asp:HyperLink>                                        
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                Rated&nbsp;<asp:Label ID="lblrating" runat="server" ></asp:Label><asp:Label ID="lblRate" runat="server" Text='<%#Eval("Stars_Rating") %>' Visible="false"></asp:Label> By
                                <asp:Label ID="lblbyName" runat="server" Text='<%#Eval("byname") %>' Visible="false"></asp:Label>
                                <asp:Label ID="lblRName" runat="server" Text='<%#Eval("rname") %>' Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                at &nbsp;<asp:Label ID="Label2" runat="server" Text='<%#Eval("time") %>'></asp:Label>
                            </td>
                        </tr>                                                
                    </table>
                     </td>
                    </tr>                    
                        
                    <tr><td height="1px"></td></tr>                   
                    </table>                                                                                                                   
                </ItemTemplate>                                                                           
              </asp:DataList>
             
      </td>
    </tr>
    <tr id="paging" runat="server"><td align="right" colspan="3">
    <div style="float:left">
     <asp:LinkButton ID="Prev" runat="server" AlternateText="btnPrevious"  OnClick="Prev_Click" Text="<<" ToolTip="Previous"  /></div>
     <div style="float:right">
    <asp:LinkButton ID="Next" runat="server" AlternateText="btnNext"  OnClick="Next_Click" Text=">>"  ToolTip="Next" /></div>
   </td>
    </tr>
    </ContentTemplate>
      </asp:UpdatePanel>
   
    <tr>
      <td colspan="3" height="7px" ></td>
    </tr>    
    <tr>
      <td height="40"><img alt="FreelistingIcon" src="images/icons/add-event-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings">
      <asp:HyperLink ID="hlfreelist" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Free%>" Font-Underline="false" Font-Bold="true" ForeColor="Maroon">Free Listing</asp:HyperLink>    
      </span><br />
        List your business free on Justcalluz</td>
    </tr>
    <tr>
      <td height="40"><img alt="ViewsIcon" src="images/icons/Architecture-info-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings"><a href="<%$RouteUrl:RouteName=Test%>" runat="server" style="color:Maroon; text-decoration:none;">Share Your Views about Justcalluz</a></span><br />
        Your views about Justcalluz</td>
    </tr>
    <tr>
      <td height="40"><img alt="AdvertiseIcon" src="images/icons/banner_design.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings">
       <%--<asp:HyperLink ID="hlAdvertise" runat="server" NavigateUrl="../Advertise.aspx" Font-Underline="false"  Font-Bold="true" ForeColor="Maroon">Advertise</asp:HyperLink><br />--%>
       <asp:HyperLink ID="hlAdvertise" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Advertise %>" Font-Underline="false"  Font-Bold="true" ForeColor="Maroon">Advertise</asp:HyperLink><br />
      </span>
        Advertise your business on Justcalluz</td>
    </tr>
    <%--<tr id="buydata" runat="server" visible="false">
      <td><img alt="BuyDataIcon" src="images/icons/shopping-cart-full-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings"><a href="testimonials.aspx#shareViews" style="color:Maroon; text-decoration:none;">Buy Data</a></span><br />
        5 million+ fully customized business data points across India</td>
    </tr>--%>
   <%-- <tr>
      <td height="40"><img alt="JcalluzAdsIcon" src="images/icons/movie-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Ads%>" Font-Underline="false" Font-Bold="true" ForeColor="Maroon">
       Justcalluz Ads</asp:HyperLink></span><br />
       </td>
    </tr>--%>
    <%--<tr>
      <td height="40"><img alt="AndroidIcon" src="images/icons/android-platform-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings">JustCallUz Android APP</span><br />
        460,787+ downloads. Get it Now!</td>
    </tr>
    <tr>
      <td height="40"><img alt="MobileIcon" src="images/icons/blackberry-icon.png" width="32" height="32" /></td>
      <td>&nbsp;</td>
      <td><span class="headings"><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="../JC_OnMobile.aspx" Font-Underline="false" Visible="false" Font-Bold="true" ForeColor="Maroon">JustCallUz On Mobile</asp:HyperLink></span><br />
        Search at your fingertios</td>
    </tr>--%>
   
  </table>
 

