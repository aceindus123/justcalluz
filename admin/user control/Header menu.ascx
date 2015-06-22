<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header menu.ascx.cs" Inherits="user_control_Header_menu" %>
<style type="text/css">
     .style1
     {
         width: 404px;
     }
</style>

<table width="970" cellspacing="0" cellpadding="0">
<tr align="right">
<td>
<asp:Label ID="l1" runat="server" Text="LogIn:" Font-Size="Larger"></asp:Label>
<asp:Label ID="l2" runat="server" Font-Size="Larger"></asp:Label>
</td>
</tr>
  <tr>
  <%--style="padding-left:15px" class="style1"--%>
    <td align="left" >
        <img src="images/Adimin control.jpg" ></td>
      <%--  width="400" border="0" 
            style="height: 120px"--%>
           <%-- style="padding-right:15px; font-size:25px"--%>
    <td align="right" class="ent2" >
    </td>
  </tr>
  <tr>
    <td style="height:3px; background-color:#CC0000" colspan="2"></td>
  </tr>
</table>