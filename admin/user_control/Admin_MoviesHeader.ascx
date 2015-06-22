<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_MoviesHeader.ascx.cs" Inherits="admin_user_control_Admin_MoviesHeader" %>

<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="17%" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Movies Home</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="28%" id="td1" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkBtnPostHallsData" runat="server" Font-Size="14px" onclick="lnkBtnPostHallsData_Click" 
      ForeColor="White" Font-Underline="false">Post Cinema Halls Data</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="35%" id="td2" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkBtnView" runat="server" onclick="lnkBtnView_Click"
     Font-Size="14px" ForeColor="White" Font-Underline="false" >View/Update Cinema Halls Data</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="20%" id="tdPostCareers" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnPostMovies" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false" 
            onclick="lnkbtnPostMovies_Click">Post Movies</asp:LinkButton>
    </td>
  </tr>
</table>