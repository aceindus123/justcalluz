<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToApproveUserData.aspx.cs" Inherits="admin_Admin_ToApproveUserData" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
function CurrentDateShowing(e)
{
      if (!e.get_selectedDate() || !e.get_element().value)

      e._selectedDate = (new Date()).getDateOnly();
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
           return confirm("Are you sure you want to approve the selected record?");
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
          return confirm("Are you sure you want to reject the selected user?");
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
            <td align="left">
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
                        <tr><td height="10px" align="right">
                          <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                          <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%></td></tr>
                        <tr id="trFilterHead" runat="server">
                            <td align="center">
                              <span style="font-size:14px; font-weight:bold"> You can Filter the records based on the selection of State and City </span>
                            </td>
                        </tr>
                        <tr><td height="10px"></td></tr>
                        <tr id="trFilter" runat="server">
                            <td align="center" >
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
                        <tr><td colspan="6" align="right" style="padding-right:10px; font-size:14px;height:20px;">
                           <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> </a>
                        </td></tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblrecords" runat="server"></asp:Label>    
                                <asp:Label ID="lblerror" runat="server" ></asp:Label>                            
                            </td>

                        </tr>  
                         <tr>
                          <td align="left" style="padding-bottom:8px;">
                                                
                            <asp:Button ID="btnActivate" runat="server" Text="Approve" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="lnkApprove_Click" style="border-radius:1px solid black;" />                          
                             &nbsp;
                            <asp:Button ID="btnDeactivate" runat="server" Text="Reject"  
                                 OnClick="lnkReject_Click" style="border-radius:1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox2();"/>                          
                            &nbsp;
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox();"/>                          
                          </td>
                        </tr>                  
                        <tr>
                            <td align="left" style="width:99%;">
                                <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                 ForeColor="#333333" Width="100%" AllowPaging="true" BorderColor="Black" 
                                                BorderStyle="Solid" BorderWidth="1" DataKeyNames="id"
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
                               <%--  0--%>  <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                         
                                                       </HeaderTemplate>
                                                       <ItemTemplate>                                                                                                                      
                                                            <asp:CheckBox ID="CheckBoxreq" runat="server" onclick="Sample()" />                                  
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                 <%--  1--%>         <asp:BoundField DataField="module" HeaderText="Module" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                <%--  2--%>        <asp:TemplateField HeaderText="Company Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                    <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateField> 
                                  <%--<asp:BoundField DataField="job_industry" HeaderText="Industry" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="job_functional_area" HeaderText="Functional Area" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                        <%--<asp:BoundField DataField="job_role" HeaderText="Role" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                            <%--  3--%>    <asp:BoundField DataField="job_Qualification" HeaderText="Qualification" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                             <%--  4--%>   <asp:BoundField DataField="job_exp" HeaderText="Experience" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                        <%--<asp:BoundField DataField="job_sal" HeaderText="Salary" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="job_desc" HeaderText="Job Description" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="job_keyskills" HeaderText="Key Skills" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                          <%--  5--%>     <asp:TemplateField HeaderText="Event Name" ItemStyle-Width="150px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black" title="View Details">
                                                    <%# DataBinder.Eval(Container, "DataItem.event_name")%>
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateField>                             
                         <%--  6--%>    <asp:TemplateField HeaderText="Event Place" ItemStyle-Width="100px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                              
                                                <asp:Label ID="lblEPlace" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.event_place")%>'></asp:Label>
                                               
                                            </ItemTemplate>
                                             </asp:TemplateField> 
                                        <asp:TemplateField HeaderText="Start Date" ItemStyle-Width="80px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                              
                                                <asp:Label ID="lblESDate" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.event_startdate")%>'></asp:Label>
                                               
                                            </ItemTemplate>
                                        </asp:TemplateField> 
                                       
                           <%--  7--%>   <%--<asp:BoundField DataField="event_startdate" HeaderText="Start Date" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="event_enddate" HeaderText="End Date" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="event_time" HeaderText="Time of Event" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="event_desc" HeaderText="Description" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>                                         
                                        <%--<asp:BoundField DataField="company_profile" HeaderText="Company Profile" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>                            
                         <%--  8--%>   <asp:BoundField DataField="contact_person" HeaderText="Contact Person" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="130px"></asp:BoundField>                            
                          <%--  9--%>  
                                      <asp:BoundField DataField="emailid" HeaderText="Email Id" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px"></asp:BoundField>
                                        <%--<asp:BoundField DataField="mob" HeaderText="Mobile" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>                            
                                        <%--<asp:BoundField DataField="fax" HeaderText="Fax" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                                        <%--<asp:BoundField DataField="SubCategory" HeaderText="Sub Category" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%> 
                                       <%--<asp:BoundField DataField="State" HeaderText="State" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>--%>
                        <%--10--%>      <asp:BoundField DataField="City" HeaderText="City" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                          <%--  11--%>  <asp:TemplateField HeaderText="Status" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>                                            
                                            <asp:Label ID="lblStatus" runat="server"  ForeColor="Black"  Text='<%#Eval("Status") %>' ></asp:Label>
                                        </ItemTemplate>
                                        </asp:TemplateField>                                       
                                       
                                    </Columns>
                                  
                                </asp:GridView>  
                                                           
                            </td>
                        </tr> 
                          <tr>
                            <td colspan="2">
                                <asp:Label ID="lblApproval" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
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
