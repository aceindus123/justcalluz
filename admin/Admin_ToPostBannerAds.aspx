<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToPostBannerAds.aspx.cs" Inherits="admin_Admin_ToPostBannerAds" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Post Banner Ads</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              <script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeleteData.aspx?cid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected Classified has been deleted Successfully");
}
function alertaccept()
{
alert("Selected Classified has been Accepted");
}
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Tv_Printads.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
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
                <td class="style39" valign="top" style="padding-top:10px">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                  <table border="0" width="750px">
                  <tr>
                     <td colspan='3' width="100%" align="left" bgcolor="#cccccc"><font face='Arial' size='2px' color='blue'>
                        <b>Post New Ads</b></font>
                     </td>
                   </tr>
                   <tr><td colspan="3" align="right">
                   <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
                    </td></tr>
                  <tr>
                    <td><asp:Label ID="AdvName" runat="server" Text="Advertiser First Name"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtAdvertiserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAdvName" runat="server" 
                            ControlToValidate="txtAdvertiserName" 
                            ErrorMessage="Please Enter Advertiser First Name" ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                                          </td>
                  </tr>
                  <tr>
                    <td><asp:Label ID="AdvLName" runat="server" Text="Advertiser Last Name"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtAdvertiserLName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtAdvertiserLName" 
                            ErrorMessage="Please Enter Advertiser Last Name" ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                                          </td>
                  </tr>
                  <tr>
                    <td><asp:Label ID="AdvAdress" runat="server" Text="Advertiser Address"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtAdvertiserAdress" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="txtAdvertiserAdress" 
                            ErrorMessage="Please enter Address ot the Advertiser " 
                            ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                                          </td>
                  </tr>
                  <tr>
                    <td><asp:Label ID="Phone" runat="server" Text="Phone Number"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtPhoneNumber" runat="server"  onkeypress="javascript:fnNumbersOnly();" MaxLength="11"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ControlToValidate="txtPhoneNumber" ErrorMessage="Please enter phone number" 
                            ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                                          </td>
                  </tr>
                  <tr>
                    <td><asp:Label ID="lblEmailId" runat="server" Text="Advertiser Email Id"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtEmailId" 
                            ErrorMessage="Please Enter Email Id of Advertiser" 
                            ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="txtEmailId" 
                            ErrorMessage="Please Enter a Valid Email Address" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                            ValidationGroup="postadgroup">*</asp:RegularExpressionValidator>
                                          </td>
                  </tr>
                  <tr>
                     <td><asp:Label ID="lblcountry" runat="server" Text="Country"></asp:Label></td>
                     <td><strong>:</strong></td>
                     <td>
                        <asp:DropDownList ID="ddlCountries" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged"
                           Width="150px" ValidationGroup="postadgroup">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                       </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="rfvcountries" runat="server" ControlToValidate="ddlCountries"
                            ErrorMessage="Select Country" InitialValue="Select" ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                     </td>
                   </tr>
                  <tr>
                     <td><asp:Label ID="lblcity" runat="server" Text="City"></asp:Label></td>
                     <td><strong>:</strong></td>
                     <td>
                        <asp:DropDownList ID="ddlcities" runat="server" Width="150px" 
                          ValidationGroup="postadgroup">
                        <asp:ListItem Value="Select">Select</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvcities" runat="server" ControlToValidate="ddlcities"
                                                                                        
                          InitialValue="Select" ValidationGroup="postadgroup" 
                          ErrorMessage="Please select City">*</asp:RequiredFieldValidator>
                     </td>
                   </tr>
                   <tr>
                     <td><asp:Label ID="lblcategory" runat="server" Text="Category"></asp:Label></td>
                     <td><strong>:</strong></td>
                     <td>
                         <asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" Width="150px" 
                          ValidationGroup="postadgroup" 
                             onselectedindexchanged="ddlcategory_SelectedIndexChanged">
                             <asp:ListItem Value="Select">Select</asp:ListItem>                      
                         </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvcategory" runat="server" ControlToValidate="ddlcategory"
                            ErrorMessage="Select Category" InitialValue="Select" 
                              ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                     </td>
                   </tr>
                   <tr>
                     <td><asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label></td>
                     <td><strong>:</strong></td>
                     <td>
                         <asp:DropDownList ID="ddllocation" runat="server" AutoPostBack="True" Width="150px" 
                          ValidationGroup="postadgroup" 
                             onselectedindexchanged="ddllocation_SelectedIndexChanged">
                             <asp:ListItem Value="Select">Select</asp:ListItem>                       
                         </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvlocation" runat="server" ControlToValidate="ddllocation"
                            ErrorMessage="Select Location" InitialValue="Select" 
                              ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                    </td>
                  </tr>                                   
                  <tr>
                    <td><asp:Label ID="lblimagesize" runat="server" Text="Image Size"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td><asp:TextBox ID="txtimagesize" runat="server" Enabled="false"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td><asp:Label ID="lblads" runat="server" Text="Ads"></asp:Label></td>
                    <td><strong>:</strong></td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="FileUpload1" 
                            ErrorMessage="Please Upload Banner with valid dimensions." 
                            ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                    </td>
                  </tr>
                  <tr>
                    <td colspan="2"></td>
                    <td><asp:Label ID="lblimage" runat="server" ForeColor="Desktop" Font-Size="11px" Text="Supported Formats: .gif, .jpg, .png, .bmp. "></asp:Label></td>
                  </tr>                                 
                     <tr>
                      <td>
                        <asp:Label ID="lblAdTitle" runat="server" Text="Name of the Company"></asp:Label>
                      </td>
                      <td><strong>
                        <asp:Label ID="lblAdTitlecol" runat="server" Text=":"></asp:Label></strong></td>
                      <td>
                        <asp:TextBox ID="txtAdTitle" runat="server" MaxLength="15"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtAdTitle" ErrorMessage="Please enter Ad Title" 
                            ValidationGroup="postadgroup">*</asp:RequiredFieldValidator>
                      </td>
                     </tr>                                                                          
                  <tr>
                    <td>
                        <asp:Label ID="lblUrl" runat="server" Text="URL"></asp:Label>
                    </td>
                    <td><strong><asp:Label ID="lblUrlcol" runat="server" Text=":"></asp:Label></strong></td>
                    <td>
                        <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>                    
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtUrl" ErrorMessage="Please enter valid URL" 
                            ValidationGroup="postadgroup" 
                            ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:RegularExpressionValidator>
                    </td>
                  </tr>                      
                                   
                  <tr>
                    <td colspan="3" align="center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" ValidationGroup="postadgroup"/>
                    </td>
                  </tr>
                  </table>
                  <asp:Label ID="lblmsg" runat="server"></asp:Label>
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
