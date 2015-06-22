<%@ Control Language="C#" AutoEventWireup="true" CodeFile="moviesearch.ascx.cs" Inherits="usercontrols_moviesearch" %>
<table width="100%" border="0">
    <tr>
      <td width="930" style="background: top no-repeat;  width:935px; height:32px; background: #ECF9FF; border: solid #93DCFF 1px;" ><table width="100%" border="0">
        
        <tr>
          <td width="0%" height="32">&nbsp;</td>
          <td width="11%" class="mid_menu">Change City</td>
          <td width="15%" ><span class="row">
          <asp:DropDownList ID="ddlcities" runat="server" AutoPostBack="true" 
                  onselectedindexchanged="ddlcities_SelectedIndexChanged">
          
          </asp:DropDownList>
                      </span></td>
          <td width="16%" style="background:#FC0; border: #FFD9C6 solid 2px;"><span class="row">
                     <asp:DropDownList ID="ddllanguages" runat="server" AutoPostBack="false"></asp:DropDownList>
                     </span></td>
          <td width="16%" style="background:#FC0; border: #FFD9C6 solid 2px;"><span class="row">
                      <asp:DropDownList ID="ddlmovies" runat="server" AutoPostBack="false"></asp:DropDownList>
                    </span></td>
          <td width="16%" style="background:#FC0; border: #FFD9C6 solid 2px;"><span class="row">
                      <asp:DropDownList ID="ddlarea" runat="server" AutoPostBack="false"></asp:DropDownList>
                    </span></td>

          <td width="5%"><asp:ImageButton ID="btngo" runat="server" 
                  ImageUrl="../images/go.png" onclick="btngo_Click" />
          </td>
          <td width="16%" style="background: #BFEBFF; border: #BFEBFE solid 2px;"><span class="row">
                      <asp:DropDownList ID="ddlcinemahalls" runat="server" AutoPostBack="false" ></asp:DropDownList>
                    </span></td>
          <td width="5%"><asp:ImageButton ID="hallgo" runat="server" 
                  ImageUrl="../images/go.png" onclick="hallgo_Click" /></td>
          <td width="0%">&nbsp;</td>
          </tr>
  </table>
  </td>
    </tr>
  </table>
