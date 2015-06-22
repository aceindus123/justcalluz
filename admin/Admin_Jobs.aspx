<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Jobs.aspx.cs" Inherits="admin_Admin_Jobs" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="smenu" TagPrefix="cc4"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Indus Times ---- Admin Control Panel</title>
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
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
    <table cellpadding="0" cellspacing="0">
<tr>
        <td colspan="2" align="right">
        <%--<cc1:headermenu ID="header" runat="server" />--%>
       <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
        </td>
        <td></td>
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
            
            <table cellspacing="5" style="height: 564px; width: 574px; margin-left: 0px">
              <tr>
                  <td>
                      <asp:Label ID="Label1" runat="server" Text="JOBS" Font-Bold="true"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label ID="lblMessage" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
              <td>
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                  <ContentTemplate>
                  
              <table width="100%">
              <tr>
                  <td class="adminform">Job Category</td>
                  <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                  <td>
                      <asp:DropDownList ID="ddlJobCat" runat="server" 
                          onselectedindexchanged="ddlJobCat_SelectedIndexChanged" AutoPostBack="true" Width="186px" >
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvJCat" runat="server" 
                          InitialValue="Select Job Category" ErrorMessage="Please Select Job Category" 
                          ControlToValidate="ddlJobCat" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="adminform">Job Sub Catecory</td>
                  <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                  <td>
                      <asp:DropDownList ID="ddlJobSubCat" runat="server" Width="186px">
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvJSubCat" runat="server" 
                          ErrorMessage="Please select Sub Category" ControlToValidate="ddlJobSubCat" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="adminform">Company Name</td>
                  <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                  <td>
                  <asp:TextBox ID="txtcompanyname" runat="server" Width="186px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfvCompname" runat="server" 
                          ErrorMessage="Please Enter Name of the Company" 
                          ControlToValidate="txtcompanyname" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
                                                   
              <tr>
                  <td class="adminform">Industry</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtIndName" runat="server" Width="187px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvIndName" runat="server" 
                          ErrorMessage="Please enter Industry" ControlToValidate="txtIndName" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Functional Area</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtfunarea" runat="server" Width="187px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvFunArea" runat="server" 
                          ErrorMessage="Please enter Functional Area" ControlToValidate="txtfunarea" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
               <tr>
                  <td class="adminform">Location</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtLocation" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvLocation" runat="server" 
                          ErrorMessage="Please enter Location" ControlToValidate="txtLocation" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Experience</td>
                  <td align="center">:</td>
                  <td>
                      <asp:DropDownList ID="ddlExp" runat="server" Width="188px" 
                          onselectedindexchanged="ddlExp_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="Select One">Select One</asp:ListItem>
                        <asp:ListItem Value="Fresher">Fresher</asp:ListItem>
                        <asp:ListItem Value="Experience">Experience</asp:ListItem>
                      </asp:DropDownList>
                      
                      <asp:RequiredFieldValidator ID="rfvddlexp" runat="server" 
                          ErrorMessage="Please Select One" ControlToValidate="ddlExp" 
                          InitialValue="Select One" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>                      
                   
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform"></td>
                  <td align="center"></td>
                  <td>
                      <asp:TextBox ID="txtexp" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvtxtexp" runat="server" 
                          ErrorMessage="Please enter experience in years Eg: 2-3yrs" 
                          ControlToValidate="txtexp" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Salary</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtSal" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvsal" runat="server" 
                          ErrorMessage="Please enter salary" ControlToValidate="txtSal" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Job Description</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtJobDesc" runat="server" Width="188px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvJobdesc" runat="server" 
                          ErrorMessage="Please enter Job Description" ControlToValidate="txtJobDesc" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Key Skills</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtkeyskills" runat="server" Width="188px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvskills" runat="server" 
                          ErrorMessage="Please enter Key skills" ControlToValidate="txtkeyskills" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Company Profile</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtCompProfile" runat="server" Width="188px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvcomprofile" runat="server" 
                          ErrorMessage="Please enter Company Profile" ControlToValidate="txtCompProfile" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Contact Person</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtContPerson" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvContPerson" runat="server" 
                          ErrorMessage="Please enter Name of the Contact Person" 
                          ControlToValidate="txtContPerson" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Email Id</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtEmailId" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" 
                          ErrorMessage="Please enter email id" ControlToValidate="txtEmailId" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="adminform">Phone</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtph" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                          ErrorMessage="Please enter Phone Number" ControlToValidate="txtph" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr>
             
             <tr>
                  <td class="adminform">Fax</td>
                  <td align="center">:</td>
                  <td>
                      <asp:TextBox ID="txtFax" runat="server" Width="188px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvFax" runat="server" 
                          ErrorMessage="Please enter Fax Number" ControlToValidate="txtFax" 
                          ValidationGroup="PostJob">*</asp:RequiredFieldValidator>
                  </td>
              </tr> 
              </table>
              </ContentTemplate>
                  </asp:UpdatePanel>  
              </td>
              </tr>
                       
              <tr>
              <td  colspan="3" align="center">
              <asp:Button ID="btnSubmitJobs" runat="server" Text="SUBMIT" 
                      onclick="btnSubmitJobs_Click" ValidationGroup="PostJob"/>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              </td>
              </tr>
              <tr>
                <td>
                   
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="PostJob" />
                   
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
    </form>
</body>
</html>
