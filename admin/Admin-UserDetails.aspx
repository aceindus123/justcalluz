<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin-UserDetails.aspx.cs" Inherits="admin_Admin_UserDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WebAdminHeader.ascx" TagName="webadminHeader" TagPrefix="WAHeader"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Creation of Web Admin / Home</title>  
  <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js" type="text/javascript"></script>
        <style type="text/css">
        .style39
        {
            width: 195px;
        }        
        .style40
        {
            width: 261px;
        }
         #ViewGridWbAdmin td
        {
        	border-color:Black;
        	border:1px;
        }
        #ViewGridWbAdmin th
        {
        	border:1px solid black;
        }
        .modalBackground 
        {
            height:100%;
            background-color:Gray;
            filter:alpha(opacity=70);
            opacity:0.7;
        }
       
        </style>
        <script type="text/javascript" src="js/tab.js"></script>	
        <script type="text/javascript">
              function ConfirmationBox(frm) {
                  var result = confirm('Are you sure you want to delete user record ?');
                  if (result) {

                      return true;
                  }
                  else {
                      return false;
                  }
              }
              </script>
        <script type="text/javascript" language="javascript">
     function isNumberKey(evt) {
         var charCode = (evt.which) ? evt.which : event.keyCode
         if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
             return false;

         return true;
     }

  </script>
  <script type="text/javascript" >


      function IsSelectedAtleastOneCheckBox() {
          var loTable = document.all("<%=ViewGridWbAdmin.ClientID%>"); // GridView Name
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
          var loTable = document.all("<%=ViewGridWbAdmin.ClientID%>"); // GridView Name
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
             return confirm("Are you sure you want to view / Edit the selected record?");
              return true;
          }
          return true;
      }
      function IsSelectedAtleastOneCheckBox2() {
          var loTable = document.all("<%=ViewGridWbAdmin.ClientID%>"); // GridView Name
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
             return confirm("Are you sure you want to enable the selected user?");
              return true;
          }
          return true;
      }
      function IsSelectedAtleastOneCheckBox3() {
          var loTable = document.all("<%=ViewGridWbAdmin.ClientID%>"); // GridView Name
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
             return confirm("Are you sure you want to disable the selected user?");
              return true;
          }
          return true;
      }
        
        
</script>
<script type="text/javascript" language="javascript">

    function selectOne(frm, parent) {
        parent.checked = true;
        for (var i = 0; i < frm.length; i++) {
            if (frm[i].checked) {

            }
            else {
                parent.checked = false;
            }
        }

    }
//    function selectOne1(frm, parent) {
//        if (parent.checked) {
//            for (var i = 0; i < frm.length; i++) {
//                frm[i].checked = true;
//            }
//        }
//        else {
//            for (var i = 0; i < frm.length; i++) {
//                frm[i].checked = false;

//            }

//        }
//    }
      
</script>

      </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
            <table cellpadding="0" cellspacing="0" width="100%">
              <tr>
                <td class="style39" valign="top" style="padding-top:7px;">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" align="center" style="padding-left:10px; background-color:#F2FAFC">
                <table><tr><td>
                    <table width="100%" id="create" runat="server">
                    <tr>
                        <td colspan="6">
                            <WAHeader:webadminHeader ID="wahead1" runat="server" />
                        </td>
                    </tr>
                    </table>
                    </td></tr>
                    <tr><td>
                    <table width="100%" id="view" runat="server">
                        <tr><td align="center" colspan="2" style="padding-bottom:15px;">
                            <asp:Label ID="Label1" runat="server" Text="Users Information" ForeColor="OrangeRed" Font-Bold="true" Font-Size="14px" Font-Names="verdana"></asp:Label>
                        </td></tr>
                        <tr><td align="right" colspan="6" style="padding-right:5px;padding-bottom:10px;">
                            <asp:LinkButton ID="lnlBack" runat="server" Text="Back"  PostBackUrl="Admin-MainPage.aspx"
                                      Font-Size="13px" Font-Names="verdana" ></asp:LinkButton></td></tr>
                       <tr>
                          <td align="left" style="padding-bottom:10px;">
                          <asp:Button ID="btnVieworEdit" runat="server" Text="View / Edit" OnClientClick="return IsSelectedAtleastOneCheckBox1();"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" />
                         
                            <asp:Button ID="btnActivate" runat="server" Text="Enable" OnClientClick="return IsSelectedAtleastOneCheckBox2();"
                                 OnClick="Activate_Click" style="border-radius:1px solid black;" />                          
                         
                            <asp:Button ID="btnDeactivate" runat="server" Text="Disable"  
                                 OnClick="Deactivate_Click" style="border-radius:1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox3();"/>                          
                        
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return IsSelectedAtleastOneCheckBox();"/>                          
                          </td>
                          <td align="right" style="padding-bottom:10px;">
                            <asp:Button ID="btnCreateUser" runat="server" Text="Create New User" 
                                  style="border-radius:1px solid black;" PostBackUrl="Admin_ToCreateWebAdmins.aspx" />                          
                          </td>
                        </tr>
                         <tr>
                            <td colspan="2" style="padding-right:2%;">
                                <asp:DataGrid ID="ViewGridWbAdmin" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                       Width="710px" BorderWidth="1px" BorderColor="Black" BorderStyle="Solid" Font-Bold="False" Font-Italic="False" DataKeyField="empid"
                                                    AllowPaging="true" PageSize="10" OnPageIndexChanged="ViewGrid_PageIndexChanged" 
                                                onitemdatabound="ViewGridWbAdmin_ItemDataBound">
                                            <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                                            <ItemStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderWidth="1px" BorderColor="Black" BorderStyle="Solid" Height="30px"/>
                                            <EditItemStyle BackColor="#7C6F57" />
                                            <PagerStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" HorizontalAlign="Center" Mode="NumericPages" Height="25px"/>
                                            <AlternatingItemStyle BackColor="White" />

                                            <Columns>   
                                              <asp:TemplateColumn HeaderText="" ItemStyle-Width="50px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBoxreq" runat="server" />  
                                                </ItemTemplate>
                                                </asp:TemplateColumn>
                                                 <asp:BoundColumn DataField="UserId" HeaderText="User" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="fname" HeaderText="First Name" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="lname" HeaderText="Last Name" ItemStyle-Width="100px" 
                                                       ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                               
                                                <asp:BoundColumn DataField="AdminType" HeaderText="Designation" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                                                  <asp:BoundColumn DataField="Country" HeaderText="Country" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                                 <asp:TemplateColumn HeaderText="Created Date" ItemStyle-Width="100px" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCreatedate" runat="server" ItemStyle-BorderColor="Black" Text='<%# Eval("dateofcreation") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:BoundColumn DataField="WAStatus" HeaderText="Status" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                                  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
                                                                                        
                                            </Columns>
                                            
                                </asp:DataGrid>
                            </td>
                        </tr>
                    </table>
                    </td></tr>
                  </table>
                    </td>               
              </tr>                
            </table>                             
           </td>
         </tr>         
       </table>
       <input type="button"  style="display: none;" id="btndummy" runat="server" />
             <cc3:modalpopupextender ID="mpeEditUsersdata" runat="server" TargetControlID="btndummy" 
             PopupControlID="pnledit" DropShadow="false" BackgroundCssClass="modalBackground" 
             CancelControlID="btnclose">
                </cc3:modalpopupextender>
           <asp:Panel runat="server" ID="pnledit" Width="850px" Height="500px" BorderColor="Black"  
               BackImageUrl="images/edti_user_bg.png">
           <table width="100%"> 
            <tr>
                                <td>
                                <table width="100%">
                                <tr>
                                <td align="center" width="90%" ><b style="font-size:large;color:Red">&nbsp;</b></td><td width="10%" align="right" style="padding-right:10px"><asp:Button ID="btnclose" runat="server" Text="X" Font-Size="Larger"/></td>
                                </tr>
                                </table>
                                </td>
