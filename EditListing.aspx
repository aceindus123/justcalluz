<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditListing.aspx.cs" Inherits="EditListing" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/EL_LeftMenu.ascx" TagName="Editlisting" TagPrefix="ELLM" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Edit Listing Business Info</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
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
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
   <div class="logo" style="height:82px; float:left; padding:0px;"><a href="#"></a>
    <table width="100%" border="0">
      <tr>
        <td width="42%" style="padding: 10px 0 0 0; height:75px"><a href="#"><img src="images/logo_small.jpg" width="200" height="62" /></a></td>
        <td width="3%">&nbsp;</td>
        <td width="55%" align="right"><h2 style="color:#036">Edit Listing For&nbsp;<asp:Label ID="lblbusiness" runat="server"></asp:Label></h2> </td>
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
        <td width="22%"><label for="bus_name3"><strong>Business Name</strong></label></td>
        <td width="3%" align="center"><strong>:</strong></td>
        <td width="75%" height="40">
            <asp:TextBox ID="txtBName" runat="server" style="width:200px; height:15px; padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td><strong>Building</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
         <asp:TextBox ID="txtBuilding" runat="server" style="width:200px; height:15px;padding:5px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td><strong>Street</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
         <asp:TextBox ID="txtStreet" runat="server" style="width:200px; height:15px;padding:5px"></asp:TextBox>        
       </td>
      </tr>
      <tr>
        <td><strong>Landmark</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
          <asp:TextBox ID="txtLMark" runat="server" style="width:200px; height:15px;padding:5px"></asp:TextBox>        
        </td>
      </tr>
      <tr>
        <td><strong>Area</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
         <asp:TextBox ID="txtArea" runat="server" style="width:200px; height:15px;padding:5px"></asp:TextBox>        
        </td>
      </tr>
      <tr>
        <td><strong>City</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
         <asp:TextBox ID="txtCity" runat="server" 
                style="width:200px; height:15px;padding:5px" 
                ontextchanged="txtCity_TextChanged" AutoPostBack="true"></asp:TextBox>  
            <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true">
            </cc1:AutoCompleteExtender>
            <cc1:TextBoxWatermarkExtender ID="TWExtender1" runat="server" TargetControlID="txtCity" WatermarkText="City Name" WatermarkCssClass="water">
            </cc1:TextBoxWatermarkExtender>
        </td>
      </tr>
      <tr>
        <td><strong>Pin Code</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
        <asp:DropDownList ID="ddlPCode" runat="server">
        <asp:ListItem Selected="True" Enabled="true">Select</asp:ListItem>
        </asp:DropDownList>
        </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td height="30"><asp:LinkButton ID="lnkMap" runat="server">Select Location On Map</asp:LinkButton>
            <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="lnkMap" PopupControlID="pnlmap" BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btnclose">
            </cc1:ModalPopupExtender>

        </td>
      </tr>
      <tr>
        <td><strong>State</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
        <asp:TextBox ID="txtState" runat="server" style="width:200px; height:15px;padding:5px" ReadOnly="true" BackColor="White"></asp:TextBox>        
        </td>
      </tr>
      <tr>
        <td><strong>Country</strong></td>
        <td align="center"><strong>:</strong></td>
        <td height="40">
        <asp:TextBox ID="txtCountry" runat="server" style="width:200px; height:15px;padding:5px" ReadOnly="true" BackColor="White"></asp:TextBox>        
        </td>
      </tr>
      <tr>
        <td height="40">&nbsp;</td>
        <td>&nbsp;</td>
        <td height="40"><img src="images/s&e.png" width="100" height="25" /> &nbsp;&nbsp;<img src="images/s&c.png" width="143" height="25" /></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td align="right"><a href="EL_ContactInfo.aspx">next &gt;&gt;</a></td>
      </tr>
      <tr>
        <td colspan="3" align="center" class="star">For Any Kind Of Assistance In Filling This form Call 040-66136226</td>
        </tr>
          <tr>
        <td colspan="3" align="center" class="star">
            <asp:Panel ID="pnlmap" runat="server" Width="100%">
                <asp:Button ID="btnclose" runat="server" Text="Close" />
            <div id="divMap"></div>
            </asp:Panel>
        </td>
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
