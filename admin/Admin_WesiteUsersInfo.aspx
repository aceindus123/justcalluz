<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_WesiteUsersInfo.aspx.cs" Inherits="admin_Admin_WesiteUsersInfo" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WebsiteUserHeader.ascx" TagName="WUInfo" TagPrefix="WebUInfo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Website users information</title>    
<link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script type="text/javascript" src="js/tab.js"></script>
	 <style type="text/css">
	   #ViewGridRegUsers td
        {
        	border-color:Black;
        	border:1px;
        }
        #ViewGridRegUsers th
        {
        	border:1px solid black;
        }    
	 </style>
     <script type="text/javascript" >


         function IsSelectedAtleastOneCheckBox() {
             var loTable = document.all("<%=ViewGridRegUsers.ClientID%>"); // GridView Name
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
                 return confirm("Are you sure ! you want to send Active id for register user?");
                 return true;
             }
             return true;

         }
         function IsSelectedAtleastOneCheckBox1() {
             var loTable = document.all("<%=ViewGridRegUsers.ClientID%>"); // GridView Name
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
                 return confirm("Are you sure ! you want to change the status of register user?");
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
            <table cellpadding="0" cellspacing="0" width="770px">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                       
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" align="center"  style="background-color:#F2FAFC">                    
                    <table width="750px">
                        <tr>
                            <td colspan="2">
                                <WebUInfo:WUInfo ID="WUInfo1" runat="server" />
                            </td>
                        </tr>
                         <tr><td align="right" style="padding-right:8px;" colspan="2">
                            <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a></td></tr>
                        <tr><td align="center" style="padding: 5px 0px 5px 0px;" colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="Information of Registered Customer's" ForeColor="OrangeRed" Font-Bold="true" Font-Size="14px" Font-Names="verdana"></asp:Label>
                        </td></tr>
                       
                        <tr><td align="left">
                            <asp:Label ID="lblerror" runat="server"></asp:Label>
                            </td>
                          <td align="right" colspan="6" style="padding-right:8px;padding-bottom:3px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td>
                        </tr>
                         <tr>
                            <td align="center" style="width:98%;" colspan="2">
                                <asp:GridView ID="ViewGridRegUsers" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                            GridLines="None" ForeColor="#333333" Width="730px" 
                                    AllowPaging="true" PageSize="11" onrowdatabound="ViewGridRegUsers_RowDataBound" 
                                    onpageindexchanging="ViewGridRegUsers_PageIndexChanging">
                                             <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <RowStyle BackColor="#E3EAEB" Font-Size="11px" Font-Names="verdana" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
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
                                                <asp:TemplateField HeaderText="User Id" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="130px">
                                                    <ItemTemplate>
                                                        <a href="Admin_RegUsersDetails.aspx?rid=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                            <%# DataBinder.Eval(Container, "DataItem.email")%>
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField>                                                   
                                                <%--<asp:BoundField DataField="RegType" HeaderText="Type of Registration" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>  --%>                                  
                                                <asp:BoundField DataField="name" HeaderText="First Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                <asp:BoundField DataField="LastName" HeaderText="Last Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                               <%-- <asp:BoundField DataField="password" HeaderText="Password" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                                     <asp:TemplateField HeaderText="Registration Date" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblRDate" runat="server"  Text='<%# DataBinder.Eval(Container, "DataItem.iRegDate")%>' ></asp:Label>
                                                      
                                                    </ItemTemplate>
                                                </asp:TemplateField>   
                                                <%--<asp:BoundField DataField="iRegDate" HeaderText="Registration Date" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>                                                                                               
                                                <asp:BoundField DataField="Status" HeaderText="Status" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="60px"></asp:BoundField>
                                                <asp:TemplateField HeaderText="ChangeStatus" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">                                                
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkBtnStatusChange" runat="server" ForeColor="Black" CommandArgument='<%#Eval("id")%>' 
                                                          OnCommand="ChangeStatus" OnClientClick="return IsSelectedAtleastOneCheckBox1();"></asp:LinkButton>
                                                    <asp:Label ID="lblStatus" runat="server" Visible="false" Text='<%#Eval("iStatus") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Send Active Id" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                   HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lnkBtnSendActiveId" Width="60px" runat="server" ForeColor="Black" 
                                                               CommandArgument='<%#Eval("id")%>' OnCommand="SendActiveId" 
                                                                     OnClientClick="return IsSelectedAtleastOneCheckBox();">Send Mail</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>                                                                                               
                                            </Columns>
                                           <%-- <EditItemStyle BackColor="#7C6F57" />
                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages"/>
                                            <AlternatingItemStyle BackColor="White" />--%>
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
