<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin-CategoryDetails.aspx.cs" Inherits="admin_Admin_CategoryDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Justcalluz - Admin Control Panel - Approval for data</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script src="js/statesopt.js"></script>
    <script type="text/javascript" src="js/tab.js"></script>
    <style type="text/css">        
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }
        .cal_theme .ajax__calendar_active   

        {     
            color: Red;      
            font-weight: bold;      
            background-color: #ffffff; 
        } 
        .style40
        {
            height: 8px;
        }
          #ViewGrid td
        {
        	border-color:Black;
        	border:1px;
        }
        #ViewGrid th
        {
        	border:1px solid black;
        }       
      </style>
      <script type="text/javascript">
          function CurrentDateShowing(e) {
              if (!e.get_selectedDate() || !e.get_element().value)

                  e._selectedDate = (new Date()).getDateOnly();
          }    
</script>
<script type="text/javascript">
    function ConfirmationBox() {
        var result = confirm('Are you sure you want to delete record ?');
        if (result) {

            return true;
        }
        else {
            return false;
        }
    }
  </script>
  <script type="text/javascript" >


      function IsSelectedAtleastOneCheckBox() {
          var loTable = document.all("<%=ViewGrid.ClientID%>"); // GridView Name
          count = 0;
          with (document.forms[0]) {
              for (var i = 0; i < elements.length; i++) {
                  var e = elements[i];
                  if (e.type == "checkbox" && e.checked == true && e.id.substring(e.id.lastIndexOf('_') + 1, e.id.length) == 'CheckBoxreq') // This is our control Name
                  {
                      count += 1;
                  }
              }
          }
          if (count == 0) {
              alert("please select at least one checkbox ");
              return false;
          }
          else if (count > 1) {
              alert("please select only one checkbox ");
              return false;
          }
          else {
             return confirm("Are you sure you want to delete the selected record?");
              return true;
          }
          return true;

      }
      function IsSelectedAtleastOneCheckBox1() {
          var loTable = document.all("<%=ViewGrid.ClientID%>"); // GridView Name
          count = 0;
          with (document.forms[0]) {
              for (var i = 0; i < elements.length; i++) {
                  var e = elements[i];
                  if (e.type == "checkbox" && e.checked == true && e.id.substring(e.id.lastIndexOf('_') + 1, e.id.length) == 'CheckBoxreq') // This is our control Name
                  {
                      count += 1;
                  }
              }
          }
          if (count == 0) {
              alert("please select at least one checkbox ");
              return false;
          }
          else if (count > 1) {
              alert("please select only one checkbox ");
              return false;
          }
          else {
            return confirm("Are you sure you want to Edit the selected record?");
              return true;
          }
          return true;
      }
        
        
</script>
  </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
        <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
             <table cellpadding="0" cellspacing="0">
              <tr>
               <td class="style39" valign="top" style="padding-top:4px">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                     <table width="750px"> 
                        <tr>
                            <td colspan="2">
                            <dataHead:dataHeader ID="datahead1" runat="server" />
                            </td>
                        </tr>
                        <tr><td height="10px" align="right" colspan="2" style="padding-right:8px;">
                          <a href="http://www.justcalluz.com" target="_blank">
                          <img ID="imgsite" src="images/Click Here For SiteView.png" runat="server" alt="Siteview" /></a>
                          
                          </td></tr>
                        <tr id="trFilterHead" runat="server">
                            <td align="center">
                              <span style="font-size:14px; font-weight:bold"> You can Filter the records based on the selection of State and City </span>
                            </td>
                        </tr>
                        <tr><td height="10px"></td></tr>
                        <tr id="trFilter" runat="server">
                            <td align="center">
                                <table>
                                     <tr>
                                      <td class="adminform" align="right">State</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlState" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                                          </asp:DropDownList>                                                                                   
                                      </td>
                                    </tr>  
                                    <tr>
                                      <td class="adminform" align="right">City</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlCity" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlCity_SelectedIndexChanged" AutoPostBack="true">
                                          </asp:DropDownList>                                                                                  
                                      </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblCaterec" runat="server" ForeColor="DarkBlue" Font-Size="14px" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                            <td align="right">
                                <a href="Admin-MainPage.aspx"><asp:Label ID="lblBack" runat="server" Text="Back" style="padding-right:10px; padding-bottom:5px; font-family:verdana; Font-Size:14px;"></asp:Label></a>
                            </td>
                        </tr>  
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblrecords" runat="server"></asp:Label>                      
                            </td>
                        </tr> 
                         <tr>
                          <td align="left">
                          <asp:Button ID="btnView" runat="server" Text="View / Edit" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" />
                            &nbsp;
                          <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" 
                                      OnClientClick="return IsSelectedAtleastOneCheckBox();" Width="80px"/>                          
                              
                         </td>
                        
                        </tr>                     
                        <tr>
                            <td colspan="2">
                                  <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                 ForeColor="#333333" Width="750px" AllowPaging="true" BorderColor="Black" 
                                                BorderStyle="Solid" BorderWidth="1" DataKeyNames="id"
                                                PageSize="10" onpageindexchanging="ViewGrid_PageIndexChanging" 
                                              >
                                             <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="25px"/>
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                                        <Columns>
                                        <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20px">
                                    <HeaderTemplate>
                                                         
                                    </HeaderTemplate>
                                    <ItemTemplate>                                                                                                                      
                                        <asp:CheckBox ID="CheckBoxreq" runat="server"/>                                  
                                    </ItemTemplate>
                             </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Company Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" >
                                            <ItemTemplate>
                                                <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                    <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateField>                                      
                                                               
                                        <asp:BoundField DataField="contact_person" HeaderText="Contact Person" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"  ItemStyle-Width="15%"></asp:BoundField>                            
                                        <%--<asp:BoundField DataField="address" HeaderText="Address" HeaderStyle-HorizontalAlign="left"></asp:BoundField>--%>                            
                                        <asp:BoundField DataField="City" HeaderText="City" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ></asp:BoundField>
                                        <asp:BoundField DataField="emailid" HeaderText="Email Id" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                        <asp:BoundField DataField="mob" HeaderText="Mobile" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" />                           
                                        <asp:BoundField DataField="Category" HeaderText="Category" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ></asp:BoundField>                              
                                        <asp:BoundField DataField="ApprovedStatus" HeaderText="Status" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ></asp:BoundField>                                      
                                    <%--    <asp:TemplateField HeaderText="Delete" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" >
                                        <ItemTemplate>                                            
                                            <asp:LinkButton ID="lnkBtnDelete" runat="server" Font-Bold="false" ForeColor="Black" Font-Underline="false" CommandArgument='<%#Eval("id") %>' OnCommand="lnkDelete" >
                                                <img src='images/delete.gif' width='16' height='16' border='0' />
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                        </asp:TemplateField>--%>
                                    </Columns>
                                  </asp:GridView>  
                                                           
                            </td>
                        </tr>                                         
                  </table>
                </td>                
              </tr>                
            </table>                             
           </td>
         </tr>         
       </table>
    </div>
    </center>
    </form>
</body>
</html>
