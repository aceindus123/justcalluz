<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Data.aspx.cs" Inherits="Data" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="smenu" TagPrefix="cc4"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Just callus ---- Admin Control Panel</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }
      </style>
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
    <tr>
    <td>        
    <table cellpadding="0" cellspacing="0">
     <tr>
            <td class="style39">
            
            <%--<cc2:SideMenu ID="SideMenu1" runat="server" />--%>
           <cc4:smenu ID="sidemenu" runat="server" />
            </td>
            <td valign="top">&nbsp;</td>
            <td valign="top" style="padding:10px; padding-left:50px" class="style37">
            
              <table border="0" cellspacing="5" style="height: 564px; width: 574px; margin-left: 0px">
              <tr>
               <td align="right" colspan="3">
              <a href="Edit.aspx">  <asp:Button ID="Button1" runat="server" Text="Edit" onclick="Button1_Click" /></a>&nbsp;&nbsp;&nbsp;
           
                <asp:Button ID="Button2" runat="server" Text="Delete" onclick="Button2_Click" />
            </td>
              </tr>
                <tr>
              <td class="adminform">Name</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
              
   
              <asp:TextBox ID="txtname" runat="server" Width="186px"></asp:TextBox>
              
              
              
       
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtname">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Category</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
            
              
               <asp:ScriptManager ID="ScriptManager1" runat="server" 
         EnablePageMethods = "true">
        </asp:ScriptManager>
 
  
   
    <cc3:AutoCompleteExtender   ServiceMethod="Searchcatageorylist" 
    MinimumPrefixLength="1"
    CompletionInterval="100" EnableCaching="false" CompletionSetCount="10" 
    TargetControlID="TextBox1" 
    ID="AutoCompleteExtender1" runat="server" FirstRowSelected = "false">
    </cc3:AutoCompleteExtender>
                  
                  <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="reqf1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1">
              </asp:RequiredFieldValidator></td>
              </tr>
              
              <tr>
              <td class="adminform">Area</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtarea" runat="server" Width="187px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqf2" runat="server" ErrorMessage="*" ControlToValidate="txtarea">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Phone</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtph" runat="server" Width="188px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtph">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
               <tr>
              <td class="adminform">Mobile</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtmobile" runat="server" Width="186px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtmobile">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
             <tr>
              <td class="adminform">Address</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtaddr" runat="server" Width="197px" TextMode="MultiLine"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtaddr">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             <tr>
              <td class="adminform">State</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtstate" runat="server" Width="186px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtstate">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Contact Person</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcp" runat="server" Width="187px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtcp">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Email</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtemail" runat="server" Width="189px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtemail">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
            
              <tr>
              <td class="adminform">City</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcity" runat="server" Width="187px" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ControlToValidate="txtcity">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">company Details</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcomp" runat="server" Width="189px" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ControlToValidate="txtcomp">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td></td>
              <td></td>
              <td align="center">
              <asp:Button ID="bt1" runat="server" Text="Submit" onclick="bt1submit_Click" 
                      style="height: 26px"  />
              <asp:Button ID="bt2" runat="server" Text="Reset" onclick="bt2reset_Click" 
                      style="height: 26px"  />
              </td>
              </tr>
              <tr><td></td></tr>
              <tr><td colspan="3" align="center">
        <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
        </td></tr>
              
              </table>
              
         </td>
        </tr>
        
        
     </table>
        
     </td>
    </tr>
    </table>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" 
            ShowFooter="True"  
           BackColor="White" 
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
            
         <%--   <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />--%>
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





