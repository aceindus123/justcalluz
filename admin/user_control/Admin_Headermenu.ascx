<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_Headermenu.ascx.cs" Inherits="user_control_Header_menu" %>
<style type="text/css">
     .style1
     {
         width: 404px;
     }
</style>

<table width="970" cellspacing="0" cellpadding="0">
<tr>
<td width="50%">
<asp:Label ID="lblName" runat="server" ForeColor="CadetBlue"></asp:Label>
</td>
<td align="right" width="20%">
    <asp:LinkButton ID="lnkProfile" runat="server" onclick="lnkProfile_Click" ForeColor="Maroon" Font-Bold="true" Font-Size="16px" Font-Underline="false">Profile/Security</asp:LinkButton>
</td>
<td id="tdLogout" runat="server" align="right" width="30%">
<asp:Label ID="l1" runat="server" Text="Login:" Font-Size="16px"></asp:Label>
<asp:Label ID="l2" runat="server" Font-Size="Larger"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
<a id="A2" href="~/admin/Admin_Logout.aspx" runat="server" style="color:Maroon; font-size:16px; text-decoration:none;">Logout</a>
</td>   
</tr>
  <tr>
  <%--style="padding-left:15px" class="style1"--%>
    <td align="left" colspan="3" >
    <asp:ImageButton ID="btnLogo" runat="server" ImageUrl="../images/Adimin control.jpg" OnClick="btnLogo_Click" />
        <%--<a href="Admin-MainPage.aspx"><img src="images/Adimin control.jpg" ></a>--%>
        
        </td>
      <%--  width="400" border="0" 
            style="height: 120px"--%>
           <%-- style="padding-right:15px; font-size:25px"--%>
    <td align="right" class="ent2" >
    </td>
  </tr>
  <tr>
    <td style="height:3px; background-color:#CC0000" colspan="4"></td>
  </tr>
</table>