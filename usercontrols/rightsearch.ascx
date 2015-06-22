<%@ Control Language="C#" AutoEventWireup="true" CodeFile="rightsearch.ascx.cs" Inherits="usercontrols_rightsearch" %>
<table>
       <tr>
                    <td><span><b>State</b></span>
                   </td>
                   </tr>
                   <tr><td>
                    <span class="row">
                      <asp:DropDownList ID="ddlstate" 
          runat="server" AutoPostBack="true" Enabled="true" 
           Height="25px" 
          Width="175px" OnSelectedIndexChanged="ddlstate_selectedindexchanged" 
          ></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqstate" runat="server" 
          ErrorMessage="Please select state" ControlToValidate="ddlstate"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
                   </span></td>
                    </tr>
                  <tr>
                    <td><span><b>City</b></span>
                    </td>
                   </tr>
                   <tr><td>
                   <span class="row">
                      <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="false" Enabled="false" 
           Height="25px" 
          Width="175px" ValidationGroup="events"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqcity" runat="server" 
          ErrorMessage="Please select city" ControlToValidate="ddlcity"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
           <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="postevent" ShowMessageBox="True" ShowSummary="False" />
                       </span></td>
                  </tr><%--<tr><td height="10px"></td></tr>--%>
                  <tr>
                  
                  <td align="right" height="30">
                  <asp:ImageButton ID="srchbtn" runat="server" ValidationGroup="postevent" 
                          ImageUrl="../images/searchjobbycity.png" onclick="srchbtn_Click" />
                  </td></tr>
                  
 </table>