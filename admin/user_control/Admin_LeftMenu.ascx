<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_LeftMenu.ascx.cs" Inherits="usercontrols_WebUserControl" %>

<table cellpadding="5px" width="100px"  class="admintext"  style="border:0px  solid #B8962E;text-align:left; " >
  <tr>
    <td class="subheading" style="background-color:#CC0000" bgcolor="#CC0000" align="center">Admin Control</td>
  </tr>
 
  <tr>
  <td class="admintd">
    <div id="basic-accordian" style="width:195px; padding:0px; border:0px" > 
      <a href="../Admin_Ads.aspx" id="aAds" runat="server">     
      <div id="Div15" class="accordion_headings">Ads</div>
     </a> 
      <div id="divAdvertise" runat="server">       
        <div id="test7-header" class="accordion_headings">Advertise With Us</div>
      <div id="test7-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0" summary="">
        <tr>
           <td style="padding:3px 0px 3px 10px;">
             <a href="../Admin_ToApproveUserData.aspx?mod=Category&mod1=B2B Category" style="text-decoration:none;" id="BB2BAprRej" runat="server">
                <asp:Label ID="b2bapprej" runat="server" ForeColor="Green" Font-Size="12px">Approve <strong>/</strong> Reject</asp:Label></a>
          </td>
         </tr>
         </table>
         </div>
        </div>
       </div>
 <%--    <a href="../Admin_ToApproveUserData.aspx?mod=Category&mod1=B2B Category" style="text-decoration:none;" id="BB2BAprRej" runat="server">     
       <div id="Div4" class="accordion_headings">Advertise With Us</div>
     </a>--%>
       <div id="divB" runat="server">
      <div id="test-header" class="accordion_headings">Business Category</div>
      <div id="test-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
         <table cellspacing="0" cellpadding="0" width="199px" border="0">
            <tr>
                <td>
                    <asp:DataList ID="dlCat" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.Category")%></asp:LinkButton>
                         </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
                </td>
           </tr>                                                       
        </table>
      </div>
      </div> 
      </div>
      <div id="divB2B" runat="server">
      <div id="test3-header" class="accordion_headings">B2B Category</div>
      <div id="test3-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
         <table cellspacing="0" cellpadding="0" width="199px" border="0">
            <tr>
                <td>
                    <asp:DataList ID="dlB2Bcat" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                          <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.Category")%></asp:LinkButton>                     
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
                </td>
           </tr>                                                       
        </table>
      </div>
     </div>
    </div>   
       <a href="../Admin_Careers.aspx" id="careers" runat="server">     
      <div id="Div1" class="accordion_headings">Careers</div>
     </a>
      <a href="../Admin_WesiteUsersInfo.aspx" id="usersdata" runat="server">     
      <div id="Div11" class="accordion_headings">Customers Data</div>
     </a>
      <a href="../Admin_CityTrends.aspx" id="acitytrends" runat="server">     
      <div id="Div13" class="accordion_headings">City Trends</div>
     </a> 
      <%-- <a href="../Admin_CorporateSocial.aspx" id="csr" runat="server">     
      <div id="Div18" class="accordion_headings">Social Welfare Information</div>
     </a>--%>
    <%--  <a href="../Admin_ToCreateWebAdmins.aspx" id="webadmin" runat="server">     
      <div id="Div9" class="accordion_headings">Create Web Admin</div>
     </a>--%>
      <a href="../customer.aspx" id="Customer_care" runat="server">     
        <div id="Div21" class="accordion_headings">Customer Care</div>
      </a>
      <div id="divDis" runat="server">
      <div id="test2-header" class="accordion_headings" >Discounts</div>
      <div id="test2-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
         <tr>
           <td style="padding:10px 0px 3px 10px;">
           <a href="../Admin_ToApproveUserData.aspx?mod=Discounts" style="text-decoration:none;" id="DisAprRej" runat="server">
                <asp:Label ID="Label4" runat="server" ForeColor="Green" Font-Size="small">Approve <strong>/</strong> Reject</asp:Label></a>
           </td>
         </tr>
            <tr>
            <td>
                <asp:DataList ID="dlDiscounts" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                               <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + ",Discounts"  %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.category")%></asp:LinkButton>          
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>
      </div>
      </div>
       <a href="../site_exceptions.aspx" id="Exception" runat="server">     
      <div id="Div22" class="accordion_headings">Exceptions</div>
     </a>
      <div id="divEve" runat="server">
      <div id="test4-header" class="accordion_headings">Events</div>
      <div id="test4-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
         <tr>
           <td style="padding:10px 0px 3px 10px;">
           <a href="../Admin_ToApproveUserData.aspx?mod=Events" style="text-decoration:none;" id="EveAprRej" runat="server">
                <asp:Label ID="Label3" runat="server" ForeColor="Green" Font-Size="small">Approve <strong>/</strong> Reject</asp:Label></a>
           </td>
         </tr>
          <tr>
            <td>
                <asp:DataList ID="dlEvents" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                               <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                    
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>
      </div>
      </div>
        <%--<a href="" id="Feedback" runat="server">     
      <div id="Div2" class="accordion_headings">Feedback</div>
     </a>--%>
          <div id="divFL" runat="server">       
        <div id="test6-header" class="accordion_headings">Free Listing</div>
      <div id="test6-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0" summary="">
          <tr>
           <td style="padding:10px 0px 3px 10px;">
           <a href="../Admin_ToApproveUserData.aspx?mod=FreeListing" style="text-decoration:none;" id="freelistAprRej" runat="server">
                <asp:Label ID="Label2" runat="server" ForeColor="Green" Font-Size="small">Approve <strong>/</strong> Reject</asp:Label></a>
           </td>
         </tr>
          <tr>
            <td>
                <asp:DataList ID="dlFreeList" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>                                                               
                                 <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("category") + "," + Eval("maincat") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.category")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>        
    </div>
     <a href="Admin_Home.aspx">     
      <div id="test-header0" class="accordion_headings">Home</div>
     </a>
      <div id="divJobs" runat="server">
      <div id="test1-header" class="accordion_headings">Jobs</div>
      <div id="test1-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
          <tr>
           <td style="padding:10px 0px 3px 10px;">
           <a href="../Admin_ToApproveUserData.aspx?mod=Jobs" style="text-decoration:none;" id="JobsAprRej" runat="server">
                <asp:Label ID="JobappRej" runat="server" ForeColor="Green" Font-Size="small">Approve <strong>/</strong> Reject</asp:Label></a>
           </td>
         </tr>
          <tr>
            <td>
                <asp:DataList ID="dlJobs" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                              <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>
      </div>
      <div id="divLifeStyle" runat="server">       
        <div id="test5-header" class="accordion_headings">LifeStyle</div>
      <div id="test5-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0" summary="">
        <tr>
           <td style="padding:10px 0px 3px 10px;">
           <a href="../Admin_ToApproveUserData.aspx?mod=LifeStyle" style="text-decoration:none;" id="LSAprRej" runat="server"><asp:Label ID="appRej" runat="server" ForeColor="Green" Font-Size="small">Approve/Reject</asp:Label></a>
               <%--<asp:LinkButton ID="lnkApprove" runat="server" ForeColor="Green" PostBackUrl="../Admin_ToApproveUserData.aspx?mod=LifeStyle">Approve/Reject</asp:LinkButton>--%>
           </td>
         </tr>
         <tr>
            <td>
                <asp:DataList ID="dlLifeStyle" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>                                                                                                
                                 <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("maincat") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>        
    </div>
      <a href="../Admin_Media.aspx" id="amediaspeak" runat="server">     
      <div id="Div14" class="accordion_headings">Media Speak</div>
     </a> 
      <a href="../Admin_Movies.aspx" id="amovies" runat="server">     
      <div id="Div12" class="accordion_headings">Movies</div>
     </a> 
      <a href="../Admin_PostData.aspx" id="postdata" runat="server">     
      <div id="Div5" class="accordion_headings">Post Data</div>
     </a>
      <a href="../Admin_SearchNotFound.aspx" id="snf" runat="server">     
      <div id="Div19" class="accordion_headings">Search not found</div>
     </a>
      <a href="../Admin-Sitevisitordetails.aspx" id="SiteVisitors" runat="server">     
      <div id="Div2" class="accordion_headings">Site Visitors</div>
     </a>
      <a href="../Admin_CorporateSocial.aspx" id="csr" runat="server">     
      <div id="Div18" class="accordion_headings">Social Welfare Information</div>
     </a>
       <a href="../Admin_SponsoredLinks.aspx" style="text-decoration:none;" id="sponlinks" runat="server">     
      <div id="Div3" class="accordion_headings">Sponsored Links</div>
     </a>
      <a href="../Admin_SuccessStories.aspx?Type=SSText&s=Andhra Pradesh&c=Hyderabad" id="ss" runat="server">     
      <div id="Div17" class="accordion_headings">Success Stories</div>
     </a> 
       <a href="../Admin_Testimonials.aspx" id="testimonials" runat="server">     
      <div id="Div20" class="accordion_headings">Testimonials</div>
     </a>
       <a href="../Admin_WhitePages.aspx" id="wp" runat="server">     
      <div id="Div16" class="accordion_headings">White Pages</div>
     </a> 
   






















    <%-- <a href="Admin_Home.aspx">     
      <div id="test-header0" class="accordion_headings">Home</div>
     </a>--%>
    
    
   <%--  <a href="../Admin_PostData.aspx" id="postdata" runat="server">     
      <div id="Div2" class="accordion_headings">Post Data</div>
     </a>--%>
   
   <%--  <a href="../Admin_SponsoredLinks.aspx" style="text-decoration:none;" id="sponlinks" runat="server">     
      <div id="Div3" class="accordion_headings">Sponsored Links</div>
     </a>--%>
    <%-- <a href="../Admin_ToApproveUserData.aspx?mod=Category&mod1=B2B Category" style="text-decoration:none;" id="BB2BAprRej" runat="server">     
      <div id="Div4" class="accordion_headings">To Approve/Reject Advertise With Us</div>
     </a>--%>
   <%--  <a href="../Admin_ToApproveUserData.aspx?mod=FreeListing" style="text-decoration:none;" id="freelistAprRej" runat="server">     
      <div id="Div8" class="accordion_headings">To Approve/Reject Free Listing</div>
     </a>--%>
    <%-- <a href="../Admin_ToApproveUserData.aspx?mod=Discounts" style="text-decoration:none;" id="DisAprRej" runat="server">     
      <div id="Div5" class="accordion_headings">To Approve/Reject Discounts</div>
     </a>--%>
    <%-- <a href="../Admin_ToApproveUserData.aspx?mod=Events" style="text-decoration:none;" id="EveAprRej" runat="server">     
      <div id="Div6" class="accordion_headings">To Approve/Reject Events</div>
     </a>--%>
   <%--  <a href="../Admin_ToApproveUserData.aspx?mod=Jobs" style="text-decoration:none;" id="JobsAprRej" runat="server">     
      <div id="Div7" class="accordion_headings">To Approve/Reject Jobs</div>
     </a>--%>
    <%-- <a href="../Admin_ToApproveUserData.aspx?mod=LifeStyle" style="text-decoration:none;" id="LSAprRej" runat="server">     
      <div id="Div10" class="accordion_headings">To Approve/Reject Life Style</div>
     </a> --%>
     <%-- <a href="../Admin_Movies.aspx" id="amovies" runat="server">     
      <div id="Div12" class="accordion_headings">Movies</div>
     </a> --%>
     <%-- <a href="../Admin_CityTrends.aspx" id="acitytrends" runat="server">     
      <div id="Div13" class="accordion_headings">City Trends</div>
     </a> --%>
    <%--  <a href="../Admin_Media.aspx" id="amediaspeak" runat="server">     
      <div id="Div14" class="accordion_headings">Media Speak</div>
     </a> --%>
   <%--  <a href="../Admin_Ads.aspx" id="aAds" runat="server">     
      <div id="Div15" class="accordion_headings">Ads</div>
     </a> --%>
    <%--  <a href="../Admin_WhitePages.aspx" id="wp" runat="server">     
      <div id="Div16" class="accordion_headings">White Pages</div>
     </a> --%>
    <%-- <a href="../Admin_SuccessStories.aspx?Type=SSText&s=Andhra Pradesh&c=Hyderabad" id="ss" runat="server">     
      <div id="Div17" class="accordion_headings">Success Stories</div>
     </a> --%>
   <%--  <a href="../Admin_CorporateSocial.aspx" id="csr" runat="server">     
      <div id="Div18" class="accordion_headings">Corporate Social Responsibility</div>
     </a>--%>
     <%--  <a href="../Admin_Testimonials.aspx" id="testimonials" runat="server">     
      <div id="Div20" class="accordion_headings">Testimonials</div>
     </a>--%>
    <%-- <a href="../Admin_SearchNotFound.aspx" id="snf" runat="server">     
      <div id="Div19" class="accordion_headings">Search not found</div>
     </a>--%>
   <%--  <a href="../customer.aspx" id="Customer_care" runat="server">     
      <div id="Div21" class="accordion_headings">Customer Care</div>
     </a>--%>
    <%-- <a href="../site_exceptions.aspx" id="Exception" runat="server">     
      <div id="Div22" class="accordion_headings">Exceptions</div>
     </a>--%>
     <%--<div id="divLifeStyle" runat="server">       
        <div id="test5-header" class="accordion_headings">LifeStyle</div>
      <div id="test5-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0" summary="">
          <tr>
            <td>
                <asp:DataList ID="dlLifeStyle" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>                                                                                                
                                 <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("maincat") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>        
    </div>--%>
