<%@ Control Language="C#" AutoEventWireup="true" CodeFile="boxes3.ascx.cs" Inherits="usercontrols_boxes3" %>




   
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <%--<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    </asp:UpdateProgress>--%>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
    <ContentTemplate>
   
   
  <table border="0" cellpadding="0" cellspacing="0" style="width: 939px">
  
<tr>
<td width="40">&nbsp;</td>
<td width="150" class="text" style="color:#cc6600; font-weight:bold;">Select city</td> 
<td width="100" class="text" style="color:#cc6600; font-weight:bold;">Search for</td>
<td width="15">
    <asp:RadioButton ID="rb1comp" runat="server" GroupName="r1" /></td>
<td width="100" class="text" style="color:#cc6600; font-weight:bold;">Companyname</td>
<td width="15">
    <asp:RadioButton ID="rb2cat" runat="server" GroupName="r1" Checked="true" /></td>
<td width="80" class="text" style="color:#cc6600; font-weight:bold;">Catageory</td>
<td width="65" class="text" style="color:#cc6600; font-weight:bold;">Where in &nbsp;</td>
<td width="90" align="left" style=" color:#cc6600; font-weight:bold;">
    <asp:Label ID="Label10" runat="server" Width="130px" Height="20px"></asp:Label></td>
<!--end of text-->
</tr>
</table>
   
   

<table width="960" border="0" cellpadding="0" cellspacing="0">
<tr>

<td width="10">&nbsp;</td>
<td class="rectangle">
<!--begin of innertext-->
<table width="900" border="0" cellpadding="0" cellspacing="0" align="center">
<tr>
<td >
   <%-- <asp:TextBox ID="TextBox1" runat="server" Width="170px" Text="Select City" ForeColor="black" Font-Size="14px" Font-Bold="true"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/downarrow5.jpg" onclick="ImageButton1_Click1" />--%>
       <%-- <asp:Button ID="Button2" runat="server" Text="V" />--%>
       <asp:Panel ID="Panel2" runat="server" BorderWidth="1px" BorderColor="#336699" 
            Height="25px" Width="164px">
        
    <table style="height: 25px"><tr><td>
        <asp:TextBox ID="TextBox1" runat="server" BorderColor="White" 
            BorderStyle="None" Text="Select City" Height="16px" Width="126px"></asp:TextBox></td>
         <td> 
             <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/downarrow5.jpg" 
                 onclick="ImageButton1_Click" style="width: 20px" Width="20px" />
        </td>
    </tr></table>
    </asp:Panel>
</td>
<td ><asp:TextBox ID="TextBox2" runat="server" Width="387px" ForeColor="black" Font-Bold="true"></asp:TextBox></td>
<td>
    <asp:TextBox ID="TextBox3" runat="server" Width="163px" ForeColor="black" Font-Bold="true"></asp:TextBox></td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Search" ForeColor="maroon" 
            Font-Bold="true" BackColor="YellowGreen" onclick="Button1_Click" /></td>
   
<!--end of inner text-->

</tr>
</table>
</td>
<!--end of the rectanglebox-->
</tr>
</table>