</tr>
            <tr><td><hr/></td></tr>
            </table>
            <table width="100%"> 
            <tr><td style="padding-left:10px;">
              <asp:Panel runat="server" ID="pnledit1" Width="830px" Height="420px" BorderColor="Black" ScrollBars="Vertical">
               <table width="100%"> 
            <tr><td colspan="3" style="padding-left:10px;">
                <table width="100%">
            <tr>
        <td class="datab1" align="right" width="20%">
        First Name
        </td>
        <td width="5%">:</td>
        <td align="left" width="20%">
        <asp:TextBox ID="txtedfname" runat="server" Width="136px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txtedfname" ErrorMessage="Please Enter First name" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter First name" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>
        <td class="datab1" align="right" width="20%">
        Last Name
        </td>
        <td width="5%">:</td>
        <td align="left" width="30%">
        <asp:TextBox ID="txtedlname" runat="server" Width="140px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="txtedfname" ErrorMessage="Please Enter Last name" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Last name" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>
        </tr>   
            <tr>
        <td class="datab1" align="right">
        Designation
        </td>
        <td>:</td>
        <td align="left">
        <asp:DropDownList ID="ddleddesgn" runat="server" Width="141px">
            <asp:ListItem Text="Select" >Select</asp:ListItem>
                <asp:ListItem Text="Admin">Admin</asp:ListItem>
                <asp:ListItem Text="Web Admin" >Web Admin</asp:ListItem>
                <asp:ListItem Text="Developer" >Developer</asp:ListItem>
                <asp:ListItem Text="Analyst" >Analyst</asp:ListItem>
                <asp:ListItem Text="Sales" >Sales</asp:ListItem>
                <asp:ListItem Text="Customer Service">Customer Service</asp:ListItem>
                    <asp:ListItem Text="Support" >Support</asp:ListItem>
                <asp:ListItem Text="Business Development" >Business Development</asp:ListItem>
        </asp:DropDownList>                                                                                                                                                  
        </td> 
        <td class="datab1" align="right">
        Country
        </td>
        <td>:</td>
        <td align="left">
        <asp:DropDownList ID="ddledcountry" runat="server" Width="143px">
                <asp:ListItem Text="Select" >Select</asp:ListItem>
                <asp:ListItem Text="India" >India</asp:ListItem>
                <asp:ListItem Text="USA" >USA</asp:ListItem>
                <asp:ListItem Text="UK" >UK</asp:ListItem>
                <asp:ListItem Text="Australia" >Australia</asp:ListItem>
                <asp:ListItem Text="Singapoor" >Singapore</asp:ListItem>
        </asp:DropDownList>   
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="ddledcountry" ErrorMessage="Please select Country" 
            ValidationGroup="UserIdCreation1" InitialValue="Select Country">*</asp:RequiredFieldValidator>                                                                                                                                               
        </td>                                         
        </tr>                                             
            <tr>
        <td class="datab1" align="right">
        User Id
        </td>
        <td>:</td>
        <td align="left">
      <%--  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate> --%>
        <asp:TextBox ID="txteduserid" runat="server" Width="136px" ontextchanged="txteduserid_TextChanged" 
             AutoPostBack="true"></asp:TextBox>                              
              
            <asp:Label ID="lblstatus" runat="server" ForeColor="Green"></asp:Label>                                          
       <%-- </ContentTemplate>
        </asp:UpdatePanel>--%>
        </td>  
        <td class="datab1" align="right">
        Password</td>
        <td>:</td>
        <td align="left">                                        
        <asp:TextBox ID="txtedpwd" runat="server" Width="140px" Enabled="false"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ControlToValidate="txtedpwd" ErrorMessage="Please Enter Password" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Password" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>                                     
        </tr>
            <tr>
        <td class="datab1" align="right">
        Address
        </td>
        <td>:</td>
        <td align="left">
        <asp:TextBox ID="txtedaddress" runat="server" Width="136px"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
        ControlToValidate="txtedaddress" ErrorMessage="Please Enter Address" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Address" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>  
        <td class="datab1" align="right">
        Mobile
        </td>
        <td>:</td>
        <td align="left">
        <asp:TextBox ID="txtedmob" runat="server" Width="140px" MaxLength="10"></asp:TextBox>   
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
        ControlToValidate="txtedmob" ErrorMessage="Please Enter Mobile Number" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Mobile Number" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>                                       
        </tr>
            <tr>
        <td class="datab1" align="right">
        Contact Number
        </td>
        <td>:</td>
        <td align="left">                                        
        <asp:TextBox ID="txtedcontact" runat="server" onkeypress="return isNumberKey(event)" MaxLength="11" Width="136px"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
        ControlToValidate="txtedcontact" ErrorMessage="Please Enter Contact Number" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Contact Number" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>
        <td class="datab1" align="right">
        Email Id
        </td>
        <td>:</td>
        <td align="left">
        <asp:TextBox ID="txtedmail" runat="server" Width="140px" Enabled="false"></asp:TextBox>                                                                           
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
        ControlToValidate="txtedmail" ErrorMessage="Please Enter Email" 
        ValidationGroup="UserIdCreation1" ToolTip="Please Enter Email" Display="Dynamic">*</asp:RequiredFieldValidator>  
        </td>
        </tr>
        </table>
                </td></tr>
            <tr><td height="20px" colspan="3">&nbsp;</td></tr>
            <tr><td height="20px" colspan="3">&nbsp;</td></tr>
            <tr>
              <td colspan="3" style="padding-left:10px;">
               <table width="100%" border="0">
                    <tr>
                        <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel" runat="server">
                                    <ContentTemplate> 
                            <table id="tblBModule">
                                <tr>
                                    <td  style="width: 97px">Business Category</td>
                                    <td class="style4" style="width: 100px">
                                        <asp:RadioButton ID="rbBYes" runat="server" GroupName="gB" Text="Yes" AutoPostBack="True"/>
                                        <asp:RadioButton ID="rbBNo" runat="server" GroupName="gB" Text="No" AutoPostBack="True" />
                                    </td>
                                </tr>  
                                <tr id="trIBModule" runat="server">
                                    <td colspan="2">
                                        <table width="100%" id="btab1">
                                                    
                                        <tr id="trBAll" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBAll" runat="server" Text="Select All"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkBAll" runat="server" 
                                            oncheckedchanged="chkBAll_CheckedChanged" AutoPostBack="true" />
                                    </td>
                                </tr>
                                            <tr id="trBPost" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBPost" runat="server" Text="Post"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxBPost" runat="server" onchange="selectOne(document.getElementById('btab1').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trBEdit" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBEdit" runat="server" Text="Edit"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxBEdit" runat="server" onchange="selectOne(document.getElementById('btab1').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trBDel" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBDel" runat="server" Text="Delete"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxBDel" runat="server" onchange="selectOne(document.getElementById('btab1').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));"/>
                                    </td>
                                </tr>
                                            <tr id="trBPreview" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBPreview" runat="server" Text="Preview"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                            <asp:CheckBox ID="chkbxBPreview" runat="server" onchange="selectOne(document.getElementById('btab1').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));" />
                                    </td>
                                </tr>   
                                            <tr id="trBApproval" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblBApproval" runat="server" Text="Approval"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                            <asp:CheckBox ID="chkbxBApproval" runat="server" onchange="selectOne(document.getElementById('btab1').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));" />
                                    </td>
                                </tr>  
                                        </table>
                                    </td>
                                </tr>                                                                              
                            </table>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate> 
                            <table id="tblB2Bmodule">
                                <tr>
                                    <td style="width: 97px">
                                        B2B Category 
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:RadioButton ID="rbB2BYes" runat="server" GroupName="gB2B" Text="Yes" AutoPostBack="True" />
                                        <asp:RadioButton ID="rbB2BNo" runat="server" GroupName="gB2B" Text="No" AutoPostBack="True" />
                                    </td>
                                </tr>
                                <tr id="trIB2BModule" runat="server">
                                    <td colspan="2">
                                        <table width="100%" id="b2btab">
                                        <tr id="trB2BAll" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2BAll" runat="server" Text="Select All"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkB2BAll" runat="server" 
                                            oncheckedchanged="chkB2BAll_CheckedChanged" AutoPostBack="true" />
                                    </td>
                                </tr>
                                            <tr id="trB2BPost" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2BPost" runat="server" Text="Post"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxB2BPost" runat="server"  onchange="selectOne(document.getElementById('b2btab').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trB2BEdit" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2BEdit" runat="server" Text="Edit"></asp:Label>
                                    </td>
                                    <td style="height: 20px; width: 100px;">
                                        <asp:CheckBox ID="chkbxB2BEdit" runat="server" onchange="selectOne(document.getElementById('b2btab').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trB2BDel" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2BDel" runat="server" Text="Delete"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxB2BDel" runat="server" onchange="selectOne(document.getElementById('b2btab').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trB2BPreview" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2Bview" runat="server" Text="Preview"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxB2Bview" runat="server" onchange="selectOne(document.getElementById('b2btab').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                    </td>
                                </tr>
                                            <tr id="trB2BApproval" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblB2BApproval" runat="server" Text="Approval"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                            <asp:CheckBox ID="chkbxB2BApproval" runat="server" onchange="selectOne(document.getElementById('b2btab').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                    </td>
                                </tr> 
                                        </table>
                                    </td>
                                </tr>                                                        
                            </table>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate> 
                            <table id="tblJobsmodule">
                                <tr>
                                    <td style="width: 97px">
                                        Jobs 
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:RadioButton ID="rbJobsYes" runat="server" GroupName="gJobs" Text="Yes" AutoPostBack="True" />
                                        <asp:RadioButton ID="rbJobsNo" runat="server" GroupName="gJobs" Text="No" AutoPostBack="True" />
                                    </td>
                                </tr>
                                <tr id="trIJobsModule" runat="server">
                                    <td colspan="2">
                                        <table width="100%" id="jobtab">
                                        <tr id="trJobsAll" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsAll" runat="server" Text="Select All"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkJobsAll" runat="server" 
                                            oncheckedchanged="chkJobsAll_CheckedChanged" AutoPostBack="true"/>
                                    </td>
                                </tr>
                                                <tr id="trJobsPost" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsPost" runat="server" Text="Post"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxJobsPost" runat="server" onchange="selectOne(document.getElementById('jobtab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                    </td>
                                </tr>
                                                <tr id="trJobsEdit" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsEdit" runat="server" Text="Edit"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxJobsEdit" runat="server" onchange="selectOne(document.getElementById('jobtab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));" />
                                    </td>
                                </tr>
                                                <tr id="trJobsDel" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsDel" runat="server" Text="Delete"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxJobsDel" runat="server" onchange="selectOne(document.getElementById('jobtab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                    </td>
                                </tr>
                                                <tr id="trJobsPreview" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsview" runat="server" Text="Preview"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                        <asp:CheckBox ID="chkbxJobsview" runat="server" onchange="selectOne(document.getElementById('jobtab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));" />
                                    </td>
                                </tr>
                                                <tr id="trJobsApproval" runat="server">
                                    <td class="datap5">
                                        <asp:Label ID="lblJobsApproval" runat="server" Text="Approval"></asp:Label>
                                    </td>
                                    <td class="style4" style="width: 100px">
                                            <asp:CheckBox ID="chkbxJobsApproval" runat="server" onchange="selectOne(document.getElementById('jobtab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));" />
                                    </td>
                                </tr>                 
                                        </table>
                                    </td>
                                </tr>                           
                            </table>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    </table>
             </td>
            </tr>
            <tr>
              <td colspan="3">
                <table width="100%" border="0">
                    <tr>
                        <td class="datab" width="30%">
                            <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                <ContentTemplate> 
                                <table id="tblEveModule">
                <tr>
                    <td  style="width: 97px">Events</td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbEveYes" runat="server" GroupName="gEve" Text="Yes" AutoPostBack="True"/>
                        <asp:RadioButton ID="rbEveNo" runat="server" GroupName="gEve" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trIEveModule" runat="server">
                    <td colspan="2">
                        <table width="100%" id="eventtab">
                        <tr id="trEveAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEveAll" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkEveAll" runat="server" 
                            oncheckedchanged="chkEveAll_CheckedChanged" AutoPostBack="true" />
                    </td>
                </tr>
                                <tr id="trEvePost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEvePost" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxEvePost" runat="server" onchange="selectOne(document.getElementById('eventtab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));" />
                    </td>
                </tr>
                                <tr id="trEveEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEveEdit" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxEveEdit" runat="server"  onchange="selectOne(document.getElementById('eventtab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));"/>
                    </td>
                </tr>
                                <tr id="trEveDel" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEveDel" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxEveDel" runat="server" onchange="selectOne(document.getElementById('eventtab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));" />
                    </td>
                </tr>
                                <tr id="trEvePreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEveview" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkbxEveview" runat="server" onchange="selectOne(document.getElementById('eventtab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));" />
                    </td>
                </tr> 
                                <tr id="trEveApproval" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblEveApproval" runat="server" Text="Approval"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkbxEveApproval" runat="server" onchange="selectOne(document.getElementById('eventtab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));" />
                    </td>
                </tr>  
                        </table>
                    </td>
                </tr>                                                 
            </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            </td>
                        <td class="datab" width="30%">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate> 
                    <table width="100%" border="0">
    <tr>
        <td class="datab" >
            <table id="tblDismodule">
                <tr>
                    <td style="width: 97px">
                        Discounts 
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbDisYes" runat="server" GroupName="gDis" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbDisNo" runat="server" GroupName="gDis" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trIDisModule" runat="server">
                    <td colspan="2">
                        <table width="100%" id="distab">
                        <tr id="trDisAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisAll" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkDisAll" runat="server" 
                            oncheckedchanged="chkDisAll_CheckedChanged" AutoPostBack="true" />
                    </td>
                </tr>
                                <tr id="trDisPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisPost" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxDisPost" runat="server" onchange="selectOne(document.getElementById('distab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                    </td>
                </tr>
                                <tr id="trDisEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisEdit" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkbxDisEdit" runat="server" onchange="selectOne(document.getElementById('distab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                    </td>
                </tr>
                                <tr id="trDisDel" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisDel" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxDisDel" runat="server" onchange="selectOne(document.getElementById('distab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                    </td>
                </tr>
                                <tr id="trDisPreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisview" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxDisview" runat="server" onchange="selectOne(document.getElementById('distab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                    </td>
                </tr> 
                                <tr id="trDisApproval" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblDisApproval" runat="server" Text="Approval"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkbxDisApproval" runat="server" onchange="selectOne(document.getElementById('distab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                    </td>
                </tr>  
                        </table>
                    </td>
                </tr>
                                                    
            </table>
        </td>
        </tr>
        </table>
        </ContentTemplate>
        </asp:UpdatePanel>  
                        </td>                  
                        <td class="datab" width="30%">
                            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate> 
                    <table width="100%" border="0">
    <tr>
        <td class="datab" >
            <table id="tblLSmodule">
                <tr>
                    <td  style="width: 97px">
                        LifeStyle 
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbLSYes" runat="server" GroupName="gLS" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbLSNo" runat="server" GroupName="gLS" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trILSModule" runat="server">
                    <td colspan="2">
                        <table width="100%" id="lifetab">
                        <tr id="trLSAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSAll" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkLSAll" runat="server" 
                            oncheckedchanged="chkLSAll_CheckedChanged" AutoPostBack="true" />
                    </td>
                </tr>
                            <tr id="trLSPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSPost" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxLSPost" runat="server" onchange="selectOne(document.getElementById('lifetab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));" />
                    </td>
                </tr>
                            <tr id="trLSEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSEdit" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxLSEdit" runat="server"  onchange="selectOne(document.getElementById('lifetab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"  />
                    </td>
                </tr>
                            <tr id="trLSDel" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSDel" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxLSDel" runat="server"  onchange="selectOne(document.getElementById('lifetab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"  />
                    </td>
                </tr>
                            <tr id="trLSPreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSview" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxLSview" runat="server"  onchange="selectOne(document.getElementById('lifetab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"  />
                    </td>
                </tr> 
                            <tr id="trLSApproval" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblLSApproval" runat="server" Text="Approval"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkbxLSApproval" runat="server"  onchange="selectOne(document.getElementById('lifetab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"  />
                    </td>
                </tr>  
                        </table>
                    </td>
                </tr>                                                                    
            </table>
        </td>
    </tr>
</table>
</ContentTemplate>
            </asp:UpdatePanel>
                        </td>
                    </tr>
                    </table>
              </td>
            </tr>
            <tr>
                <td colspan="3" style="padding-left:10px;">
                    <table width="100%" border="0">
    <tr>
        <td class="datab" width="30%">
        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate> 
            <table id="tblCareers">
                <tr>
                    <td  style="width: 97px">Careers</td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbCareersYes" runat="server" GroupName="gCareers" Text="Yes" AutoPostBack="True"/>
                        <asp:RadioButton ID="rbCareersNo" runat="server" GroupName="gCareers" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trICareers" runat="server">
                    <td colspan="2">
                        <table width="100%" id="careertab" >
                        <tr id="trCareersAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblCareersAll" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkCareersAll" runat="server" 
                            oncheckedchanged="chkCareersAll_CheckedChanged" AutoPostBack="true" />
                    </td>
                </tr>
                                <tr id="trCareersPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblCareersPost" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxCareersPost" runat="server"  onchange="selectOne(document.getElementById('careertab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"  />
                    </td>
                </tr>
                                <tr id="trCareersEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblCareersEdit" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxCareersEdit" runat="server" onchange="selectOne(document.getElementById('careertab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"  />
                    </td>
                </tr>
                                <tr id="trCareersDel" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblCareersDel" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkbxCareersDel" runat="server" onchange="selectOne(document.getElementById('careertab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));" />
                    </td>
                </tr>
                                <tr id="trCareersPreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="lblCareersview" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkbxCareersview" runat="server" onchange="selectOne(document.getElementById('careertab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"  />
                    </td>
                </tr> 
                <tr id="trCareersApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkCareersApproval" runat="server" onchange="selectOne(document.getElementById('careertab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"  />
                                </td>
                            </tr>                                                    
                        </table>
                    </td>
                </tr>
                                           
            </table>
            </ContentTemplate>
            </asp:UpdatePanel>
        </td>
                    
        <td class="datab" width="30%">
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate> 
            <table id="tblUserInfomodule">
                <tr>
                    <td  style="width: 97px">
                        Users Info
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbUInfoYes" runat="server" GroupName="gUInfo" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbUInfoNo" runat="server" GroupName="gUInfo" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                 <tr id="trIUInfo" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="userstab">
                                    <tr id="trUInfoAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkUInfoAll" runat="server" 
                                        oncheckedchanged="chkUInfoAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                    <tr id="trUInfoPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoPost" runat="server" onchange="selectOne(document.getElementById('userstab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>
                                    <tr id="trUInfoEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoEdit" runat="server" onchange="selectOne(document.getElementById('userstab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>
                                    <tr id="trUInfoDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoDel" runat="server" onchange="selectOne(document.getElementById('userstab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>
                                    <tr id="trUInfoPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoview" runat="server" onchange="selectOne(document.getElementById('userstab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>  
                             <tr id="trUInfoActDeact" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoActDeact" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoActDeact" runat="server" onchange="selectOne(document.getElementById('userstab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>                                         
                                    </table>
                                </td>
                            </tr>              
                                                                                             
            </table>
            </ContentTemplate>
            </asp:UpdatePanel>
        </td>
        <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                             <ContentTemplate> 
                                <table id="Table6">
                            <tr>
                                <td style="width: 97px">
                                    Exceptions
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:RadioButton ID="rbexyes" runat="server" GroupName="gex" Text="Yes" 
                                        AutoPostBack="True" />
                                    <asp:RadioButton ID="rbexno" runat="server" GroupName="gex" Text="No" 
                                        AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trExceptions" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="Exceptab">
                                     <tr id="trExceptionsAll"  runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsAll"  runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkExceptionsAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trExceptionsPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsPost" runat="server" onchange="selectOne(document.getElementById('Exceptab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));" />
                                </td>
                            </tr>
                                         <tr id="trExceptionsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkExceptionsEdit" runat="server"  onchange="selectOne(document.getElementById('Exceptab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trExceptionsDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsDelete" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsDelete" runat="server" onchange="selectOne(document.getElementById('Exceptab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));" />
                                </td>
                            </tr>
                               <tr id="trExceptionsPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsPreview"  runat="server" onchange="selectOne(document.getElementById('Exceptab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));" />
                                </td>
                            </tr> 
                               <tr id="trExceptionsApproval"  runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsApproval" runat="server" onchange="selectOne(document.getElementById('Exceptab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));" />
                                </td>
                            </tr>      
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
    </tr>
</table>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="padding-left:10px;">
                    <table width="100%" border="0">
                <tr>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate> 
                    <table id="tblMovies">
                <tr>
                    <td  style="width: 97px">Movies</td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbMYes" runat="server" GroupName="gMovie" Text="Yes" AutoPostBack="True"/>
                        <asp:RadioButton ID="rbMNo" runat="server" GroupName="gMovie" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trMovies" runat="server">
                    <td colspan="2">
                        <table width="100%" id="movietab">
                        <tr id="trMoviesAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Labelall" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMoviesAll" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkMoviesAll_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trMoviesPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label4" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMoviesPost" runat="server" onchange="selectOne(document.getElementById('movietab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));" />
                    </td>
                </tr>
                                <tr id="trMoviesEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label5" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMoviesEdit" runat="server" onchange="selectOne(document.getElementById('movietab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));" />
                    </td>
                </tr>
                                <tr id="trMoviesDelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label6" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMoviesDelete" runat="server" onchange="selectOne(document.getElementById('movietab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                    </td>
                </tr>
                                <tr id="trMoviesView" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label7" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="ChkMoviesView" runat="server" onchange="selectOne(document.getElementById('movietab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));" />
                    </td>
                </tr>   
                <tr id="trMoviesApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblMoviesApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkMoviesApproval" runat="server" onchange="selectOne(document.getElementById('movietab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>                                          
                        </table>
                    </td>
                </tr>                                                 
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate> 
                    <table id="tblCT">
                <tr>
                    <td style="width: 97px">
                        City Trends
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbCTYes" runat="server" GroupName="gCT" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbCTNo" runat="server" GroupName="gCT" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trCT" runat="server">
                    <td colspan="2">
                        <table width="100%" id="citytab">
                        <tr id="trCTAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label9" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkCTAll" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkCTAll_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trCTPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label10" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkCTPost" runat="server" onchange="selectOne(document.getElementById('citytab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));" />
                    </td>
                </tr>
                                <tr id="trCTEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label11" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkCTEdit" runat="server" onchange="selectOne(document.getElementById('citytab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));" />
                    </td>
                </tr>
                                <tr id="trCTDelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label12" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkCTDelete" runat="server" onchange="selectOne(document.getElementById('citytab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                    </td>
                </tr>
                                <tr id="trCTView" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label13" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkCTView" runat="server" onchange="selectOne(document.getElementById('citytab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));" />
                    </td>
                </tr> 
                <tr id="trCTApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCTApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkCTApproval" runat="server" onchange="selectOne(document.getElementById('citytab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));" />
                                </td>
                              </tr>                                            
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                    <ContentTemplate> 
                    <table id="tblMS">
                <tr>
                    <td style="width: 97px">
                        Media Speak
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbMSYes" runat="server" GroupName="gMS" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbMSNo" runat="server" GroupName="gMS" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trMS" runat="server">
                    <td colspan="2">
                        <table width="100%" id="mediatab">
                        <tr id="trMSAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label15" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMSAll" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkMSAll_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trMSPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label16" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMSPost" runat="server" onchange="selectOne(document.getElementById('mediatab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));" />
                    </td>
                </tr>
                                <tr id="trMSEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label17" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkMSEdit" runat="server" onchange="selectOne(document.getElementById('mediatab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));" />
                    </td>
                </tr>
                                <tr id="trMSDelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label18" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMSDelete" runat="server" onchange="selectOne(document.getElementById('mediatab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                    </td>
                </tr>
                                <tr id="trMSView" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label19" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkMSView" runat="server" onchange="selectOne(document.getElementById('mediatab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                    </td>
                </tr> 
                 <tr id="trMSApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblMSApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkMSApproval" runat="server" onchange="selectOne(document.getElementById('mediatab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));" />
                                </td>
                              </tr>                                           
                        </table>
                    </td>
                </tr>                                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
            </tr>
            </table>
            </td>
            </tr>
            <tr>
                <td colspan="3" style="padding-left:10px;">
                    <table width="100%" border="0">
                <tr>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate> 
                    <table id="tblAds">
                <tr>
                    <td style="width: 97px">Ads</td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbAdsYes" runat="server" GroupName="gAds" Text="Yes" AutoPostBack="True"/>
                        <asp:RadioButton ID="rbAdsNo" runat="server" GroupName="gAds" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trAds" runat="server">
                    <td colspan="2">
                        <table width="100%" id="adstab">
                        <tr id="trAdsAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label21" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkAdsAll" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chkAdsAll_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trAdsPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label22" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkAdsPost" runat="server" onchange="selectOne(document.getElementById('adstab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));" />
                    </td>
                </tr>
                                <tr id="trAdsEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label23" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkAdsEdit" runat="server" onchange="selectOne(document.getElementById('adstab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));" />
                    </td>
                </tr>
                                <tr id="trAdsDelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label24" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkAdsDelete" runat="server" onchange="selectOne(document.getElementById('adstab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                    </td>
                </tr>
                                <tr id="trAdsView" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label25" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkAdsView" runat="server" onchange="selectOne(document.getElementById('adstab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                    </td>
                </tr>  
                 <tr id="trAdsApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblAdsApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkAdsApproval" runat="server" onchange="selectOne(document.getElementById('adstab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));" />
                                </td>
                              </tr>                                           
                        </table>
                    </td>
                </tr>                                                 
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                    <ContentTemplate> 
                    <table id="tblFL">
                <tr>
                    <td style="width: 97px">
                        Free Listing
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbFLYes" runat="server" GroupName="gFL" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbFLNo" runat="server" GroupName="gFL" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trFL" runat="server">
                    <td colspan="2">
                        <table width="100%" id="freetab">
                        <tr id="trFLAll" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label27" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkFreelistAll" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chkFreelistAll_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trFLPost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label28" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkFreelistPost" runat="server" onchange="selectOne(document.getElementById('freetab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                    </td>
                </tr>
                                <tr id="trFLEdit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label29" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkFreelistEdit" runat="server"  onchange="selectOne(document.getElementById('freetab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                    </td>
                </tr>
                                <tr id="trFLDelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label30" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkFreelistDelete" runat="server"  onchange="selectOne(document.getElementById('freetab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                    </td>
                </tr>
                                <tr id="trFLView" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label31" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkFreelistView" runat="server"  onchange="selectOne(document.getElementById('freetab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                    </td>
                </tr> 
                                <tr id="trFLApprove" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label32" runat="server" Text="Approval"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkFLApprove" runat="server"  onchange="selectOne(document.getElementById('freetab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                    </td>
                </tr>  
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                    <ContentTemplate> 
                    <table id="tblwp">
                <tr>
                    <td  style="width: 97px">
                        White Pages
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbwpyes" runat="server" GroupName="gwp" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbwpno" runat="server" GroupName="gwp" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trwp" runat="server">
                    <td colspan="2">
                        <table width="100%" id="whitetab">
                        <tr id="trwpall" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label3" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkwhiteall" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chkwhiteall_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trwhitepost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label8" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkwhitepost" runat="server"  onchange="selectOne(document.getElementById('whitetab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                    </td>
                </tr>
                                <tr id="trwhiteedit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label14" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkwhiteedit" runat="server" onchange="selectOne(document.getElementById('whitetab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                    </td>
                </tr>
                                <tr id="trwhitedelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label20" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkwhitedelete" runat="server" onchange="selectOne(document.getElementById('whitetab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                    </td>
                </tr>
                                <tr id="trwhitepreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label26" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkwhitepreview" runat="server" onchange="selectOne(document.getElementById('whitetab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));" />
                    </td>
                </tr> 
                 <tr id="trwhiteApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblwhiteApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkwhiteApproval" runat="server" onchange="selectOne(document.getElementById('whitetab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));" />
                                </td>
                              </tr> 
                                        
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    </tr>
                    <tr>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                    <ContentTemplate> 
                    <table id="Table2">
                <tr>
                    <td class="tblsuccess" style="width: 97px">
                        Success Stories
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbssyes" runat="server" GroupName="gss" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbssno" runat="server" GroupName="gss" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trsuccess" runat="server">
                    <td colspan="2">
                        <table width="100%" id="successtab">
                        <tr id="trsuccessall" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label34" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksuccessall" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chksuccessall_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trsuccesspost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label35" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksuccesspost" runat="server" onchange="selectOne(document.getElementById('successtab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));" />
                    </td>
                </tr>
                                <tr id="trsuccessedit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label36" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chksuccessedit" runat="server" onchange="selectOne(document.getElementById('successtab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                    </td>
                </tr>
                                <tr id="trsuccessdelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label37" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksuccessdelete" runat="server" onchange="selectOne(document.getElementById('successtab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                    </td>
                </tr>
                                <tr id="trsuccesspreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label38" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksuccesspreview" runat="server" onchange="selectOne(document.getElementById('successtab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                    </td>
                </tr> 
                 <tr id="trsuccessApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsuccessApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chksuccessApproval" runat="server" onchange="selectOne(document.getElementById('successtab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                              </tr> 
                                         
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                    <ContentTemplate> 
                    <table id="tblcsr">
                <tr>
                    <td  style="width: 97px">
                        Social Welfare Information
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbcsryes" runat="server" GroupName="gcsr" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbcsrno" runat="server" GroupName="gcsr" Text="No" AutoPostBack="True"  />
                    </td>
                </tr>
                <tr id="trscr" runat="server">
                    <td colspan="2">
                        <table width="100%" id="socialtab">
                        <tr id="trscrall" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label40" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkcsrall" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chkcsrall_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trscrpost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label41" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkcsrpost" runat="server" onchange="selectOne(document.getElementById('socialtab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                    </td>
                </tr>
                                <tr id="trscredit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label42" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chkcsredit" runat="server" onchange="selectOne(document.getElementById('socialtab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                    </td>
                </tr>
                                <tr id="trscrdelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label43" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkcsrdelete" runat="server" onchange="selectOne(document.getElementById('socialtab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                    </td>
                </tr>
                                <tr id="trscrpreview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label44" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkcsrpreview" runat="server" onchange="selectOne(document.getElementById('socialtab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));" />
                    </td>
                </tr> 
                 <tr id="trscrApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblscrApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkscrApproval" runat="server" onchange="selectOne(document.getElementById('socialtab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr> 
                                        
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                    <ContentTemplate> 
                    <table id="tblsnf">
                <tr>
                    <td style="width: 97px">
                        Search not found
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbsnfyes" runat="server" GroupName="gsnf" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbsnfno" runat="server" GroupName="gsnf" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trsnf" runat="server">
                    <td colspan="2">
                        <table width="100%" id="searchtab">
                        <tr id="trsnfall" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label46" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksnfall" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chksnfall_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trsnfpost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label47" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksnpost" runat="server" onchange="selectOne(document.getElementById('searchtab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                    </td>
                </tr>
                 <tr id="trsnfEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chksnfEdit" runat="server" onchange="selectOne(document.getElementById('searchtab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr>
                    <tr id="trsnfdelete" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label49" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksnfdelete" runat="server" onchange="selectOne(document.getElementById('searchtab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                    </td>
                </tr>
                 <tr id="trsnfPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfPreview" runat="server" onchange="selectOne(document.getElementById('searchtab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr> 
                              <tr id="trsnfApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfApproval" runat="server" onchange="selectOne(document.getElementById('searchtab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr> 
                                                                                 
                        </table>
                    </td>
                </tr>
                            
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                                
            </tr>
            </table>
            </td>
            </tr>
            <tr>
            <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                    <ContentTemplate> 
                    <table id="tblslinks">
                <tr>
                    <td  style="width: 97px">
                        Sponsered Links
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbslyes" runat="server" GroupName="gsl" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbslno" runat="server" GroupName="gsl" Text="No" AutoPostBack="True" />
                    </td>
                </tr>
                <tr id="trslink" runat="server">
                    <td colspan="2">
                        <table width="100%" id="sponsertab">
                        <tr id="trslall" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label39" runat="server" Text="Select All"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkslall" runat="server" 
                            AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                    </td>
                </tr>
                                <tr id="trslpost" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label45" runat="server" Text="Post"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkslpost" runat="server" onchange="selectOne(document.getElementById('sponsertab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));" />
                    </td>
                </tr>
                                <tr id="trsledit" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label48" runat="server" Text="Edit"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 100px;">
                        <asp:CheckBox ID="chksledit" runat="server" onchange="selectOne(document.getElementById('sponsertab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                    </td>
                </tr>
                                <tr id="trsldel" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label50" runat="server" Text="Delete"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chksldel" runat="server" onchange="selectOne(document.getElementById('sponsertab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                    </td>
                </tr>
                                <tr id="trslview" runat="server">
                    <td class="datap5">
                        <asp:Label ID="Label51" runat="server" Text="Preview"></asp:Label>
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:CheckBox ID="chkslview" runat="server" onchange="selectOne(document.getElementById('sponsertab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                    </td>
                </tr> 
                 <tr id="trslApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblslApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkslApproval" runat="server" onchange="selectOne(document.getElementById('sponsertab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                                </td>

                            </tr> 
                                  
                                        
                        </table>
                    </td>
                </tr>
                                                    
            </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                    <ContentTemplate> 
                    <table id="tbltest">
                    <tr>
                    <td  style="width: 97px">
                        Testimonials
                    </td>
                    <td class="style4" style="width: 100px">
                        <asp:RadioButton ID="rbtestyes" runat="server" GroupName="gtest" Text="Yes" 
                                AutoPostBack="true"/>
                        <asp:RadioButton ID="rbtestno" runat="server" GroupName="gtest" Text="No" AutoPostBack="true" 
                            />
                    </td>
                </tr>
               <tr id="trtest" runat="server">
                                <td colspan="2">
                                   <table width="100%" id="testitab">
                                    <tr id="tr10" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label57" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chktestAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trtestimonialPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lbltestimonialPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chktesPost" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trtestimonialEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lbltestimonialEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chktesEdit" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trtestimonialDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lbltestimonialDelete" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chktesDelete" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trtestimonialPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lbltestimonialPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chktesPreview" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));" />
                                </td>
                            </tr> 
                                      <tr id="trtestimonialApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lbltestimonialApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chktestApproval" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                                </td>
                            </tr>     
                                    </table>
                                </td>
                            </tr>           
                </table>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                                                    <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                             <ContentTemplate> 
                                <table id="Table3">
                            <tr>
                                <td style="width: 97px">
                                    Customer Care
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbccareyes" runat="server" GroupName="gcc" Text="Yes" 
                                        AutoPostBack="True"  />
                                    <asp:RadioButton ID="rbccareno" runat="server" GroupName="gcc" Text="No" 
                                        AutoPostBack="True" Checked="true" 
                                        />
                                </td>
                            </tr>
                            <tr id="trCustomers" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="custmtab">
                                    <tr id="trCustAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCustAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkCustAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trCustPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCustPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCustPost" runat="server" onchange="selectOne(document.getElementById('custmtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCustEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCustEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkCustEdit" runat="server" onchange="selectOne(document.getElementById('custmtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));" />
                                </td>
                            </tr>
                                         <tr id="trCustDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCustDelete" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCustDelete" runat="server" onchange="selectOne(document.getElementById('custmtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                                </td>
                            </tr>
                               <tr id="trCustPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCustPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCustPreview" runat="server" onchange="selectOne(document.getElementById('custmtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                                </td>
                            </tr> 
                             <tr id="trcustApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblcustApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcustApproval" runat="server" onchange="selectOne(document.getElementById('custmtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                                </td>
                            </tr> 
                                        
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>

            </tr>
          
              <tr><td align="center" colspan="3"><asp:Button ID="btnsave" runat="server" Text="Save"  ValidationGroup="UserIdCreation1" 
                           Width="60px" OnClick="btnsave_Click"/></td></tr>
              </table>
              </asp:Panel>
              </td></tr>
           </table>
            </asp:Panel>
           
    </div>
    </center>
    </form>
</body>
</html>
