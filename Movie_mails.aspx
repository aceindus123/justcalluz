<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Movie_mails.aspx.cs" Inherits="Movie_mails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Dear <asp:Label ID="lblname" runat="server"></asp:Label><br /><br />
    
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Here is your requested information .<br /><br /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Contacts listed under&nbsp;&nbsp;&nbsp;<asp:Label ID="lblmovie" runat="server"></asp:Label>(&nbsp;<asp:Label ID="lbllang" runat="server"></asp:Label>&nbsp;)<br /><br />
           
         Note : Whenever you call please mention that you got information from justcalluz .
         <table width="350px" border="0">
         <tr><td>
         <asp:DataList ID="dlmoviemail" runat="server" Width="350px" AlternatingItemStyle-BackColor="Silver" BackColor="LightGray">
         <ItemTemplate>
         <table border="0" width="350px">
         <tr><td colspan="3" class="submenu">
         <%#DataBinder.Eval(Container.DataItem, "CinemaHall_Name")%>
         </td></tr>
         <tr><td></td></tr>
         <tr><td>
         Address 
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "address") %></td>
         </tr>
         <tr>
         <td>
         Ph.No
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "landphno") %></td>
         </tr>
         <tr><td>
         Fax
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "fax") %></td>
         </tr>
         <tr>
         <td>Mobile</td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "mob") %></td>
         </tr><tr><td>
         Timings
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "Timings") %></td>
         </tr>
         <tr>
         <td>
         Email
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "emailid") %></td>
         </tr>
         <tr>
         <td>
         Website
         </td>
         <td>:</td>
         <td><%#DataBinder.Eval(Container.DataItem, "URL") %></td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:DataList>
         </td></tr>
         </table>
         
    </div>
    </form>
</body>
</html>