<asp:panel ID="Panel1" runat="server" BorderWidth="1" BorderColor="Blue"
        style=" position: absolute; width: 700px; height: 312px;  left: 58px; top: 310px;" 
        BackColor="White">
        
        <table border="0" bordercolor="#003366" cellpadding="0" cellspacing="0" width="765" align="left">
    <tr>
    <td valign="top">
    
        <asp:Panel ID="pnlAtoZ" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 680px">
        
         <tr>
       <%-- <td class="style1" align="right" colspan="18">
            </td>--%>
        <td align="right" width="980" colspan="2">
            <asp:Button ID="Button3" runat="server" Text="X" Font-Size="Medium"  
                BackColor="White" BorderStyle="None"
                Width="33px"  ForeColor="Red" Font-Bold="true" />
         </td>
        </tr>
        <tr>
            <td height="10" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="All Cities: 410" ForeColor="Orange" Font-Bold="true" Font-Size="12px" Font-Names="Arial, Helvetica, sans-serif"></asp:Label>
            </td>
        </tr>
        <tr><td></td></tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label2" runat="server" Text="Popular Cities" ForeColor="Orange" Font-Bold="true" Font-Size="12px" Font-Names="Arial, Helvetica, sans-serif"></asp:Label>
            </td>
            <td>
                <asp:LinkButton ID="A" runat="server" Text="A" Font-Underline="true" Font-Overline="false" 
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="A_Click1"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="B" runat="server" Text="B" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="B_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="C" runat="server" Text="C" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="C_Click"></asp:LinkButton>&nbsp;
             
                 <asp:LinkButton ID="D" runat="server" Text="D" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="D_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="E" runat="server" Text="E" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="E_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="F" runat="server" Text="F" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="F_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="G" runat="server" Text="G" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="G_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="H" runat="server" Text="H" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="H_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="I" runat="server" Text="I" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="I_Click"></asp:LinkButton>&nbsp;
          
                <asp:LinkButton ID="J" runat="server" Text="J" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="J_Click"></asp:LinkButton>&nbsp;
          
                <asp:LinkButton ID="K" runat="server" Text="K" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" onclick="K_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="L" runat="server" Text="L" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="L_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="M" runat="server" Text="M" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="M_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="N" runat="server" Text="N" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="N_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="O" runat="server" Text="O" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="O_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="P" runat="server" Text="P" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="P_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="Q" runat="server" Text="Q" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="Q_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="R" runat="server" Text="R" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="R_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="S" runat="server" Text="S" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="S_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="T" runat="server" Text="T" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="T_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="U" runat="server" Text="U" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="U_Click"></asp:LinkButton>&nbsp;
           
                <asp:LinkButton ID="V" runat="server"  Text="V"  Font-Bold="true"  Font-Underline="true"
                    Font-Overline="false" ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Size="12px" onclick="V_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="W" runat="server" Text="W" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="W_Click"></asp:LinkButton>&nbsp;
            
                <asp:LinkButton ID="Y" runat="server" Text="Y" Font-Overline="false"  Font-Underline="true"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" onclick="Y_Click"></asp:LinkButton>
            </td>
      </tr>
      <tr><td  height="10"></td></tr>
        </table>
        
        
        
        </asp:Panel>
        
      
        
        <table width="" border="0" cellpadding="0" cellspacing="0"> 
        <tr>
        <td>
            <asp:Panel ID="pnlcities" runat="server">
            <table width="110px" border="0" cellpadding="0" cellspacing="0" style="height: 200px; border-right: 2px dashed #ccc;">
                <tr>
                    <td>
                        <asp:DataList ID="dlpopcities"   RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="50px" OnItemCommand="dlpopcities_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="panel3">
                        <table border="0" width="" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("popcities")%>'
                                     Text ='<%# Eval("popcities") %>' CommandName="select">
                                       
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
        </td>
        <td valign="top" align="left">
            <asp:Panel ID="pnlA" runat="server">
              <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesA"   RepeatDirection="Horizontal" RepeatColumns="4" 
                        CellPadding="0"  runat="server" 
                            Height="117px" Width="71px" OnItemCommand="dlcitiesA_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="" height="20px">
                            <tr>
                                <td valign="top">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("A")%>'
                                     Text ='<%# Eval("A") %>' CommandName="select">
                                       
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
          
            <asp:Panel ID="pnlB" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
                    <tr>
                        <td align="left">
                            <asp:DataList ID="dlcitiesB"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                                    Height="117px" Width="100px" OnItemCommand="dlcitiesB_ItemCommand"> 
                            <HeaderTemplate>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <div class="innertext">
                                <table border="0" width="50px" height="20px">
                                    <tr>
                                        <td valign="top">
                                            
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("B")%>'
                                             Text ='<%# Eval("B") %>' CommandName="select">
                                               
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
          
            <asp:Panel ID="pnlC" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesC"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesC_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("C")%>'
                                     Text ='<%# Eval("C") %>' CommandName="select">
                                       
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
          
            <asp:Panel ID="pnlD" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesD"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesD_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("D")%>'
                                     Text ='<%# Eval("D") %>' CommandName="select">
                                       
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
        
            <asp:Panel ID="pnlE" runat="server" align="left">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesE"   RepeatDirection="Vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesE_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("E")%>'
                                     Text ='<%# Eval("E") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlF" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesF"   RepeatDirection="Vertical"  RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesF_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("F")%>'
                                     Text ='<%# Eval("F") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlG" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesG"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesG_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("G")%>'
                                     Text ='<%# Eval("G") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlH" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesH"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesH_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("H")%>'
                                     Text ='<%# Eval("H") %>' CommandName="select">
                                       
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
        
            <asp:Panel ID="pnlI" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesI"   RepeatDirection="Vertical"  RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesI_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("I")%>'
                                     Text ='<%# Eval("I") %>' CommandName="select">
                                       
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
        
            <asp:Panel ID="pnlJ" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesJ"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesJ_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("J")%>'
                                     Text ='<%# Eval("J") %>' CommandName="select">
                                       
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
           
            <asp:Panel ID="pnlK" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesK"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesK_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("K")%>'
                                     Text ='<%# Eval("K") %>' CommandName="select">
                                       
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
        
            <asp:Panel ID="pnlL" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesL"   RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesL_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("L")%>'
                                     Text ='<%# Eval("L") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlM" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesM"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesM_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("M")%>'
                                     Text ='<%# Eval("M") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlN" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesN"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesN_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("N")%>'
                                     Text ='<%# Eval("N") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlO" runat="server">
               <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesO" RepeatDirection="Vertical"  RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesO_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("O")%>'
                                     Text ='<%# Eval("O") %>' CommandName="select">
                                       
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
           
            <asp:Panel ID="pnlP" runat="server">
               <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesP"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesP_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("P")%>'
                                     Text ='<%# Eval("P") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlQ" runat="server">
               <table border="0" cellpadding="0" cellspacing="0" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left" valign="top">
                    <asp:DataList ID="dlcitiesQ" RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesQ_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("Q")%>'
                                     Text ='<%# Eval("Q") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlR" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesR"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesR_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("R")%>'
                                     Text ='<%# Eval("R") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlS" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesS"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesS_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("S")%>'
                                     Text ='<%# Eval("S") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlT" runat="server">
                 <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesT"   RepeatDirection="Horizontal" RepeatColumns="4" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesT_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("T")%>'
                                     Text ='<%# Eval("T") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlU" runat="server">
              <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width:450px" align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesU" RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesU_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("U")%>'
                                     Text ='<%# Eval("U") %>' CommandName="select">
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
            
            <asp:Panel ID="pnlV" runat="server">
               <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesV"   RepeatDirection="Horizontal" RepeatColumns="3" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesV_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("v")%>'
                                     Text ='<%# Eval("v") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlW" runat="server">
               <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesW" RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesW_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("W")%>'
                                     Text ='<%# Eval("W") %>' CommandName="select">
                                       
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
            
            <asp:Panel ID="pnlY" runat="server">
             <table border="0" cellpadding="0" cellspacing="0" valign="top" style="width: 100px" 
                    align="left">
            <tr>
                <td align="left">
                    <asp:DataList ID="dlcitiesY" RepeatDirection="vertical" RepeatColumns="1" CellPadding="0"  runat="server" 
                            Height="117px" Width="100px" OnItemCommand="dlcitiesY_ItemCommand"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="innertext">
                        <table border="0" width="50px" height="20px">
                            <tr>
                                <td valign="top">
                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("Y")%>'
                                     Text ='<%# Eval("Y") %>' CommandName="select">
                                       
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
            
        </td>
        </tr></table>
        
         </td>
        </tr>
    </table>
        </asp:panel>
 
 <asp:DataList ID="DataList1" DataKeyField="id" runat="server" Width="290px" Height="400px"
        style="margin-left: 0px" >
          <HeaderTemplate>
            <table>
            
        </HeaderTemplate>
          <ItemTemplate>
            <tr>
                <td valign="top">
                    <table width="45%">
                        <tr>
                            <td>
                            </td>
                        </tr>
                         <tr>
                            <td width="25%" valign="top" align="left"  style="border: 1px solid green; background-color:#FFFFcc; padding: 2px;">
                            
                               <%-- <asp:Panel ID="Panel1" runat="server" Width="25%">--%>
                            
                                   <table width="70%" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td class="dashboardbg" style=" padding:10px;">
                                            <table cellpadding="0Px" cellspacing="0px" width="370PX" align="center">
                                               <tr>
                                                   <td valign="top" width="24%">
                                                       <div style="padding: 0px; margin: 0px;">
                                                                <table>
                                                                    <tr>
                                                                    
                                                                        <td width="18%"  style="font-family: Arial; font-size: 12px; font-weight: bold;
                                                                            text-align: left; color: #007ab8;">
                                                                           Name&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                       
                                                                        <td width="31%" class="dbtextcolr" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold">
                                                                           <%-- <asp:Literal ID="Literal6" runat="server" Text='<%#Eval("id")%>' />--%>
                                                                          
                                                                       <asp:LinkButton  ID="Linkbutton2"    ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("computers1.aspx?val={0}", Eval("id")) %>' 
                                                                             Text ='<%# Eval("cname") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>
                                                                        </tr>
                                                                     <tr>
                                                                        <td></td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td width="18%" style="font-family: Arial; font-size: 12px; font-weight: bold; text-align: left;
                                                                            color: #007ab8;">
                                                                            Categeory&nbsp;&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                        <td width="31%" class="dbtextcolr" style="color:#993333; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            <asp:Literal ID="Literal7" runat="server" Text='<%#Eval("cat")%>' />
                                                                        </td>
                                                                        </tr>
                                                                     <tr><td></td></tr> 
                                                                     <tr>
                                                                        <td width="18%" style="font-family: Arial; font-size: 12px; font-weight: bold; text-align: left;
                                                                            color: #007ab8; ">
                                                                           Area
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                        <td width="31%" class="dbtextcolr" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            <asp:Literal ID="Literal8" runat="server" Text='<%#Eval("area")%>' />
                                                                           
                                                                        </td>
                                                                    </tr>
                                                                    <tr><td></td></tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table>
                                                                             <tr>
                                                                                <td align="right">
                                                                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/phone icon.jpg" /></td>
                                                                                <td width="11%" class="dbtextcolr" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold" align="left">
                                                                                <asp:Label ID="literal12" runat="server" Text='<%#Eval("mob")%>' />
                                                                               
                                                                                  <%--<asp:Button ID="Button1" runat="server" Text="View Mobile" BackColor="#ffcc99"
                                                                                  BorderColor="White"  BorderStyle="None" />--%>
                                                                                </td>
                                                                       
                                                                             </tr>
                                                                             </table>
                                                                        </td>
                                                                    </tr>
                                                                  </table>           
                                                           </div>
                                                   </td>
                                               </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr><td height="5px">&nbsp;</td></tr>
                                    <tr>
                                        <td  colspan="2" align="right">
                                            <table>
                                                <tr>
                                                <td>
                                                   <asp:ImageButton ID="img1" runat="server" ImageUrl="~/images/send emali.jpg" />
                                                </td>
                                                <td width="25"></td>
                                                <td>
                                                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/send sms.jpg" />
                                                </td>
                                                  <td width="25"></td>
                                                 <td >
                                                     <asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# "computers1.aspx?id=" + Eval("id").ToString() %>' ></asp:HyperLink>
                                              
                                                        <%-- <asp:LinkButton  ID="Linkbutton1" runat="server" PostBackUrl='<%# string.Format("computers1.aspx?val={0}", Eval("id")) %>' Font-Overline="false" 

                                                   Text ="view details"  CommandName ="Select" >