<%--    <div id="divFL" runat="server">       
        <div id="test6-header" class="accordion_headings">Free Listing</div>
      <div id="test6-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0" summary="">
          <tr>
            <td>
                <asp:DataList ID="dlFreeList" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>                                                               
                                 <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("category") + "," + Eval("maincat") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.category")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>        
    </div>--%>
    <%-- <div id="divJobs" runat="server">
      <div id="test1-header" class="accordion_headings">Jobs</div>
      <div id="test1-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
          <tr>
            <td>
                <asp:DataList ID="dlJobs" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                              <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                  
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>       
      </div>
      </div>--%>
      <%--<div id="divEve" runat="server">
      <div id="test4-header" class="accordion_headings">Events</div>
      <div id="test4-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
          <tr>
            <td>
                <asp:DataList ID="dlEvents" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                               <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("cat") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.cat")%></asp:LinkButton>                    
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("cat") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>
      </div>
      </div>--%>
      <%--<div id="divDis" runat="server">
      <div id="test2-header" class="accordion_headings" >Discounts</div>
      <div id="test2-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
        <table cellspacing="0" cellpadding="0" width="199px" border="0px" summary="">
            <tr>
            <td>
                <asp:DataList ID="dlDiscounts" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                               <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + ",Discounts"  %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.category")%></asp:LinkButton>          
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
            </td>
          </tr>
        </table>
      </div>
      </div>
      </div>--%>
    <%--  <div id="divB" runat="server">
      <div id="test-header" class="accordion_headings">Business Category</div>
      <div id="test-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
         <table cellspacing="0" cellpadding="0" width="199px" border="0">
            <tr>
                <td>
                    <asp:DataList ID="dlCat" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.Category")%></asp:LinkButton>
                         </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
                </td>
           </tr>                                                       
        </table>
      </div>
      </div> 
      </div>
      <div id="divB2B" runat="server">
      <div id="test3-header" class="accordion_headings">B2B Category</div>
      <div id="test3-content">
      <div class="accordion_child" style="background-color: #D7EAFF; padding:0px">
         <table cellspacing="0" cellpadding="0" width="199px" border="0">
            <tr>
                <td>
                    <asp:DataList ID="dlB2Bcat" runat="server" RepeatDirection="Horizontal" 
                                                        RepeatColumns="1" cellpadding="5" cellspacing="5" 
                                    Width="199px" Font-Size="small">                                                
                        <ItemTemplate>
                          <asp:LinkButton ID="lnkBtn" runat="server" CommandArgument='<%#Eval("Category") + "," + Eval("Module") %>' OnCommand="lnkViewCategoryData"><%# DataBinder.Eval(Container, "DataItem.Category")%></asp:LinkButton>                     
                        </ItemTemplate>                            
                        <SelectedItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                        </SelectedItemTemplate>                            
                    </asp:DataList> 
                </td>
           </tr>                                                       
        </table>
      </div>
     </div>
    </div>   --%>              
    </div>
  </td>
  </tr>
  </table>