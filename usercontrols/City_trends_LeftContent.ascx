<%@ Control Language="C#" AutoEventWireup="true" CodeFile="City_trends_LeftContent.ascx.cs" Inherits="usercontrols_City_trends_Right" %>


<!-- box one -->
<div class="contentbox_top">Popular Categories</div>
<div class="contentbox_mid" style="padding-left:15px;">
  <table width="100%" cellpadding="0" cellspacing="0">
      <tr >
      <td>
        <asp:DataList ID="DlpopCat" runat="server" DataKeyField="Category" RepeatDirection="Vertical"  
                   >
           <ItemTemplate>
           <ul>
             <li style="line-height:20px">
                <asp:HyperLink ID="lnkpopCat" runat="server" Text='<%#Eval("Category") %>' NavigateUrl='<%# GetUrlPopCat(Eval("Category")) %>' Font-Underline="false" Font-Names="Arial"></asp:HyperLink> 
             <%--<asp:Button ID="lnkpopCat" runat="server" Text='<%#Eval("Category")%>' BorderStyle="None" BackColor="#f8f9fa"
                 CommandName="select" CommandArgument='<%#Eval("Category")%>' Font-Underline="false" CssClass="pointer"  />--%>

             </li>
           </ul>
           </ItemTemplate>
        </asp:DataList>
        </td>
       </tr>
  </table>
</div>
<div class="contentbox_bottam"></div>
<!--end of box one -->

<!-- start box two-->
<div class="contentbox_top">Local Search</div>
<div class="contentbox_mid" style="padding-left:15px;">
  <table width="100%" cellpadding="0" cellspacing="0">
      <tr>
      <td>
        <asp:DataList ID="DllocalSearch" runat="server" DataKeyField="cname" RepeatDirection="Vertical"  
                      OnItemCommand="DllocalSearch_ItemCommand" >
           <ItemTemplate>
           <ul>
             <li style="line-height:20px">
                  <%--<asp:Button ID="lnklocalSearch" runat="server" Text='<%# "Justcalluz "+ Eval("cname")%>' BorderStyle="None" BackColor="#f8f9fa"
                      CommandName="select" CommandArgument='<%# Eval("cname") %>' Font-Underline="false" CssClass="pointer"/>--%>
                  <asp:HyperLink ID="lnklocalSearch" runat="server" Text='<%# "Justcalluz "+ Eval("cname")%>'
                      NavigateUrl='<%# GetLocalCat(Eval("cname")) %>' Font-Underline="false"></asp:HyperLink>
              </li>
           </ul>
           </ItemTemplate>
        </asp:DataList>
        </td>
       </tr>
   </table>
</div>
<div class="contentbox_bottam"></div>
<!--end of box two -->


<!-- start box three-->
<div class="contentbox_top">Recent Posts</div>
<div class="contentbox_mid" style="padding-left:15px;">
 <table width="100%" cellpadding="0" cellspacing="0">
       <tr>
         <td>
           <asp:DataList ID="Dlposts" runat="server" DataKeyField="ctId" RepeatDirection="Vertical">
                <ItemTemplate>
                  <ul>
                   <li style="line-height:20px;">
                       <%--<a href="City_TrendsDetails.aspx?ctId=<%#Eval("ctId")%>" style="text-decoration:none;">--%>
                       <asp:HyperLink ID="lnkPosts" runat="server" Text='<%#Eval("title") %>' NavigateUrl='<%# GetUrlcityid(Eval("ctId")) %>' Font-Underline="false" Font-Names="Arial"></asp:HyperLink> 
                          <%--<asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>' Font-Size="10" ForeColor="#003366" Font-Bold="false"></asp:Label> --%>
                       </a>   
                   </li>
                 </ul>
                </ItemTemplate>
           </asp:DataList> 
         </td>
       </tr>
     </table>
</div>
<div class="contentbox_bottam"></div>
<!--end of box three -->

<!-- start box Four-->
<div class="contentbox_top">Tag Clouds</div>
<div class="contentbox_mid" style="padding-left:15px;">
 <table width="100%" cellpadding="0" cellspacing="0">
       <tr>
         <td  valign="top" style="font-family:Verdana, Geneva, sans-serif;  line-height:1.5; letter-spacing:.3px; ">
             <asp:Repeater ID="DlTags" runat="server">
        <ItemTemplate>
           <a id="lnkcomp" runat="server" href='<%# GetUrlcity_title(Eval("ctId")) %>' style="color:#005B88; font-size:medium;"><%#DataBinder.Eval(Container.DataItem, "title")%></a>
        </ItemTemplate>
        <AlternatingItemTemplate>
           <a id="lnkcomp1" runat="server" href='<%# GetUrlcity_title(Eval("ctId")) %>' style="color:#004080; font-size: small;"><%#DataBinder.Eval(Container.DataItem, "title")%></a>
        </AlternatingItemTemplate>
        <SeparatorTemplate>&nbsp;&nbsp;</SeparatorTemplate>
        </asp:Repeater>
          <%-- <asp:DataList ID="DlTags" runat="server" DataKeyField="ctId" RepeatDirection="Horizontal" 
                  RepeatColumns="1" Width="100%" height="460px">
                <ItemTemplate>
                  <ul>
                    <li style="line-height:20px;">
                       <asp:HyperLink ID="lnkTitle" runat="server" Text='<%#Eval("title") %>'  NavigateUrl='<%# GetUrlcity_title(Eval("ctId")) %>' Font-Underline="false" Font-Names="Arial"></asp:HyperLink>  
                          
                       </a>
                    </li>
                  </ul>  
                </ItemTemplate>
           </asp:DataList> --%>
         </td>
       </tr>
     </table>
</div>
<div class="contentbox_bottam"></div>

<!--end of box Four -->


