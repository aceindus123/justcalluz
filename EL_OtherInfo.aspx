<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EL_OtherInfo.aspx.cs" Inherits="EL_OtherInfo" %>
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
        <td colspan="3"><p><strong>Hours of Operation</strong></p>
         <table width="100%"><tr><td>
              <asp:RadioButton ID="RBDisplay" runat="server" Text="." /></td>
             <td> Display hours of operation </td>
               <td> <asp:RadioButton ID="RBDontDisplay" runat="server" Text="." /></td>
             <td> Do not display hours of operation</td></tr></table>
          <p>&nbsp;</p></td>
        </tr>
      <tr>
        <td colspan="3"><table width="100%" border="0">
          <tr>
            <td width="13%" height="30">Monday </td>
            <td width="4%" align="center"><strong>:</strong></td>
            <td width="18%">
                <asp:DropDownList ID="ddlMonFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td width="6%" align="center">To</td>
            <td width="20%">
             <asp:DropDownList ID="ddlMonTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td width="39%">
            <asp:CheckBox ID="ChkMonClosed" runat="server" />
          Closed</td>
          </tr>
          <tr>
            <td height="30">Tuesday</td>
            <td align="center"><strong>:</strong></td>
            <td>
             <asp:DropDownList ID="ddlTuesFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
             <asp:DropDownList ID="ddlTuesTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td><asp:CheckBox ID="ChkTuesClosed" runat="server" />
            Closed</td>
          </tr>
          <tr>
            <td height="30">Wednesday</td>
            <td align="center"><strong>:</strong></td>
            <td>
            <asp:DropDownList ID="ddlWedFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
              <asp:DropDownList ID="ddlWedTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td><asp:CheckBox ID="ChkWedClosed" runat="server" />
Closed</td>
          </tr>
          <tr>
            <td height="30">Thursday</td>
            <td align="center"><strong>:</strong></td>
            <td>
             <asp:DropDownList ID="ddlThurFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
             <asp:DropDownList ID="ddlThurTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:CheckBox ID="ChkThurClosed" runat="server" />
Closed</td>
          </tr>
          <tr>
            <td height="30">Friday</td>
            <td align="center"><strong>:</strong></td>
            <td>
             <asp:DropDownList ID="ddlFriFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
             <asp:DropDownList ID="ddlFriTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:CheckBox ID="ChkFriClosed" runat="server" />
Closed</td>
          </tr>
          <tr>
            <td height="30">Saturday</td>
            <td align="center"><strong>:</strong></td>
            <td>
             <asp:DropDownList ID="ddlSatFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
             <asp:DropDownList ID="ddlSatTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:CheckBox ID="ChkSatClosed" runat="server" />
Closed</td>
          </tr>
          <tr>
            <td height="30">Sunday</td>
            <td align="center"><strong>:</strong></td>
            <td>
             <asp:DropDownList ID="ddlSunFtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td align="center">To</td>
            <td>
             <asp:DropDownList ID="ddlSunTtmgs" runat="server" Width="70px">
                <asp:ListItem Selected="True">Select</asp:ListItem>
                </asp:DropDownList></td>
            <td><asp:CheckBox ID="ChkSunClosed" runat="server" />
Closed</td>
          </tr>
          <tr>
            <td height="36" colspan="6"><a href="javascript:copy_all('time');">Copy Timings from Monday to Saturday</a><br />
            <a href="javascript:show_evening('evening_time');">Click Here For Dual Timings</a></td>
            </tr>
        </table></td>
      </tr>
      <tr>
        <td height="19" colspan="3" style="border-bottom:1px #C2DFFC dotted">&nbsp;</td>
      </tr>
      <tr>
        <td height="40" colspan="3"><strong>Payment Modes Accepted By You</strong></td>
      </tr>
     <tr>
        <td colspan="3"><table width="100%" border="0">
        <tr><td>
            <asp:CheckBoxList ID="ChkPayType" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" Width="100%">
             <asp:ListItem Value="Select All">Select All</asp:ListItem>
            <asp:ListItem Value="Visa Card">Visa Card</asp:ListItem>
             <asp:ListItem Value="Debit Cards">Debit Cards</asp:ListItem>
             <asp:ListItem Value="Money Orders">Money Orders</asp:ListItem>
              <asp:ListItem Value="Cheques">Cheques</asp:ListItem> 
              <asp:ListItem Value="Credit Card">Credit Card</asp:ListItem>
               <asp:ListItem Value="Travelers Cheque">Travelers Cheque</asp:ListItem>
                <asp:ListItem Value="Financing Available">Financing Available</asp:ListItem>
                <asp:ListItem Value="American Express">American Express</asp:ListItem>
                <asp:ListItem Value="Diners Club Card">Diners Club Card</asp:ListItem>
                <asp:ListItem Value="Master Card">Master Card</asp:ListItem>
                <asp:ListItem Value="Money">Money</asp:ListItem>
              
            </asp:CheckBoxList>
        </td></tr>
      
         </table></td>
      </tr>
      <tr>
      <td height="19" colspan="3" style="border-bottom:1px #C2DFFC dotted">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3"><p><strong>Company Information</strong></p></td>
      </tr>
      <tr>
        <td colspan="3"><table width="100%" border="0">
          <tr>
            <td width="28%"><label>Year Of Establishment</label></td>
            <td width="2%" align="center"><strong>:</strong></td>
            <td width="70%">
            <table border="0" width="100%"><tr><td width="15%">
             <asp:TextBox ID="txtYrEstd" runat="server" Width="60px" Text="1997"></asp:TextBox></td>
             <td width="30%"><asp:TextBox ID="txtTurnOver" runat="server" Text="Annual Turn Over"></asp:TextBox>
                </td>
                <td width="55%"><asp:DropDownList ID="ddlEmpCount" runat="server">
                     <asp:ListItem value="Select No. Of Employees">Select No. Of Employees</asp:ListItem>
                <asp:ListItem value="Less than 10">Less than 10</asp:ListItem>
                <asp:ListItem value="100-500">100-500</asp:ListItem>
                 <asp:ListItem value="500-1000">500-1000</asp:ListItem>
                <asp:ListItem value="1000-2000">1000-2000</asp:ListItem>
                <asp:ListItem value="2000-5000">2000-5000</asp:ListItem>
                <asp:ListItem value="5000-10000">5000-10000</asp:ListItem>
                <asp:ListItem value="More than 10000">More than 10000</asp:ListItem>
                </asp:DropDownList>
                </td></tr></table>
            </td>
          </tr>
          <tr>
            <td>Professional Associations</td>
            <td align="center"><strong>:</strong></td>
            <td style="padding-left:2px">
                <asp:TextBox ID="txtProfAssoc" runat="server"></asp:TextBox>
             </td>
          </tr>
          <tr>
            <td><label>Certifications</label></td>
            <td align="center"><strong>:</strong></td>
            <td style="padding-left:2px">
                <asp:TextBox ID="txtCertified" runat="server"></asp:TextBox>
            </td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td colspan="3">&nbsp;</td>
      </tr>
      <tr>
        <td width="22%" height="40">&nbsp;</td>
        <td width="2%">&nbsp;</td>
        <td width="76%" height="40"><img src="images/s&e.png" width="100" height="25" /> &nbsp;&nbsp;<img src="images/s&c.png" width="143" height="25" /></td>
      </tr>
      <tr>
        <td><a href="EL_ContactInfo.aspx">&lt;&lt; previous</a></td>
        <td>&nbsp;</td>
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
