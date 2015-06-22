<%@ Control Language="C#" AutoEventWireup="true" CodeFile="discount_right.ascx.cs" Inherits="usercontrols_discount_right" %>
<table width="100%" border="0">
  <tr>
    <td valign="top">
<table width="100%" border="0" >
<tr>
<td>
              <asp:DataList ID="DataList3"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="160px">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0" width="160px">
                        <tr>
                            <td valign="top" height="15px" class="right_tab">
                               <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Text='<%# Eval("heading") %>' NavigateUrl='<%# Eval("website") %>'>                            
                             </asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:justify;padding-left:10px" class="headings1">
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
<tr>
    <td style="padding-left:3px; padding-top:5px;"><asp:Image ID="imgcities" runat="server" ImageUrl="~/images/Discounts_area.png" Width="132" Height="32" /></td>
  </tr>
  
  
  <tr>
    <td style="padding-left:10px">
    <asp:DataList ID="dlcities" runat="server" onitemcommand="dlcities_ItemCommand" >
    <ItemTemplate>
    <asp:LinkButton ID="cityevents" runat="server" CommandArgument='<%#Eval("popcities") %>' Text='<%#Eval("popcities") %>' CommandName="select" ForeColor="#003366" Font-Names="Arial"></asp:LinkButton>           
    </ItemTemplate>
    </asp:DataList>
    </td>
  </tr>
  <tr>
    <td style="padding-top:5px;" class="side_menu">Made in the USA, the Classic <br/> is perfect for corporate <br/>promotional events   and <br/> incentive travel groups. <br/>Similar to Havaianas brand <br/>rubber <strong>flip   flops.</strong> </td>
  </tr>
</table>
</td>
  </tr>
</table>
