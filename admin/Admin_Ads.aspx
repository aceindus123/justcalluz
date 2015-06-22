<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Ads.aspx.cs" ValidateRequest="false" Inherits="admin_Admin_Ads" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_AdsHeader.ascx" TagName="AdsHeader" TagPrefix="Ads" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Ads Home</title>
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
      <script language="javascript" type="text/javascript">

          function confirm_delete(uid) {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  document.location = 'Admin_DeleteAd.aspx?cid=' + uid;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected Ad has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected Ad has been Accepted");
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
                            document.getElementById("ViewGrid_ctl0" + i + "_CheckBoxreq").checked = false;
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
           return confirm("Are you sure you want to view the selected record?");
            return true;
        }
        return true;
    }
    function IsSelectedAtleastOneCheckBox2() {
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
  
        <script type="text/javascript" src="js/tab.js"></script></head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
        <table cellpadding="0" cellspacing="0">
         <tr>
            <td align="left" style="width:100%;">
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
                       <Ads:AdsHeader ID="ads1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td align="right" style="padding-right:6px;">
                         <a href="http://www.justcalluz.com/tv_ads.aspx" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/></a>
                        <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                        </td></tr> 
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Ads Home</span> 
                        </td>
                      </tr>                     
                        <tr>
                            <td colspan="2">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
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
                               Select Category : &nbsp; 
                               <asp:DropDownList ID="ddlAdType" runat="server" Width="150px" AutoPostBack="true"
                                    onselectedindexchanged="ddlAdType_SelectedIndexChanged" ValidationGroup="select">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                    ErrorMessage="Please select Category" ControlToValidate="ddlAdType" 
                                    ValidationGroup="select">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         
                          <tr><td align="right" colspan="6" style="padding-right:5px;padding-bottom:10px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td></tr>
                         <tr>
                          <td align="left" style="padding-left:7px;">
                          <asp:Button ID="btnView" runat="server" Text="View" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" Width="50px"/>
                               <%-- <a href="Admin_AdsEdit.aspx?adid=<%# DataBinder.Eval(Container, "DataItem.adId")%>">
                                                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                            </a>--%>
                                   &nbsp; 
                          <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClientClick="return IsSelectedAtleastOneCheckBox2();"
                           OnClick="EditDetails_Click" style="border-radius:1px solid black;" Width="50px"/>
                                   &nbsp;             
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox();"/>                          
                                 <%-- <img src='images/delete.gif' width='16' height='16' border='0' 
                                                                     onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.adId")%>+");' /> --%>
                          </td>
                        </tr>                                          
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                        <td style="width:90%;">
                                           <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                 ForeColor="#333333" Width="750px" AllowPaging="true" BorderColor="Black" 
                                                BorderStyle="Solid" BorderWidth="1" DataKeyNames="adId"
                                                PageSize="10" onpageindexchanging="ViewGrid_PageIndexChanging" 
                                                onrowdatabound="ViewGrid_RowDataBound" >
                                             <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="25px"/>
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                                                                                    
                                                <Columns> 
                                                 <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                         
                                                       </HeaderTemplate>
                                                       <ItemTemplate>                                                                                                                      
                                                            <asp:CheckBox ID="CheckBoxreq" runat="server"  />                                  
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                           HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHAdType" runat="server" Text="Category"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblAdType" runat="server" Text='<%#Eval("AdType")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                                           
                                                    <asp:BoundField DataField="AdSubType" HeaderText="SubCategory" ItemStyle-BorderColor="Black" 
                                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="AdLanguage" HeaderText="Laguage of the Ad" ItemStyle-BorderColor="Black" 
                                                          ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />                          
                                                    <asp:BoundField DataField="TitleToDisplay" HeaderText="Title" ItemStyle-BorderColor="Black" 
                                                          ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />                           
                                                    <asp:BoundField DataField="City" HeaderText="City" ItemStyle-BorderColor="Black" 
                                                            ItemStyle-HorizontalAlign="Center"  ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />                                                                                 
                                                    <asp:BoundField DataField="PaperName" HeaderText="News Paper Name" ItemStyle-BorderColor="Black" 
                                                         ItemStyle-HorizontalAlign="Center" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" />
                                                    <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" 
                                                              HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHContentName" runat="server" Text="File Name"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblContentName" runat="server" Text='<%#Eval("Content_Name")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                 
                                                    <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHCaptureContentName" runat="server" Text="Image Name"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblCaptureContentName" runat="server" Text='<%#Eval("CaptureContent_Name")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                 
                                                       <asp:TemplateField HeaderText="Post Date" ItemStyle-Width="100px" HeaderStyle-HorizontalAlign="Center" 
                                                         ItemStyle-BorderColor="Black" 
                                                                         ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" ItemStyle-HorizontalAlign="Center">
                                                          <ItemTemplate>
                                                           <asp:Label ID="lblCreatedate" runat="server" ItemStyle-BorderColor="Black" Text='<%# Eval("PostDate") %>'></asp:Label>
                                                          </ItemTemplate>
                                                      </asp:TemplateField>                                                                                
                                                                                                   
                                                </Columns>                        
                                            </asp:GridView> 

                                            <asp:Label ID="lblrecordsadsdata" runat="server" ForeColor="OrangeRed" Visible="false"></asp:Label>
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
