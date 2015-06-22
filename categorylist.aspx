<%@ Page Language="C#" AutoEventWireup="true" CodeFile="categorylist.aspx.cs" Inherits="categorylist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz - Category List Page</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="innertext">
        <table border="0">
        <tr>
           <td class="text" valign="top" align="left">
                <b style="color:orange"><u><asp:Label ID="Label1" runat="server" Text="Category List"></asp:Label></u></b>
           </td>
       </tr>
       <tr><td height="5px"></td></tr>
       <tr>
            <td>
                <asp:DataList ID="DataList1"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="226px" >
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0">
                        <tr>
                            <td><img src="images/arrow1.jpg" />&nbsp;&nbsp;</td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server">
                                    <%#DataBinder.Eval(Container.DataItem, "category")%>
                                </asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td height="10px"></td>
                        </tr>
                    </table>
                    </div>
               </ItemTemplate>
                </asp:DataList>
          </td>
       </tr>
    </table>
    </div>
   </form>
</body>
</html>
