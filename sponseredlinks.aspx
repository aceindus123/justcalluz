<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sponseredlinks.aspx.cs" Inherits="sponseredlinks" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Justcalluz---Sponsored Links Page</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="innertext">
        <table border="0" style="border: 1px solid #336699">
          <tr>
            <td>
                <asp:DataList ID="DataList1"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="226px" >
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0">
                        <tr>
                            <td valign="top" style="color:orange; font-weight:bold; text-decoration:underline">
                               <%#DataBinder.Eval(Container.DataItem, "heading")%>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:justify">
                                <%#DataBinder.Eval(Container.DataItem, "heading1")%>
                            </td>
                        </tr>
                        <tr>
                            <td height="5px"></td>
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
