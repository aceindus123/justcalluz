<%@ Control Language="C#" AutoEventWireup="true" CodeFile="catageoriescenter.ascx.cs" Inherits="usercontrols_catageoriescenter" %>
<td width="425" valign="top">
<table width="425" border="0" cellpadding="0" cellspacing="0" align="center" class="middle">

<tr><td class="refinedsearch"><b><a href="#" style="color:#FFF; text-decoration:none;">Home>></a>Categories</b></td></tr></table>

<table width="405" border="1" height="810" bordercolor="#003366" cellpadding="0" cellspacing="0" style="margin-top:8px;">

<tr><td class="text" style="text-align:center;" valign="top"><b>Result for :<font color="#336633"> Categories in Hyderabad</font>
</b>


<%--<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>--%>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
    </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
    <ContentTemplate>
   

   
    <asp:Panel ID="Panel1" runat="server">
    
<table width="425" border="0">
<tr>
<td>
<table border="1" bordercolor="#999999" cellpadding="0" cellspacing="0" width="400" align="center" >
<tr>
<td class="text" style="font-weight:bold;">
    <asp:Button ID="Button1" runat="server" Text="A-C" BorderStyle="None" BackColor="White"  Font-Size="Small" onclick="Button1_Click" />&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="D-F"  BorderStyle="None" BackColor="White" Font-Size="Small"  onclick="Button2_Click" />&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="G-I"  BorderStyle="None" BackColor="White" Font-Size="Small"  onclick="Button3_Click" />&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="J-L"  BorderStyle="None" BackColor="White" Font-Size="Small"  onclick="Button4_Click" />&nbsp;&nbsp;&nbsp;


    <asp:Button ID="Button5" runat="server" Text="M-O"  BorderStyle="None" BackColor="White" Font-Size="small"  onclick="Button5_Click" />&nbsp;&nbsp;&nbsp;
    
    <asp:Button ID="Button6" runat="server" Text="P-R"  BorderStyle="None" BackColor="White" Font-Size="small"  onclick="Button6_Click" />&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button7" runat="server" Text="S-U"  BorderStyle="None" BackColor="White" Font-Size="small"  onclick="Button7_Click" />&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" Text="V-Z"  BorderStyle="None" BackColor="White" Font-Size="small"  onclick="Button8_Click" />&nbsp;&nbsp;&nbsp;
    
</tr></table>
</td></tr>

</table>

</asp:Panel>

<asp:Panel ID="Panel2" runat="server">
   <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList1"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList1_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varac")%>'
                                 Text ='<%# Eval("varac") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
</asp:Panel>





    
    
 <asp:Panel ID="Panel3" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList2"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList2_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("vardf")%>'
                                 Text ='<%# Eval("vardf") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
 </asp:Panel>
    
    
    

 <asp:Panel ID="Panel4" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList3"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList3_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("vargi")%>'
                                 Text ='<%# Eval("vargi") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    
 </asp:Panel>


    <asp:Panel ID="Panel5" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList4"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList4_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varjl")%>'
                                 Text ='<%# Eval("varjl") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    </asp:Panel>
    
    
    <asp:Panel ID="Panel6" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList5"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList5_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varmo")%>'
                                 Text ='<%# Eval("varmo") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    
    </asp:Panel>
    
    <asp:Panel ID="Panel7" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList6"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList6_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varpr")%>'
                                 Text ='<%# Eval("varpr") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    
    </asp:Panel>
    
    <asp:Panel ID="Panel8" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList7"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList7_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varsu")%>'
                                 Text ='<%# Eval("varsu") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    
    </asp:Panel>
    
    
    <asp:Panel ID="Panel9" runat="server">
     <table border="1" cellpadding="0" cellspacing="0" width="400px" align="center" height="200" bordercolor="#999999" style="margin-top:10px; margin-bottom:10px;">
    <tr>
        <td valign="top"> 
            <asp:DataList ID="DataList8"   RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="3" runat="server" 
                                Height="120px" Width="0px" OnItemCommand="DataList8_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="0" height="25px">
                        <tr>
                            <td><img src="images/arrow2.jpg" /></td>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("varvz")%>'
                                 Text ='<%# Eval("varvz") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
         </td>       
    </tr>
  </table>  
    </asp:Panel>
    
    
    
    
    </ContentTemplate>
    </asp:UpdatePanel>
     
    
    
</td></tr></table>
<!--end of 2 column-->


<!--end of3 column-->
</td>