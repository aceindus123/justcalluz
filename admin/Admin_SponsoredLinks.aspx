<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SponsoredLinks.aspx.cs" Inherits="admin_Admin_SponsoredLinks" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - To post Sponsoredlinks</title>

    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }        
        .style41
        {
            height: 50px;
        }
        #dgSponLiksHome td
        {
        	border-color:Black;
        	border:1px;
        }
        #dgSponLiksHome th
        {
        	border:1px solid black;
        }       
        </style>
        <script language="javascript" type="text/javascript" >
            function Sample() {
                var n = document.getElementById("dgSponLiksHome").rows.length;
                var i;
                var j = 0;
                for (i = 2; i <= n; i++) {
                    if (i < 10) {
                        if (document.getElementById("dgSponLiksHome_ctl0" + i + "_CheckBoxreq").checked == true) {
                            if (j > 0) {
                                alert('you can select only one...');
                                document.getElementById("dgSponLiksHome_ctl0" + i + "_CheckBoxreq").checked = false;
                            }
                            else {
                                j++;
                            }
                        }
                    }
                    else {
                        if (document.getElementById("dgSponLiksHome_ctl" + i + "_CheckBoxreq").checked == true) {
                            if (j > 0) {
                                alert('you can select only one...');
                                document.getElementById("dgSponLiksHome_ctl" + i + "_CheckBoxreq").checked = false;
                            }
                            else {
                                j++;
                            }
                        }
                    }
                }
            }
</script>

    <script type="text/javascript" language="javascript">
        function selectOne(frm) {
            for (i = 0; i < frm.length; i++) {
                if (frm.elements[i].checked) {
                    return true;
                }
            }
            alert('select atleast one Checkbox !');
            return false;
        }
</script>

<script type="text/javascript" language="javascript">
    function confirmMessageDelete(frm) {
        for (i = 0; i < frm.length; i++) {
            if (frm.elements[i].checked) {
                return confirm("Are you sure you want to delete the selected record?");
                return true;
            }
        }
        alert('select atleast one Checkbox for Delete!');
        return false;
    }
</script>
        <script type="text/javascript" src="js/tab.js"></script>
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
                <td class="style39" valign="top" style="padding-top:10px; background-color:#F2FAFC">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                   <table width="750px">
                     <tr><td align="right"><%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                     <a href="http://www.justcalluz.com/Home" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/></a>
                     </td></tr>
                   <tr>
                    <td align="right" class="style41"> 
                        <asp:LinkButton ID="lnkbtnPostsponslinks" runat="server"  Font-Bold="true" Font-Size="Medium"
                            onclick="lnkbtnPostsponslinks_Click">To Post Sponsored Links</asp:LinkButton>  <div style="float:right; font-weight:bold; width:50px; padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton></div>
                    </td>
                   </tr>
                   <tr><td align="center" style="height:50px; font-size:medium;">View for Sponsored Links
                 </td>
                   </tr>
                  
                   <tr>
                          <td align="left">
                          <asp:Button ID="btnVieworEdit" runat="server" Text="View / Edit" OnClientClick="return selectOne(this.form);"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" />
                              
                                                
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return confirmMessageDelete(this.form);"/>                          
                                
                                  <asp:Button ID="Button1" runat="server" Text="Renew" OnClientClick="return selectOne(this.form);"
                                 OnClick="imgBtnRenew_Click" style="border-radius:1px solid black;" />
                          </td>
                        </tr>   
                    <tr>
                        <td align="center">
                         <asp:GridView ID="dgSponLiksHome" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                GridLines="None" ForeColor="#333333" Width="750px" AllowPaging="true" 
                                                PageSize="10" onpageindexchanging="dgSponLiksHome_PageIndexChanged"  DataKeyNames="id"    >

                        <%-- <asp:DataGrid ID="dgSponLiksHome" runat="server" AutoGenerateColumns="false" OnPageIndexChanged="dgSponLiksHome_PageIndexChanged" 
                          CellPadding="4" GridLines="None" ForeColor="#333333" Width="720px" AllowPaging="true" PageSize="10"
                           AlternatingItemStyle-BackColor="White" BorderStyle="Solid" BorderColor="Black">--%>
                              <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="25px"/>
                                            <AlternatingRowStyle BackColor="White" />
                          <Columns>
                           <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                       
                                                       <ItemTemplate>                                                                                                                      
                                                            <asp:CheckBox ID="CheckBoxreq" runat="server" onclick="Sample()" />                                  
                                                        </ItemTemplate>
                             </asp:TemplateField> 
                            <asp:BoundField DataField="sponser_name" HeaderText="Sponser Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>  
                            <asp:BoundField DataField="heading" HeaderText="Company Name"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                            <asp:BoundField DataField="contact_no" HeaderText="Contact Number"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                            <asp:BoundField DataField="module" HeaderText="Advertised With"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                           <%-- <asp:BoundField DataField="categories" HeaderText="Category"></asp:BoundField>--%>
                            <asp:BoundField DataField="ad_type" HeaderText="Type Of Ad"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                           <%-- <asp:BoundField DataField="heading1" HeaderText="Address"></asp:BoundField> --%>
                            <asp:BoundField DataField="website" HeaderText="Website" ItemStyle-Width="150"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>                       
                            <asp:BoundField DataField="PostDate" HeaderText="Post Date"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                            <asp:BoundField DataField="ExpireDate" HeaderText="Expire Date"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"></asp:BoundField>
                           <%-- <asp:TemplateColumn HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgBtnEdit" runat="server" ImageUrl="~/admin/images/edit.gif" CommandArgument='<%#Eval("id") %>' OnClick="imgBtnEdit_Click" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgBtnDelete" runat="server" ImageUrl="~/admin/images/delete.gif" OnClick="imbBtndelete_Click" CommandArgument='<%#Eval("id") %>' />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Renew">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgBtnRenew" runat="server" ImageUrl="~/admin/images/check.gif" OnClick="imgBtnRenew_Click" CommandArgument='<%#Eval("id") %>' />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                          </Columns>                                                     
                         </asp:DataGrid>--%>
                         </Columns>
                         </asp:GridView>
                        </td>
                    </tr>
                    <tr><td></td></tr>
                  
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
