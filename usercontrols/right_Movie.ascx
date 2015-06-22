<%@ Control Language="C#" AutoEventWireup="true" CodeFile="right_Movie.ascx.cs" Inherits="usercontrols_right_Movie" %>
<table width="100%">
<tr>
<td>
<asp:DataList ID="dlMovieslangright" DataKeyField="Movie_Name" runat="server" Width="100%" 
                        BorderColor="Brown" BorderWidth="1px"
    style="margin-left: 0px" onitemcommand="dlMovieslangright_ItemCommand">
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%" border="0px" id="Movie">
                            <tr style="background-color:#D9F2FF;">
                            <td width="74%" class="movie" style="font-weight:none;">                                                       
                            <asp:Label ID="Movie_name" runat="server" Text='<%#Eval("Movie_Language")%>' Font-Size="17px"></asp:Label>  
                            &nbsp;                      
                            </td>
                           
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                            </tr>
                            <%--<tr>
        <td style="border-bottom:1px solid #666;">
        
</td>
      </tr>--%>
       <tr>
        <td style="border-bottom:1px solid #666;" colspan="3">
       </td>
      </tr>
                            <tr>
                            <td style="padding-left:5px;border-bottom:1px solid #666;" colspan="3">
                            <asp:DataList ID="dlMovieright" runat="server" DataSource='<%# getMovies(Convert.ToString(Eval("Movie_Language"))) %>' Width="100%">
                                <EditItemStyle ForeColor="#CC3300" />
                                <AlternatingItemStyle ForeColor="#CC3300" />
                                <SelectedItemStyle ForeColor="#CC3300" />
                                <ItemTemplate>      
                                <table border="0px" width="100%" style="border-bottom-width:thin; border-bottom-color:Gray;">
                                    <tr>
                                        <td style="line-height:2;" colspan="2">
                                             <asp:Button ID="lnkmoviename" runat="server" Font-Size="13px" Text='<%#Eval("Movie_Name")%>' BorderStyle="None" BackColor="White" CssClass="pointer" 
                                               CommandArgument='<%#Eval("Movie_Name") + "," + Eval("Movie_Language")%>' OnCommand="getfilm" Font-Underline="false" Font-Names="Arial" />                                            
                                             &nbsp;                                             
                                                                                                                          
                           
                                        </td>  
                                                                            
                                    </tr>
                                    
                                </table>                                                                        
                                </ItemTemplate>
                            </asp:DataList>
                             </td>
                            </tr>
                            </table>
                        </ItemTemplate>                        
                    </asp:DataList>
                    </td></tr></table>

<%--<table width="100%" border="0" style="background-color:#D9F2FF; border:1px solid #666;" height="278" >
    <tr>
      <td height="36"  style="background: #FFDECE;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie">Hindi Movies</td>
  </tr>
</table>
</td>
    </tr>
    <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dlhindi" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' CommandArgument='<%#Eval("mid") %>' OnCommand="Hindi"></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
   <tr>
      <td height="36"  style="background:#D9F2FF;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie"> Tamil Movies </td>
  </tr>
</table>
</td>
    </tr>
    <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dltamil" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' ></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
    <tr>
      <td height="36"  style="background: #FFDECE;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie"> Telugu Movies </td>
  </tr>
</table>
</td>
    </tr>
    <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dltelugu" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' ></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
     <tr>
      <td height="36"  style="background:#D9F2FF;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie">  Kannada Movie </td>
  </tr>
</table>
</td>
    </tr>
   <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dlkannada" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' ></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
    <tr>
      <td height="36"  style="background:#D9F2FF;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie"> Malayalam Movie </td>
  </tr>
</table>
    <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dlmalayalam" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' ></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
    <tr>
      <td style="background-color:#FFF">&nbsp;</td>
    </tr>
    <tr>
      <td style="border-bottom:1px solid #666; background-color:#FFF">&nbsp;</td>
    </tr>
    <tr>
      <td height="36"  style="background: #FFDECE;border-bottom:1px solid  #A8D3FF;" ><table width="100%" border="0">
  <tr>
    <td  class="movie">English Movie</td>
  </tr>
</table>
</td>
    </tr>
    <tr>
      <td height="22" class="bottam_menu" style="border-bottom:1px solid #666; background-color:#FFF; padding-left:5px;">
      <asp:DataList ID="dlenglish" runat="server">
      <ItemTemplate>
      <asp:LinkButton ID="lnkmovie" runat="server" Text='<%#Eval("Movie_Name")%>' ></asp:LinkButton>
      </ItemTemplate>
      </asp:DataList>
      </td>
    </tr>
    
    <tr>
      <td style="border-bottom:1px solid #666; background-color:#FFF" align="center"><br/><img src="images/movie5.png" width="160" height="600" /><br/></td>
    </tr>
    <tr>
      <td style="border-bottom:1px solid #666; background-color:#FFF" align="center"><br/><img src="images/movie.png" width="160" height="600" /><br/>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>--%>