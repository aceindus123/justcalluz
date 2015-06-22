<%@ Control Language="C#" AutoEventWireup="true" CodeFile="signin.ascx.cs" Inherits="usercontrol_signin" %>

<table border="0" style="width:990px; padding-bottom:5px; padding-top:10px;">
<tr>
    <td align="left" class="side_menu1">
        Welcome, &nbsp;<asp:Label ID="lblUName" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>&nbsp;&nbsp; 
    </td>
    <td id="tdLastLogin" runat="server" class="side_menu1">
        Your Last visit was on :&nbsp;<asp:Label ID="lblLastLogIn" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
    </td>
      <td id="td1" runat="server" class="side_menu1">
        IP Address :&nbsp;<asp:Label ID="lblIPaddress" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
    </td>
    <td id="tdMyProfile" runat="server" align="right" class="side_menu1">
        <a id="lnkBtnMyProfile" runat="server" onserverclick="lnkBtnMyProfile_Click" >
          <asp:Label ID="lblProfile" Text="My Profile" runat="server" Font-Underline="false"></asp:Label></a>
        <%--<asp:LinkButton ID="lnkBtnMyProfile" runat="server" Font-Underline="false" onclick="lnkBtnMyProfile_Click">My Profile</asp:LinkButton>--%>
        
    </td>
    <td id="tdPostCheck" runat="server" align="right" class="side_menu1">
         <a id="lnkBtnTocheckPostings" runat="server" onserverclick="lnkBtnTocheckPostings_Click" >
          <asp:Label ID="Label1" Text="To Check Postings" runat="server" Font-Underline="false"></asp:Label></a>
        <%--<asp:LinkButton ID="lnkBtnTocheckPostings" runat="server" Font-Underline="false" 
            onclick="lnkBtnTocheckPostings_Click" >To Check Postings</asp:LinkButton>--%>
    </td>
    <td align="right"><table><tr>
    <td><img alt="HomeIcon" src="images/icons/home-icon.png" width="16" height="16" /></td>
    <td class="side_menu1"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none" runat="server">Home</a></td>
      <td id="tdSignInImg" runat="server" align="right"><img alt="signinIcon" src="images/icons/login.png" width="16" height="16" /></td>
    <td id="tdSignIn" runat="server" align="right" class="side_menu1">
        <a id="login" href="<%$RouteUrl:RouteName=Signin,Qname=login%>" runat="server" style="text-decoration:none">Login</a>
    </td>
    <td id="tdSignUpImg" runat="server"><img alt="signupIcon" src="images/icons/sign-icon.png" width="16" height="16" /></td>
    <td id="tdSignUp" class="side_menu1" runat="server"><a id="signup" href="<%$RouteUrl:RouteName=register%>" style="text-decoration:none" runat="server">Sign Up</a></td>
    </tr></table></td>
    
    <td id="tdLogout" runat="server" align="right" class="side_menu1">
    <a id="logout" href="<%$RouteUrl:RouteName=logout%>" runat="server" style="text-decoration:none;">Logout</a>
    </td>   
</tr>

</table>
