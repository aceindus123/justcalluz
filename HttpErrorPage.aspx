<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HttpErrorPage.aspx.cs" Inherits="HttpErrorPage" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="logo" align="center">
<aa2:topimage ID="iud" runat="server" />
</div>
    <div>
    <table width="100%">
    <tr><td style="height:30px;"></td></tr>
    <tr>
    <td colspan="3" align="center">
    <b>Sorry for the inconvenience!</b><br /><br />
    Some problem occured while processing the site <br />
    Justcalluz team solves the problem As Early As Possible ..<br /><br />
    </td>
    </tr>
    <tr><td colspan="3" align="center"><asp:ImageButton ID="imgback" runat="server" onclick="imgback_Click" ImageUrl="images/bck.png"/></td></tr>
    </table>

    </div>
    </form>
</body>
</html>
