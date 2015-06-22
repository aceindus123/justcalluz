<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EL_LeftMenu.ascx.cs" Inherits="usercontrols_EL_LeftMenu" %>
<table width="100%" border="0">
      <tr>
        <td class="mobile" style="background: url(images/edit_listing.png) no-repeat top; height:35px; color:#036; padding-left:10px;">Business Information</td>
      </tr>
      <tr>
        <td><ul>
          <li  class="current">
              <asp:LinkButton ID="lnkLocaton" runat="server" Font-Underline="false" 
                  onclick="lnkLocaton_Click">Location Information</asp:LinkButton>
          </li>
          <li>
           <asp:LinkButton ID="lnkcontactinfo" runat="server" Font-Underline="false" 
                  onclick="lnkcontactinfo_Click">Contact Information</asp:LinkButton>
         </li>
          <li>
           <asp:LinkButton ID="lnkotherinfo" runat="server" Font-Underline="false" 
                  onclick="lnkotherinfo_Click">Other Information</asp:LinkButton>
          </li>
          <li>
           <asp:LinkButton ID="lnkbusikeywrds" runat="server" Font-Underline="false" 
                  onclick="lnkbusikeywrds_Click">Business Keywords</asp:LinkButton>
          <ul>
          <li style="border:0px;">
           <asp:LinkButton ID="lnkaddremwrd" runat="server" Font-Underline="false" 
                  onclick="lnkaddremwrd_Click">View/Remove Keywords</asp:LinkButton>
         </li>
          <li style="border:0px;">
           <asp:LinkButton ID="lnkadd" runat="server" Font-Underline="false" 
                  onclick="lnkadd_Click">Add Keywords</asp:LinkButton>
         </li>
         </ul>
               
          </li>
          <li><a href="#">Upload Video/Logo/Pictures</a></li></ul></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
         <td class="mobile" style="background: url(images/edit_listing.png) no-repeat top; height:35px; color:#036; padding-left:10px;">Service Request</td> 
      </tr>
      <tr>
        <td><ul><li><a href="#">ECS/CCSI Activate/Deactivate</a></li>
          <li><a href="#">Submit An Online Request / Complaint</a></li>
          </ul></td>
      </tr>
      <tr>
        <td>
</td>
      </tr>
    </table>