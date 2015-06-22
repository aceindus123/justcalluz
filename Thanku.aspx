<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Thanku.aspx.cs" Inherits="Thanku" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>

    <form id="form1" runat="server">
     <input type="hidden" name="rm" value="2"/>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <input type="hidden" name="rm" value="2"/>
    <input type="hidden" name="notify_url" value="http://www.justcalluz.com/Ipn_Message.aspx" />
     <input type="hidden" name="retun" value="http://www.justcalluz.com/Ipn_Message.aspx" />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </form>
</body>
</html>
