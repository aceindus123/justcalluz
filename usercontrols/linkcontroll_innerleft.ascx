<%@ Control Language="C#" AutoEventWireup="true" CodeFile="linkcontroll_innerleft.ascx.cs" Inherits="usercontrols_linkcontroll_innerleft" %>

<div class="contentbox_top">Refined Search By</div>
<div class="contentbox_mid"> 
<table width="100%" border="0">
  <tr id="trRestaurants" runat="server">
  <td valign="top" id="rest" runat="server" style="color:#FF0000;">
    <b style="font-size:12;">Restaurants</b>
    </td>
    </tr>
    <tr>
       <td class="side_menu">
            <asp:DataList ID="DlRestaurants" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                    DataKeyField="cat"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                        <ul><li style="line-height:20px;">                   
                        <%--<asp:LinkButton ID="lnkcat" runat="server" CommandArgument='<%#Eval("cat")%>'
                         Text ='<%# Eval("cat") +" Restaurants" %>' CommandName="select">
                        </asp:LinkButton>--%><%--
                         <asp:HyperLink ID="lnkcat" runat="server" Text='<%# Eval("cat") +" Restaurants" %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?rcname=" + Server.UrlEncode(Eval("cat").ToString() +" Restaurants")) %>' ToolTip='<%#Eval("cat")+" Restaurants"%>'></asp:HyperLink>--%>   
                      <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("cat") +" Restaurants" %>' NavigateUrl='<%#  GetrestCatUrl(Eval("cat")) %>' ToolTip='<%#Eval("cat")+" Restaurants"%>'></asp:HyperLink>   
                     <%--<asp:Button ID="lnkcat" runat="server" CommandArgument='<%#Eval("Rcate")%>' BorderStyle="None" BackColor="#f8f9fa"
                         Text ='<%# Eval("Rcate") %>' CommandName="select" CssClass="pointer" ToolTip='<%#DataBinder.Eval(Container.DataItem, "cat") + " Restaurants"%>' />--%>
                       </li></ul>       
               </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
 <tr id="trRelCat" runat="server">
  <td valign="top" style="color:#FF0000;">
    <b style="font-size:12;">Related Categories</b>
    </td>
    </tr>
    <tr>
   <td class="side_menu">
            <asp:DataList ID="dlcat" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                  DataKeyField="cat" OnItemDataBound="dlcat_ItemDataBound"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                  <ul><li style="line-height:20px;">                   
                    <%--<asp:LinkButton ID="lnkcategory" runat="server" CommandArgument='<%#Eval("cat")%>'
                     Text ='<%# Eval("cat") %>' CommandName="select"></asp:LinkButton>--%>
                      <%--<asp:HyperLink ID="lnkRelcategory" runat="server" Text='<%# Eval("cat") %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?scname=" + Server.UrlEncode(Eval("cat").ToString())) %>' ToolTip='<%#Eval("cat")%>'></asp:HyperLink>   --%>
                   <asp:HyperLink ID="lnkRelcategory" runat="server" Text='<%# Eval("cat") %>' NavigateUrl='<%# GetCat_sUrl(Eval("cat")) %>' ToolTip='<%#Eval("cat")%>'></asp:HyperLink>
                    <%--<asp:Button ID="lnkRelcategory" runat="server" CommandArgument='<%#Eval("catname")%>' BorderStyle="None" BackColor="#f8f9fa"
                     Text ='<%# Eval("catname") %>' CommandName="select" CssClass="pointer" ToolTip='<%#Eval("cat")%>' />--%>
                  </li></ul>   
                </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
    <tr id="tradvrel" runat="server">
  <td valign="top" style="color:#FF0000;">
    <b style="font-size:12;">Related Categories</b>
    </td>
    </tr>
    <tr>
   <td class="side_menu">
            <asp:DataList ID="dladvcat" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                   DataKeyField="SubCategory" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                   <ul><li style="line-height:20px;">
                    <%--<asp:LinkButton ID="lnkcategory" runat="server" CommandArgument='<%#Eval("SubCategory")%>'
                         Text ='<%# Eval("SubCategory") %>' CommandName="select"></asp:LinkButton>--%>
                          <%--<asp:HyperLink ID="lnkcat" runat="server" Text='<%# Eval("SubCategory") %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?acname=" + Server.UrlEncode(Eval("SubCategory").ToString())) %>' ToolTip='<%#Eval("SubCategory")%>'></asp:HyperLink> --%>  
                           <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# Eval("SubCategory") %>' NavigateUrl='<%# GetCat_aUrl(Eval("cat")) %>' ToolTip='<%#Eval("SubCategory")%>'></asp:HyperLink>   
                       <%--  <asp:Button ID="lnkcategory" runat="server" CommandArgument='<%#Eval("SubCategory")%>' CssClass="pointer"
                         Text ='<%# Eval("SubCategory") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" />--%>
                     </li></ul>                               
               </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
    <tr>
        <asp:Label ID="lblnocatfound" runat="server"></asp:Label></tr>
        <tr id="trhotels" runat="server">
    <td valign="top" style="color:#FF0000;">
    <b style="font-size:12;">Related Categories</b>
 </td>
 </tr>
    <tr>
        <td class="side_menu">
            <asp:DataList ID="dlhotcat" RepeatDirection="Vertical" CellPadding="4" runat="server"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                   <ul><li style="line-height:20px;">
                      <%--<asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("Category")%>'
                         Text ='<%# Eval("Category") %>' CommandName="select"></asp:LinkButton> --%>
                         <%--<asp:HyperLink ID="lnkHcat" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?cname=" + Server.UrlEncode(Eval("Category").ToString())) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink>  --%>
                         <asp:HyperLink ID="HyperLink3" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# GetCatUrl(Eval("Category")) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink>   
                        <%-- <asp:Button ID="LinkButton2" runat="server" CommandArgument='<%#Eval("Category")%>' CssClass="pointer"
                            Text ='<%# Eval("Category") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" /> --%>
                    </li></ul>
               </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
         <tr>
    <td valign="top" style="color:#FF0000;">
    <b style="font-size:12;" id="dlpoptitle" runat="server">Popular Categories</b>
 </td>
 </tr>
 <tr>
      <td class="side_menu">
            <asp:DataList ID="dlpopcat" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                  OnItemDataBound="dlpopcat_ItemDataBound"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                <ul><li style="line-height:20px;">
                    <%--<asp:LinkButton ID="lnkPopularCat" runat="server" CommandArgument='<%#Eval("Category")%>'
                           Text ='<%# Eval("Category") %>' CommandName="select"></asp:LinkButton>--%>
                        <%--<asp:HyperLink ID="lnkPopularCat" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?cname=" + Server.UrlEncode(Eval("Category").ToString())) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink>   --%>
                    <asp:HyperLink ID="HyperLink3" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# GetCatUrl(Eval("Category")) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink>
                    <%-- <asp:Button ID="lnkPopularCat" runat="server" CommandArgument='<%#Eval("Pcat")%>' CssClass="pointer" OnCommand="BindPopcat" 
                           Text ='<%# Eval("Pcat") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" ToolTip='<%#Eval("Category")%>' />--%>
                 </li></ul>               
                </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
    </table>
</div>
<div class="contentbox_bottam"></div>
