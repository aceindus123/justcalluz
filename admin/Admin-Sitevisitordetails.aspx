<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin-Sitevisitordetails.aspx.cs" Inherits="admin_Admin_Sitevisitordetails" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Site Visitors</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
       
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
  
<script type="text/javascript" language="javascript">
  
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
            confirm("Are you sure you want to view the selected record?");
            return true;
        }
        return true;
    }
   
</script>
  
        <script type="text/javascript" src="js/tab.js"></script></head>
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
                    <td>                      
                       <dataHead:dataHeader ID="datahead1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td align="right" style="padding-right:6px;">
                         <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/></a>
                        </td></tr> 
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Site Visitors Information</span> 
                        </td>
                      </tr>                     
                     <tr><td align="right" colspan="6" style="padding-right:5px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td></tr>
                       <%--  <tr>
                          <td align="left" style="padding-left:5px;">
                          <asp:Button ID="btnVieworEdit" runat="server" Text="View" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;"  Width="80px"/>
                        </td>
                        </tr>   --%>                                       
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                <td style="width:90%;">
                                    <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                            ForeColor="#333333" Width="750px" AllowPaging="true" BorderColor="Black" 
                                        BorderStyle="Solid" BorderWidth="1" DataKeyNames="siteid"
                                        PageSize="20" onpageindexchanging="ViewGrid_PageIndexChanging" >
                                        
                                        <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                    <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                    <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="25px"/>
                                    <AlternatingRowStyle BackColor="White" />
                                    <EditRowStyle BackColor="#7C6F57" />
                                                                                    
                                        <Columns> 
                                          <%--  <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                    HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                <HeaderTemplate>
                                                         
                                                </HeaderTemplate>
                                                <ItemTemplate>                                                                                                                      
                                                    <asp:CheckBox ID="CheckBoxreq" runat="server"  />                                  
                                                </ItemTemplate>
                                            </asp:TemplateField> --%>
                                                <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" 
                                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                <HeaderTemplate>
                                                    <asp:Label ID="lblHContentName" runat="server" Text="Visitor Name"></asp:Label>
                                                </HeaderTemplate>
                                                <ItemTemplate>                                                                                                                      
                                                    <asp:Label ID="lblContentName" runat="server" Text="Site Visitor"></asp:Label>                                    
                                                </ItemTemplate>
                                            </asp:TemplateField>                                                                
                                                                                                                                   
                                            <asp:BoundField DataField="ip_address" HeaderText="IP Address" ItemStyle-BorderColor="Black" 
                                                ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />
                                            <asp:BoundField DataField="Date" HeaderText="Visited Date" ItemStyle-BorderColor="Black" 
                                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />                          
                                            <asp:BoundField DataField="Time" HeaderText="Visited Time" ItemStyle-BorderColor="Black" 
                                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />                           
                                           
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
           </td>
         </tr>         
       </table>
    </div>
    </center>
    </form>
</body>
</html>
