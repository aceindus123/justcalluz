<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SponsoredLinks.ascx.cs" Inherits="usercontrols_SponsoredLinks" %>
<div id="newsticker-demo">
<div class="newsticker-jcarousellite">
 <asp:datalist ID="dlbanners" runat="server" RepeatDirection="Vertical"
            Height="117px" Width="160px">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
            <asp:Image ID="imgbanner" runat="server" ImageUrl='<%# Eval("ad_img", "~/Banner_Images\\{0}") %>'/>
            </ItemTemplate>
 
 </asp:datalist>
</div>
</div>
    <asp:DataList ID="dlsponsoredlinks" RepeatDirection="Vertical" 
    CellPadding="4"  runat="server" 
            Height="117px" Width="160px" 
    >
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
         <ul><li>                      
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Text='<%# Eval("heading") %>' NavigateUrl='<%# Eval("website") %>'>                            
         </asp:HyperLink><br /><br />
           <%#DataBinder.Eval(Container.DataItem, "heading1")%>
        </li></ul> 
     </ItemTemplate>
    </asp:DataList>
   
