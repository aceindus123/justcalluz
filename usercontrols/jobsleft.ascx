<%@ Control Language="C#" AutoEventWireup="true" CodeFile="jobsleft.ascx.cs" Inherits="usercontrols_jobsleft" %>
<table border="0">
<tr>
<td class="side_menu">
<asp:DataList ID="dljob" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                Height="50px" Width="160px" OnItemDataBound="dljob_ItemDataBound">
<HeaderTemplate>
</HeaderTemplate>
<ItemTemplate>
<ul>
<li style="line-height:20px;">
<%--<asp:Button ID="btnJcate" runat="server" CommandArgument='<%#Eval("cat") %>' Text='<%#Eval("JCate") %>' 
     CommandName="select" BorderStyle="None" BackColor="#f8f9fa" CssClass="pointer" ToolTip='<%#Eval("cat") %>' />--%>
 <asp:HyperLink ID="lnkjob" runat="server" Text='<%# Eval("JCate") %>' ToolTip='<%#Eval("cat") %>'
   NavigateUrl='<%# GetCatUrls(Eval("cat")) %>' Font-Underline="false"></asp:HyperLink>
<%-- <asp:HyperLink ID="linkit" Text='<%#Eval("cat") %>' runat="server" NavigateUrl='<%# string.Format("joblinks.aspx?catname=" + Eval("cat").ToString()+ "&cname=jobs") %>'></asp:HyperLink>
--%>
 </li>
</ul>
</ItemTemplate>
</asp:DataList>
</td>
</tr>
</table>

