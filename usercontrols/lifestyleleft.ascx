<%@ Control Language="C#" AutoEventWireup="true" CodeFile="lifestyleleft.ascx.cs" Inherits="usercontrols_lifestyleleft" %>
<table width="100%" border="0">
  <tr><td align="left">
  <asp:Label ID="lblsearch" runat="server" Text="RELATED SEARCH" Font-Bold="true" ForeColor="#BF0000" Font-Names="Arial"></asp:Label>
  </td></tr>
  <tr>
  <td class="side_menu">
  <asp:DataList ID="left_life" runat="server" DataKeyField="CatSub" OnItemDataBound="left_life_ItemDataBound">
  <ItemTemplate>
  <%--<table>
  <tr><td>
  <img id="img1" src="../images/arrow2.jpg" runat="server" />--%>
  <ul style="padding-left:15px;"><li>
  <%--<asp:Button ID="lnkleftlife" runat="server" Text ='<%# Eval("catSname")%>' CommandArgument='<%#Eval("CatSub")%>'  
       CommandName ="Select" Font-Names="Arial" BorderStyle="None" BackColor="#f8f9fa" CssClass="pointer" ToolTip='<%#Eval("CatSub")%>' />--%>
   <asp:HyperLink ID="lnkleftlife" runat="server" Text ='<%# Eval("catSname")%>' NavigateUrl='<%# GetCatSub(Eval("CatSub")) %>'
        Font-Names="Arial" ToolTip='<%#Eval("CatSub")%>'></asp:HyperLink>  
  </li></ul>
  <%--</td></tr>
  </table>--%>
  </ItemTemplate>
  </asp:DataList>
  </td>
  </tr>
 <tr><td class="side_menu">
  <asp:DataList ID="dlcat" runat="server" DataKeyField="Categeory" onitemdatabound="dlcat_ItemDataBound">
  <ItemTemplate>
 <%-- <table>--%>
  <%--<tr><td>
  <img id="img1" src="../images/arrow2.jpg" runat="server" />--%>
  <ul style="padding-left:15px;"><li>
 <%-- <asp:Button ID="lnkcatlife" runat="server" Text ='<%# Eval("LCategory")%>' CommandArgument='<%#Eval("Categeory")%>'  
      CommandName ="Select" BorderStyle="None" BackColor="#f8f9fa" CssClass="pointer" ToolTip='<%#Eval("Categeory")%>' />--%>
     <asp:HyperLink ID="lnkcatlife" runat="server" Text ='<%# Eval("LCategory")%>' NavigateUrl='<%# GetCate(Eval("Categeory"))%>'  
            ToolTip='<%#Eval("Categeory")%>'></asp:HyperLink>
  </li></ul>
  <%--</td></tr>
  </table>--%>
  </ItemTemplate>
  </asp:DataList>
 </td></tr>
  </table>