--%>
                                                          </asp:LinkButton>
                                               </td>
                                                    
                                                    <td>&nbsp;</td>
                                                   <td >
                                                   </td>
                                                    
                                                    <td>&nbsp;</td>
                                                    <td >
                                                     </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                   
                                                    <td>
                                                     </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     
                                    <tr>
                                        <td height="5px">
                                            &nbsp;
                                        </td>
                                    </tr>
                                     
                                     
                                    <%--databound end--%>
                                 </table>
                               
                            </td>
                         </tr>
                     
                    </table>
                </td>
            </tr>
            
            
            
            
          <%--  <cc1:ModalPopupExtender ID="ModalPopupExtender" runat="server"  
        TargetControlID="img1" PopupControlID="Panel3" BackgroundCssClass="modalBackground" 
        OkControlID="submitbutton" CancelControlID="cancelbutton" 
        DropShadow="false" PopupDragHandleControlID="panel4" ></cc1:ModalPopupExtender>
        
        
        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
        TargetControlID="ImageButton2" PopupControlID="Panel5" BackgroundCssClass="modalBackground" 
        OkControlID="postbutton" CancelControlID="resetbutton" 
        DropShadow="false" PopupDragHandleControlID="panel6" ></cc1:ModalPopupExtender>--%>
     
                       
        </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
        
        
        </asp:DataList>
        
        
        
 
 <asp:DataList ID="dlcat"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="226px" OnItemCommand="dlcat_ItemCommand" > 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext">
                    <table border="1" height="45" width="226px">
                        <tr>
                            <%--<td><%#DataBinder.Eval(Container.DataItem, "symbol")%></td>--%>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("cat")%>'
                                 Text ='<%# Eval("cat") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
                </asp:DataList>
 
 
 
 
 
 
 
 
 
</ContentTemplate>
    </asp:UpdatePanel>
    
        