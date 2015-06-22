<%@ Control Language="C#" AutoEventWireup="true" CodeFile="innerleft1.ascx.cs" Inherits="usercontrols_WebUserControl" %>

<div class="contentbox_top">Refined Search By</div>
<div class="contentbox_mid"> 
<table width="100%" border="0">
 
         <tr>
    <td valign="top" style="color:#FF0000;">
    <b style="font-size:12;">Popular Categories</b>
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
                        <%--<asp:HyperLink ID="lnkPopularCat" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# string.Format("~/linkcontroller.aspx?cname=" + Server.UrlEncode(Eval("Category").ToString())) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink> --%>
                   <asp:HyperLink ID="HyperLink3" runat="server" Text='<%# Eval("Category") %>' NavigateUrl='<%# GetCatUrl(Eval("Category")) %>' ToolTip='<%#Eval("Category")%>'></asp:HyperLink>
                    <%--<asp:Button ID="lnkPopularCat" runat="server" CommandArgument='<%#Eval("Pcat")%>' CssClass="pointer" OnCommand="BindPopcat" 
                           Text ='<%# Eval("Pcat") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" ToolTip='<%#Eval("Category")%>' />--%>
                 </li></ul>               
                </ItemTemplate>
             </asp:DataList>
        </td>
    </tr>
    </table>
</div>
<div class="contentbox_bottam"></div>
