<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EL_AddKeywrds.aspx.cs" Inherits="EL_AddKeywrds" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/EL_LeftMenu.ascx" TagName="Editlisting" TagPrefix="ELLM" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Edit Listing Business Info</title>
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
        <td colspan="3"><p class="star">Whatever changes you make, will be taken live post 
            verification!     </tr>
      <tr>
        <td height="40" colspan="3"><p><strong>Type your Business Keywords and click Search</strong></p></td>
        </tr>
      <tr>
        <td colspan="3"><table width="100%" border="0">
          <tr>
            <td width="65%">
                <asp:TextBox ID="txtaddkeywrd" runat="server"  style="width:400px; height:14px; padding:5px" ></asp:TextBox>
           </td>
            <td width="1%">&nbsp;</td>
            <td width="34%"><img src="images/search_edit.jpg" width="64" height="25" /></td>
          </tr>
        </table></td>
      </tr>
    
      <tr>
        <td colspan="3" style="border-bottom:1px #C2DFFC dotted">&nbsp;</td>
      </tr>
      <tr>
        <td height="200" colspan="3">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3" style="border-bottom:1px #C2DFFC dotted">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3">&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        <td height="40"><img src="images/s&e.png" width="100" height="25" /> &nbsp;&nbsp;<img src="images/s&c.png" width="143" height="25" /></td>
      </tr>
      <tr>
        <td align="left"><a href="EL_OtherInfo.aspx">&lt;&lt; previous</a></td>
        <td>&nbsp;</td>
        <td align="right">&nbsp;</td>
        <td align="right"><a href="EL_Busineskeywrds.aspx">next &gt;&gt;</a></td>
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
