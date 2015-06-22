<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_WhitePages.aspx.cs" Inherits="admin_Admin_WhitePages" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WPHeader.ascx" TagName="WPHead" TagPrefix="WPHeader" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - White Pages Home</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .modalBackground
        {  
        	background-color: Gray;  
        	filter: alpha(opacity=50);  
        	opacity: 0.50;
        }
       .updateProgress
       {  
       	border-width: 1px; 
        border-style: solid; 
        background-color: White;  
        position: absolute;  
        width: 180px;  
        height: 65px;
       }  
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
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
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }  
        .stylealign
        {
           align:center
        }        
        </style>
    <script language="javascript" type="text/javascript">

          function confirm_delete(uid) {
              if (confirm("Are you sure you want to delete this?") == true)
                  document.location = 'Admin_DeleteWP.aspx?cid=' + uid;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected white pages data has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected white pages data has been Accepted");
          }
    </script>	

    <script language="javascript" type="text/javascript" >
        function Sample() {
            var n = document.getElementById("ViewGrid").rows.length;
            var i;
            var j = 0;
            for (i = 2; i <= n; i++) {
                if (i < 10) {
                    if (document.getElementById("ViewGrid_ctl0" + i + "_CheckBoxreq").checked == true) {
                        if (j > 0) {
                            alert('you can select only one...');
                            document.getElementById("ViewGrid_ctl0" + i + "_CheckBoxreq").checked = false;
                        }
                        else {
                            j++;
                        }
                    }
                }
                else {
                    if (document.getElementById("ViewGrid_ctl" + i + "_CheckBoxreq").checked == true) {
                        if (j > 0) {
                            alert('you can select only one...');
                            document.getElementById("ViewGrid_ctl" + i + "_CheckBoxreq").checked = false;
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
            alert('select atleast one Checkbox for View / Edit!');
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
        <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/White_Page.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>	--%>
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
                    <td >                      
                       <WPHeader:WPHead ID="wpheader1" runat="server" />
                    </td>
                    </tr> 
                      <tr>
                            <td  align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <a  target="_blank" href="http://www.justcalluz.com/White_Page.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>  
                    <tr><td height="5px"></td></tr>  
                    <tr>
                        <td align="center" >
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">White Pages Home</span> 
                        </td>
                      </tr>                     
                                                                  
                        <tr>
                            <td >
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            <%--</td>
                            <td align="right" style="padding-right:20px;">--%><div style="float:right; width:50px; padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton></div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>
                        </tr> 
                        <tr>
                                                    
                            <td align="center">
                               
                            </td>
                        </tr> 
                        <tr><td height="20px"></td></tr>  
                        <tr>
                          <td align="left">
                          <asp:Button ID="btnVieworEdit" runat="server" Text="View / Edit" OnClientClick="return selectOne(this.form);"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" />
                              
                                                
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return confirmMessageDelete(this.form);"/>                          
                                
                          </td>
                        </tr>                                                 
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                        <td>
                                           <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                GridLines="None" ForeColor="#333333" Width="750px" AllowPaging="true" 
                                                PageSize="10" onpageindexchanging="ViewGrid_PageIndexChanging"  DataKeyNames="wpId"    >
                                                <%--<FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                                                  <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                                                <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderWidth="1px" BorderColor="Black" BorderStyle="Solid" Height="30px"/>
                                                --%>
                                                <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="30px"/>
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                                                <Columns> 
                                                 <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                         
                                                       </HeaderTemplate>
                                                       <ItemTemplate>                                                                                                                      
                                                            <asp:CheckBox ID="CheckBoxreq" runat="server" onclick="Sample()" />                                  
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHCity" runat="server" Text="City"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                                                                                             
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHPara1" runat="server" Text="Para-1"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblPara1" runat="server" Text='<%#Eval("aPara1")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHPara2" runat="server" Text="Para-2"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblPara2" runat="server" Text='<%#Eval("aPara2")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHPara3" runat="server" Text="Para-3"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblPara3" runat="server" Text='<%#Eval("aPara3")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHPara4" runat="server" Text="Para-4"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblPara4" runat="server" Text='<%#Eval("aPara4")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>  
                                                    <asp:TemplateField ItemStyle-BorderWidth="1">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHPara5" runat="server" Text="Para-5"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblPara5" runat="server" Text='<%#Eval("aPara5")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>    
                                                                                                                                  
                                                    <asp:BoundField DataField="PostDate" HeaderText="PostDate" dataformatstring="{0:MMM d, yyyy}" ItemStyle-BorderWidth="1" ></asp:BoundField> 
                                                    <asp:BoundField DataField="posted_by" HeaderText="Posted By" ItemStyle-BorderWidth="1" ></asp:BoundField> 
                                                   <%-- <asp:TemplateField HeaderText="View/Edit" ItemStyle-BorderWidth="1">
                                                        <ItemTemplate>                                                                                                                      
                                                            <a href="Admin_WhitePagesEdit.aspx?wpid=<%# DataBinder.Eval(Container, "DataItem.wpId")%>">
                                                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                            </a>
                                                        </ItemTemplate>
                                                        </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Delete" ItemStyle-BorderWidth="1">                                        
                                                        <ItemTemplate>  
                                                             <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.wpId")%>+");' />                                        
                                                        </ItemTemplate>
                                                    </asp:TemplateField>   --%>                                                       
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
