<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EL_ContactInfo.aspx.cs" Inherits="EL_ContactInfo" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/EL_LeftMenu.ascx" TagName="Editlisting" TagPrefix="ELLM" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Edit Listing Contact Info</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
   <div class="layout">
  <div class="logo" style="height:82px; float:left; padding:0px;"><a href="#"></a>
    <table width="100%" border="0">
      <tr>
        <td width="42%" style="padding: 10px 0 0 0;"><a href="#"><img src="images/logo_small.jpg" width="200" height="62" /></a></td>
        <td width="5%">&nbsp;</td>
        <td width="53%" align="right"><h1  style="color:#036">Edit Listing Business Info</h1> </td>
      </tr>
    </table>
  </div>
  <!-- staart the Content-->
  <div class="content_edit">
  <div class="content_edit_left">
    <ELLM:Editlisting ID="ELLM" runat="server" />
  </div>
  <div class="content_edit_right">
    <table width="100%" border="0">
      <tr>
        <td colspan="3"><p class="star">Whatever changes you make, will be taken live post verification!</p></td>
        </tr>
      <tr>
        <td colspan="3">&nbsp;</td>
        </tr>
      <tr>
        <td width="16%"><label for="bus_name3"><strong>Contact Person</strong></label></td>
        <td width="3%" align="center"><strong>:</strong></td>
        <td width="81%" height="40">
            <asp:DropDownList ID="ddlMStatus" runat="server" style="height:25px;">
            <asp:ListItem Value="Mr"></asp:ListItem>
            <asp:ListItem Value="Mrs"></asp:ListItem>
            <asp:ListItem Value="Miss"></asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtName" runat="server" style="width:142px; height:12px; padding:5px"></asp:TextBox>
            <asp:TextBox ID="txtDesig" runat="server" style="width:142px; height:12px; padding:5px"></asp:TextBox>
            
          <br /></td>
      </tr>
      <tr>
        <td><p>
          <label for="lan2_num"><strong>Landline No</strong></label>
        </p></td>
        <td align="center"><strong>:</strong></td>
        <td height="40"><span id="std_code">+91-40-</span>
            <asp:TextBox ID="txtLNo" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        <td height="20"><label></label>
          <a href="javascript:append_fields('contact_info','contact_landline','container_landline','lnum')">Add More Landline Numbers</a></td>
      </tr>
      <tr>
        <td> <strong>Mobile No </strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="30"><span id="std_code2">+91-</span>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMobNo" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
         </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        <td height="20"><a href="javascript:append_fields('contact_info','contact_mobile','container_mobile','mnum')">Add More Mobile Numbers</a><br /></td>
      </tr>
      <tr>
        <td> <strong>Fax No</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40"><label for="fax_num"></label>
          <span id="std_code3">+91-40-</span>
        <asp:TextBox ID="txtFaxNo" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
     </td>
      </tr>
      <tr>
        <td><p>
          <label for="fax2_num"><strong>Fax No 2</strong></label>
        </p></td>
        <td align="center"><strong>:</strong></td>
        <td height="40"><label for="fax_num"></label>
          <span id="std_code4">+91-40-</span>
           <asp:TextBox ID="txtFaxNo2" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
          </td>
      </tr>
      <tr>
        <td> <strong>Toll Free No</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
           <asp:TextBox ID="txtTolFree" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td> <strong>Toll Free No 2</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
        <asp:TextBox ID="txtTolFree2" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td> <strong>Email ID</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
        <asp:TextBox ID="txtEmail" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
        <label for="email_id"></label>
            <asp:CheckBox ID="ChkFeedBack" runat="server" />
          Feedback Via Email</td>
      </tr>
      <tr>
        <td> <strong>Website</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
         <asp:TextBox ID="txtWebsite" runat="server" style="width:155px; height:12px; padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        <td height="40"><img src="images/s&amp;e.png" width="100" height="25" /> &nbsp;&nbsp;<img src="images/s&amp;c.png" width="143" height="25" /></td>
      </tr>
      <tr>
        <td align="left"><a href="EditListing.aspx">&lt;&lt; previous</a></td>
        <td>&nbsp;</td>
        <td align="right"><a href="EL_OtherInfo.aspx">next &gt;&gt;</a></td>
      </tr>
      <tr>
        <td colspan="3" align="center" class="star">For Any Kind Of Assistance In Filling This form Call 040-66136226</td>
        </tr>
    </table>
       </div>
  </div>
  <div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
  </div>

<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </form>
</body>
</html>
