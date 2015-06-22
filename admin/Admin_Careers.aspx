<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Careers.aspx.cs" Inherits="admin_Admin_Careers" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu"
    TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader"
    TagPrefix="Careers" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Justcalluz - Admin Control Panel - Careers</title>
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
        #ViewGrid td
        {
            border-color: Black;
            border: 1px;
        }
        #ViewGrid th
        {
            border: 1px solid black;
        }
    </style>
    <script language="javascript" type="text/javascript">

        function confirm_delete(uid) {
            if (confirm("Are you sure you want to delete this Classified?") == true)
                document.location = 'Admin_DeleteData.aspx?cid=' + uid;
            else
                return false;
        }
        function alertdelete() {
            alert("Selected Classified has been deleted Successfully");
        }
        function alertaccept() {
            alert("Selected Classified has been Accepted");
        }
    </script>
    <script type="text/javascript" src="js/tab.js"></script>
    <script type="text/javascript">


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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <center>
        <div>
            <table cellpadding="0" cellspacing="0">
                <tr>
                    <td align="left" style="width: 100%;">
                        <cc1:Headermenu ID="header" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td class="style39" valign="top" style="padding-top: 4px">
                                    <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                                </td>
                                <td valign="top">
                                    &nbsp;
                                </td>
                                <td valign="top" style="padding-left: 10px; background-color: #F2FAFC">
                                    <table width="750px">
                                        <tr>
                                            <td style="width: 100%;" colspan="2">
                                                <Careers:CareersHeader ID="Careers" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" align="right" style="padding-right: 8px;">
                                                <a href="http://www.justcalluz.com/Careers_Location.aspx" target="_blank">
                                                    <img src="images/Click Here For SiteView.png" alt="Siteview" /></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="3">
                                                <span style="font-size: 21px; font-weight: bold; color: DarkBlue">Careers Home</span>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true"
                                                    Font-Size="Medium"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="padding-bottom: 5px;" align="left">
                                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true"
                                                    Font-Size="Medium"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                                    OnClick="lnkEdit_Click" Style="border-radius: 1px solid black;" Width="50px" />
                                                &nbsp;
                                                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="lnkDelete_Click"
                                                    Style="border-radius: 1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox();" />
                                            </td>
                                            <td align="right" style="padding-right: 10px;">
                                                <asp:LinkButton ID="lnkBack" runat="server" Text="Back" OnClick="lnkBack_Click"></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 10px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" align="left" style="width: 99%; padding-right:10px;">
                                                <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                    GridLines="None" ForeColor="#333333" Width="100%" AllowPaging="true" DataKeyNames="jobid"
                                                    PageSize="10" OnPageIndexChanging="ViewGrid_PageIndexChanging">
                                                    <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True"  
                                                                BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" 
                                                         BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" 
                                                    BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1"
                                                        BorderStyle="Solid" />
                                                    <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True"
                                                        ForeColor="White" HorizontalAlign="left"  Height="25px" 
                                                         BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <AlternatingRowStyle BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <EditRowStyle BackColor="#7C6F57" BorderColor="Black" BorderStyle="Solid" BorderWidth="1"/>
                                                    <Columns>
                                                        <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20px">
                                                            <HeaderTemplate>
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="CheckBoxreq" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Job Title" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                            ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"
                                                            ItemStyle-Width="150px">
                                                            <ItemTemplate>
                                                                <a href="Admin_CareersDetails.aspx?cjid=<%# DataBinder.Eval(Container, "DataItem.jobid")%>"
                                                                    style="color: Black; text-decoration: underline;">
                                                                    <%# DataBinder.Eval(Container, "DataItem.title")%>
                                                                </a>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="category" HeaderText="Category" ItemStyle-BorderColor="Black"
                                                            ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center"
                                                            ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                        <asp:BoundField DataField="specialization" HeaderText="Specialization" ItemStyle-BorderColor="Black"
                                                            ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center"
                                                            ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                        <%-- <asp:BoundField DataField="jobType" HeaderText="Job Type"></asp:BoundField>                            
                            <asp:BoundField DataField="workExp" HeaderText="Experience"></asp:BoundField>    --%>
                                                        <asp:BoundField DataField="qualification" HeaderText="Qualification" ItemStyle-BorderColor="Black"
                                                            ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center"
                                                            ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                        <asp:BoundField DataField="expiredate" HeaderText="Available till" ItemStyle-BorderColor="Black"
                                                            ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center"
                                                            ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                        <asp:TemplateField HeaderText="No. of Applicants" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                            ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkbtnApllications" runat="server" Text='<%#Eval("applications")%>'
                                                                    Font-Bold="false" ForeColor="Black" Font-Underline="true" CommandArgument='<%#Eval("jobid") %>'
                                                                    OnCommand="lnkViewApplications"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <%-- <asp:TemplateField HeaderText="Update">
                                        <ItemTemplate>  
                                            <asp:LinkButton ID="lnkBtnEdit" runat="server" Font-Bold="false" ForeColor="Black" Font-Underline="false" Text="Edit" CommandArgument='<%#Eval("jobid") %>' OnCommand="lnkEdit">
                                            <img src='images/edit.gif' width='16' height='16' border='0' /> 
                                            </asp:LinkButton>                                    
                                        </ItemTemplate>
                                        </asp:TemplateField> --%>
                                                        <asp:TemplateField HeaderText="Extend Job Availability" ItemStyle-BorderColor="Black"
                                                            ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1" HeaderStyle-HorizontalAlign="Center"
                                                            ItemStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkBtnExtent" runat="server" Font-Bold="false" ForeColor="Black"
                                                                    Font-Underline="true" Text="Extend" CommandArgument='<%#Eval("jobid") %>' OnCommand="lnkExtend"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <%--  <asp:TemplateField HeaderText="Delete">
                                        <ItemTemplate>  
                                            <asp:LinkButton ID="lnkBtnDelete" runat="server" Font-Bold="false" ForeColor="Black" Font-Underline="false" Text="Delete" CommandArgument='<%#Eval("jobid") %>' OnCommand="lnkDelete">
                                                <img src='images/delete.gif' width='16' height='16' border='0' /> 
                                            </asp:LinkButton>                                    
                                        </ItemTemplate>
                                        </asp:TemplateField>  --%>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input id="btnDummy" runat="server" type="button" style="display: none;" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="modpopup1"
                                                    BackgroundCssClass="modalBackground" TargetControlID="btnDummy" OkControlID="btnDummy"
                                                    CancelControlID="btnDummy" BehaviorID="mpeBehavior" DropShadow="false" PopupDragHandleControlID="panel4">
                                                </AjaxToolkit:ModalPopupExtender>
                                                <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
                                                    <%--<fieldset style="width: 402px">--%>
                                                    <asp:Panel ID="Panel4" runat="server">
                                                    </asp:Panel>
                                                    <table align="center" width="400" height="30" style="background: green; border: width 1px color:white;
                                                        font-size: 13px;">
                                                        <tr style="background-color: Green;">
                                                            <td style="width: 400px" align="center">
                                                                <span style="color: White">To Extend the Job Availability for Job Title
                                                                    <br />
                                                                    &nbsp;</span>
                                                                <asp:Label ID="lblJobTitle" runat="server" Font-Size="Large" Font-Bold="true" ForeColor="White"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table align="center" width="400" style="background: white; height: 184px;">
                                                        <tr>
                                                            <td width="70%" style="padding-left: 5px;">
                                                                <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                                                                No.of Days to extend Job Availability
                                                            </td>
                                                            <td>
                                                                :
                                                            </td>
                                                            <td width="30%">
                                                                <asp:TextBox ID="txtNoofDays" runat="server" Width="50px"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="rfvNoofDays" runat="server" ErrorMessage="Please enter no. of days to extend job availability"
                                                                    ControlToValidate="txtNoofDays" ValidationGroup="modal">*</asp:RequiredFieldValidator>
                                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="make sure number is positive or place the zero in first place for single digits ex:03"
                                                                    ControlToValidate="txtNoofDays" ValidationGroup="modal" ValidationExpression="\d{2}">*</asp:RegularExpressionValidator>
                                                            </td>
                                                        </tr>
                                                        <tr align="left" style="margin-left: 5px">
                                                            <td align="center" class="style4" colspan="3">
                                                                <asp:Button ID="submitbutton" runat="server" Text="Submit" ValidationGroup="modal"
                                                                    CausesValidation="true" Width="62px" OnClick="submitbutton_Click" />
                                                                &nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:Button ID="cancelbutton" runat="server" Text="Cancel" OnClick="cancelbutton_Click" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="3">
                                                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                                                                    ShowSummary="False" ValidationGroup="modal" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <%--</fieldset>--%></asp:Panel>
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
