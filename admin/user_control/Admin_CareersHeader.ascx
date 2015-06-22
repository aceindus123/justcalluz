<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersHeader.ascx.cs" Inherits="admin_user_control_Admin_CareersHeader" %>

<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%"  align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Careers Home</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" id="td1" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkBtnResumes" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false"
            onclick="lnkBtnResumes_Click">View Resumes</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" id="tdPostCareers" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnPostCareers" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false" onclick="lnkbtnPostCareers_Click">Post Careers</asp:LinkButton>
    </td>
  </tr>
</table>
