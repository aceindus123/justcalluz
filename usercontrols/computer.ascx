<%@ Control Language="C#" AutoEventWireup="true" CodeFile="computer.ascx.cs" Inherits="usercontrol_computer" %>

<%--<table width="100%" border="0" cellpadding="0" cellspacing="0" align="center" style=" margin-left:0px;">

<tr>
    <td style="width:226px; padding-left:100px" align="center" >
        <asp:DataList ID="DataList1" RepeatDirection="Horizontal" RepeatColumns="6" CellPadding="4"  runat="server" 
                        Height="50px" Width="226px" OnItemCommand="DataList1_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0" height="25px" width="100px">
                        <tr>
                            <td valign="top" align="center">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("category")%>'
                                 Text ='<%# Eval("category") %>' CommandName="select" Font-Underline="false">
                                   
                                </asp:LinkButton>
                            </td>
                            <td>|</td>
                        </tr>
                    </table>
               </ItemTemplate>
                </asp:DataList>
       
    </td>
    <td style="padding-top:9px">
        
        &nbsp;&nbsp;&nbsp;&nbsp; <a href="jobs.aspx" style="text-decoration:none;">Jobs</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="Events.aspx" style="text-decoration:none;">Events</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="Discounts.aspx" style="text-decoration:none;">Discounts</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
</tr>
<tr><td height="30px"></td></tr>
</table>--%>
<table width="80%" border="0">
  <tr>
    <td width="9%" align="left">
   <%-- <a href="#">Builders</a>--%>
    <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="Category" CommandArgument="Education & Training" Font-Underline="false" ForeColor="Green">Education</asp:LinkButton>      
    </td>
    <td width="4%"><strong>|</strong></td>
    <td width="11%" align="left">
    <asp:LinkButton ID="LinkButton2" runat="server" OnCommand="Category" CommandArgument="Travel Services" Font-Underline="false" ForeColor="Green">Travel</asp:LinkButton>      
    <%--<a href="#">Computer</a>--%>
    </td>
    <td width="4%"><strong>|</strong></td>
    <td width="11%" align="left">
    <asp:LinkButton ID="LinkButton3" runat="server" OnCommand="Category" CommandArgument="Computers & Peripherals" Font-Underline="false" ForeColor="Green">Computer</asp:LinkButton>      
    <%--<a href="#">Education</a>--%>
    </td>
    <td width="4%"><strong>|</strong></td>
    <td width="9%" align="left">
    <asp:LinkButton ID="LinkButton4" runat="server" OnCommand="Category" CommandArgument="Real Estate" Font-Underline="false" ForeColor="Green">Real Estate</asp:LinkButton>            
    <%--<a href="#">Travel</a>--%>
    </td>   
    <td width="3%"><strong>|</strong></td>
    <td width="6%" align="left">
    <a href="Jobs.aspx" target="_blank" style="text-decoration:none"><font color="Green">Jobs</font></a>
    </td>
    <td width="4%"><strong>|</strong></td>
    <td width="8%" align="left">
    <a href="Events.aspx" target="_blank" style="text-decoration:none"><font color="Green">Events</font></a>
    </td>
    <td width="4%"><strong>|</strong></td>
    <td width="10%" align="left">
    <a href="Discounts.aspx" target="_blank" style="text-decoration:none"><font color="Green">Discounts</font></a>
    </td>
  </tr>
</table>

    