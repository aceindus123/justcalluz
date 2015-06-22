<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="user control/Header menu.ascx" TagName="Headermenu" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Default.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table cellpadding="0" cellspacing="0">
<tr>
        <td>
        <cc1:headermenu ID="header" runat="server" />
       
        </td>
    </tr>
 </table>
     <table cellpadding="0" cellspacing="0">
      <tr><td style="height:25px"></td> </tr>
     <tr><td align="right" colspan="6">
     <a href ="Data.aspx">Home</a>
     </td></tr>
     <tr>
     <td style="height:90px"></td>
     <td colspan="5" align="right">
        <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
        </td>
     </tr>
              <tr>
                <td style="width: 100px; height: 19px;">
                    ID</td>
                <td style="width: 100px; height: 19px;">
                    CompanyName</td>
                <td style="width: 100px; height: 19px;">
                    Category</td>
                <td style="width: 100px; height: 19px;">
                    Area</td>
                <td style="width: 100px; height: 19px;">
                    Phone</td>
                <td style="width: 100px; height: 19px;">
                    Mobile</td>
              </tr>
               <tr>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox6" runat="server"/></td>
                </tr>
              <tr>      
                <td style="width: 100px; height: 19px;">
                    Address</td>
                <td style="width: 100px; height: 19px;">
                    State</td>
                <td style="width: 100px; height: 19px;">
                    ContactPerson</td>
                <td style="width: 100px; height: 19px;">
                    Email</td>
                     <td style="width: 100px; height: 19px;">
                    City</td>
                <td style="width: 100px; height: 19px;">
                    Company Details</td>
               <%-- <td style="width: 100px; height: 19px;">
                    OperationalTimming</td>--%>
            </tr>
           
                <tr>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox7" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox8" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox9" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox10" runat="server"/></td>
                    <td style="width: 100px">
                    <asp:TextBox ID="TextBox11" runat="server"/></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox12" runat="server"/></td>
             <td style="width: 100px">
                    <asp:Button ID="Button1" runat="server" Text="Add New" OnClick="Button1_Click" /></td>
            </tr>
        </table>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" 
            ShowFooter="True" onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <RowStyle BackColor="White" ForeColor="#330099" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="true"/>
            <asp:BoundField DataField="cname" HeaderText="CompanyName"/>
            <asp:BoundField DataField="cat" HeaderText="Category"/>
            <asp:BoundField DataField="area" HeaderText="Area" />
            <asp:BoundField DataField="ph" HeaderText="Phone"/>
            <asp:BoundField DataField="mob" HeaderText="Mobile"/>
            <asp:BoundField DataField="addr" HeaderText="Address"/>
            <asp:BoundField DataField="state" HeaderText="State"/>
            <asp:BoundField DataField="conper" HeaderText="ContactPerson"/>
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="city" HeaderText="City"/>
            <asp:BoundField DataField="compdet" HeaderText="Company Details" />
       <%--     <asp:BoundField DataField="optim" HeaderText="OperationalTimming"/>--%>
            
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>

 
 
    </div>
    </form>
</body>
</html>
