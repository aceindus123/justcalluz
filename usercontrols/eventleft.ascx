<%@ Control Language="C#" AutoEventWireup="true" CodeFile="eventleft.ascx.cs" Inherits="usercontrols_eventleft" %>
 
 <table width="100%" border="0">
  <tr>
    <td width="40%" style=" color:#003366; font-size:12px; font-family:Arial ;padding-left:0px" class="side_menu" >
        <asp:DataList ID="dlevent" runat="server" RepeatDirection="Horizontal" 
                        RepeatColumns="1" cellspacing="0" CellPadding="0" Width="165px" 
            Font-Size="Small" onitemdatabound="dlevent_ItemDataBound">                                                
          <ItemTemplate>

           <ul>  
                                                                                       
             <li>          
             
              <%--<asp:Button ID="btnEcat" runat="server" CommandArgument='<%#Eval("cat") %>' Text='<%#Eval("Ecatname") %>' 
                    CommandName="select" BorderStyle="None" BackColor="#f8f9fa" CssClass="pointer" ToolTip='<%#Eval("cat") %>' />--%>
                    <asp:HyperLink ID="Hypcate" runat="server" Text='<%# Eval("Ecatname") %>' NavigateUrl='<%# GeteventUrl(Eval("cat")) %>'
                           ToolTip='<%# Eval("cat") %>'></asp:HyperLink>
              
             </li>
             
            </ul>      
            </ItemTemplate>                            
        </asp:DataList> 
     </td>
   </tr>                                                       
</table>
                                    
                    