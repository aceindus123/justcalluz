<%@ Control Language="C#" AutoEventWireup="true" CodeFile="discount_left.ascx.cs" Inherits="discount_left" %>
<style type="text/css">
    .style1
    {
        height: 15px;
    }
</style>
<table width="100%" border="0">

 <tr id="trRelatedSubCat" runat="server" visible="false">
  <td>
   &nbsp;&nbsp;<asp:Label Text="Related Categories" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
  </td>
 </tr>
   <tr id="trDlSubcat" runat="server" visible="false">
     <td class="side_menu">
       <asp:DataList ID="DlSubcat" RepeatDirection="Vertical" runat="server"  
             Height="117px" Width="150px"  
                DataKeyField="SubCategory" 
             onitemdatabound="DlSubcat_ItemDataBound">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <ul><li style="line-height:15px;">
                  <%--<asp:Button ID="lnkScat" runat="server" CommandArgument='<%#Eval("SubCategory")%>' CssClass="pointer" 
                     Text ='<%# Eval("Scatname") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" ToolTip='<%#Eval("SubCategory")%>' />--%>
                    <asp:HyperLink ID="HypScat" runat="server" Text='<%# Eval("Scatname") %>' NavigateUrl='<%# GetSCatUrl(Eval("SubCategory")) %>' 
                            ToolTip='<%#Eval("SubCategory")%>'></asp:HyperLink> 
                 
                </li></ul>
              
           </ItemTemplate>
        </asp:DataList>
      </td>
  </tr>
  <tr>
   <td class="side_menu">
    &nbsp;&nbsp;<asp:Label ID="Label1" Text="Discounts" ForeColor="Red" runat="server" Font-Bold="true"></asp:Label>
         <asp:DataList ID="DlCate" RepeatDirection="Vertical" runat="server" 
                Height="117px" Width="150px"  
           DataKeyField="Category" OnItemDataBound="DlCate_ItemDataBound" >
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
              
                   <ul><li style="line-height:15px;">
                    <%--<asp:Button ID="lnkcate" runat="server" CommandArgument='<%#Eval("Category")%>' CssClass="pointer"  
                      Text ='<%# Eval("catname") %>' CommandName="select" BorderStyle="None" BackColor="#f8f9fa" ToolTip='<%# Eval("Category") %>' />--%>
                     <asp:HyperLink ID="Hypcate" runat="server" Text='<%# Eval("catname") %>' NavigateUrl='<%# GetCatUrl(Eval("Category")) %>'
                           ToolTip='<%# Eval("Category") %>'></asp:HyperLink>
                    </li></ul>   
               
           </ItemTemplate>
            </asp:DataList>
      </td>
      </tr>
</table>
 
                            
                    