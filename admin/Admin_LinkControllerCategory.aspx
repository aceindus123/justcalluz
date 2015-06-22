<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_LinkControllerCategory.aspx.cs" Inherits="admin_Admin_LinkController" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Display Categories Data</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style39
        {
            width: 100px;
            height: 690px;
        }        
        .style40
        {
            height: 690px;
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
                if (i < n) {
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
            return  false;
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
        <script type="text/javascript" src="js/tab.js"></script>

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                <td valign="top" class="style40"></td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC" 
                      class="style40">  
                    <table width="750px">
                        <tr>
                            <td>                                
                               <dataHead:dataHeader ID="datahead1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="right" style="padding-right:5px;">
                               <a href="http://www.justcalluz.com" target="_blank"><img alt="SiteView" src="images/Click Here For SiteView.png"/></a>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                          
                        <tr><td style="height:20px"></td></tr>  
                        <tr id="trFilterHead" runat="server">
                            <td align="center">
                              <span style="font-size:14px; font-weight:bold"> You can Filter the records based on the selection of State and City </span>
                            </td>
                        </tr>
                        <tr><td style="height:20px"></td></tr>  
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
                        <tr><td align="right" colspan="6" style="padding-right:5px;padding-bottom:10px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td></tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>
                         <tr>
                          <td align="left">
                          <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" Width="50px" />
                            &nbsp;
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" 
                                      OnClientClick="return IsSelectedAtleastOneCheckBox();" Width="80px"/>                          
                              
                         </td>
                        
                        </tr>  
                         <tr><td style="height:10px"></td></tr>                                                           
                <tr>
                <td colspan="2">
                    <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                 ForeColor="#333333" Width="750px" AllowPaging="true" BorderColor="Black" 
                                                BorderStyle="Solid" BorderWidth="1" DataKeyNames="id"
                                                PageSize="10" onpageindexchanging="ViewGrid_PageIndexChanging" 
                                              OnRowDataBound="ViewGrid_RowDataBound">
                                             <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="25px"/>
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                        <Columns>
                     <%--0 --%>  <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                        HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20px">
                                    <HeaderTemplate>
                                                         
                                    </HeaderTemplate>
                                    <ItemTemplate>                                                                                                                      
                                        <asp:CheckBox ID="CheckBoxreq" runat="server"/>                                  
                                    </ItemTemplate>
                             </asp:TemplateField>
                    <%--1 --%> <asp:TemplateField HeaderText="Company Name" ItemStyle-Width="150px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                        <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="Company Name" ItemStyle-Width="150px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                        <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>--%> 
                <%--2 --%>         <asp:BoundField DataField="job_industry" HeaderText="Industry" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
              <%--3 --%>    <asp:BoundField DataField="job_functional_area" HeaderText="Functional Area" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
              <%--4 --%>    <asp:BoundField DataField="job_role" HeaderText="Role" ItemStyle-Width="50px"
                                 ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
             <%--5 --%>     <asp:BoundField DataField="job_Qualification" HeaderText="Qualification" ItemStyle-Width="50px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
              <%--6 --%>    <asp:BoundField DataField="job_exp" HeaderText="Experience" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
             <%--7 --%>     <asp:BoundField DataField="job_sal" HeaderText="Salary" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                         <%--   <asp:BoundField DataField="job_desc" HeaderText="Job Description" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
             <%--8 --%>   <asp:BoundField DataField="job_keyskills" HeaderText="Key Skills" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
             <%--9 --%>   <asp:TemplateField HeaderText="Event Name" ItemStyle-Width="150px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                        <%# DataBinder.Eval(Container, "DataItem.event_name")%>
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>                             
          <%--10 --%>      <asp:BoundField DataField="event_place" HeaderText="Event Place" ItemStyle-Width="150px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
          <%--11 --%>      <asp:TemplateField HeaderText="Start Date" ItemStyle-Width="100px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                              HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                   
                                     <asp:Label ID="lblsDate" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.event_startdate")%>'></asp:Label>   
                                   
                                </ItemTemplate>
                            </asp:TemplateField>     
                            <%--<asp:BoundField DataField="event_startdate" HeaderText="Start Date" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                            <%--<asp:BoundField DataField="event_enddate" HeaderText="End Date" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                            <%--<asp:BoundField DataField="event_time" HeaderText="Time of Event" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                           <%-- <asp:BoundField DataField="event_desc" HeaderText="Description" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>                                         
                            <asp:BoundField DataField="company_profile" HeaderText="Company Profile" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>                            --%>
       <%--12 --%>         <asp:BoundField DataField="contact_person" HeaderText="Contact Person" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>                            
                           <%-- <asp:BoundField DataField="address" HeaderText="Address" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>                            --%>
          <%--13 --%>      <asp:BoundField DataField="City" HeaderText="City" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
           <%--14 --%>     <asp:BoundField DataField="emailid" HeaderText="Email Id" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                           <%-- <asp:BoundField DataField="mob" HeaderText="Mobile" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>                            
                            <asp:BoundField DataField="fax" HeaderText="Fax" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                            <%--<asp:BoundField DataField="SubCategory" HeaderText="Sub Category" ItemStyle-Width="50px"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
        <%--15 --%>         <asp:BoundField DataField="Status" HeaderText="Status"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
          <%--16 --%>     <asp:TemplateField HeaderText="No. of Reviews" ItemStyle-Width="50px"  ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                   <a href="Admin_ViewReviews.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                     <asp:Label ID="lblrevie" runat="server" Text='<%#Eval("Review_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                </a>
                                </ItemTemplate>
                            </asp:TemplateField>
          <%--17 --%>      <asp:TemplateField HeaderText="Abused Reports" ItemStyle-Width="50px"  
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                   <a href="Admin_ViewReports.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>&type=abuse">
                                     <asp:Label ID="lblreport" runat="server" Text='<%#Eval("abuse_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                </a>
                                </ItemTemplate>
                            </asp:TemplateField>
          <%--18 --%>        <asp:TemplateField HeaderText="Incorrect Reports" ItemStyle-Width="50px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" >
                                <ItemTemplate>
                                   <a href="Admin_ViewReports.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>&type=incorrect">
                                     <asp:Label ID="lblincorrect" runat="server" Text='<%#Eval("incorrect_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                </a>
                                </ItemTemplate>
                            </asp:TemplateField>
        <%--19 --%>        <asp:TemplateField HeaderText="Map Status" ItemStyle-Width="80px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label>
                                   <a href="Admin_ToPointAddressOnMap.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                     <asp:Label ID="lblMap" runat="server" ForeColor="Black"></asp:Label>                                                                              
                                </a>
                                </ItemTemplate>
                            </asp:TemplateField>
                          <%--  <asp:TemplateColumn HeaderText="Edit" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <a href="Admin_EditData.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                               
                                    </a>
                            </ItemTemplate>
                            </asp:TemplateColumn>
                            
                            <asp:TemplateColumn HeaderText="Delete" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.id")%>+");' />                                        
                                    </a>
                            </ItemTemplate>
                            </asp:TemplateColumn> --%>                           
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
