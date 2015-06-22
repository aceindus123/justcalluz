<%@ Control Language="C#" AutoEventWireup="true" CodeFile="report_left.ascx.cs" Inherits="usercontrols_report_left" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<table width="100%" border="0">
    <tr>
      <td align="left" style="background:url(images/write-new.png) no-repeat" height="30"><table width="100%" border="0">
        <tr>
          <td style="padding-left:26px;" class="button_list" valign="middle"> 
             <%-- <asp:LinkButton  ID="lnkrev" runat="server"   
                 Text="Write Review"  CommandName ="Select" onclick="LinkButton1_Click" ></asp:LinkButton>--%>
                 <a id="lnkrev" runat="server" onserverclick="LinkButton1_Click"><asp:Label ID="lblWReview" runat="server" Text="Write Review"></asp:Label></a>
          </td>
          </tr>
  </table>
  </td>
      </tr>
    <tr>
      <td align="left"><table width="100%" border="0" style="background:url(images/write-new.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
            <%--<asp:LinkButton ID="lnkincorrect" runat="server" Text="Report Incorrect"></asp:LinkButton>--%>
            <a id="lnkincorrect" runat="server" class="pointer"><asp:Label ID="Label4" runat="server" Text="Report Incorrect"></asp:Label></a>
          </td>
          </tr>
  </table>
  </td>
        </tr>
    <tr>
      <td align="left"><table width="100%" border="0" style="background:url(images/write-new.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
              <%--<asp:LinkButton ID="lnkedit" runat="server" Text="Edit Listing"></asp:LinkButton>--%>
               <a id="lnkedit" runat="server" class="pointer"><asp:Label ID="Label3" runat="server" Text="Edit Listing"></asp:Label></a>
           </td>
          </tr>
  </table>
  </td>
        </tr>
   
    <tr>
      <td align="left" ><table width="100%" border="0" style="background:url(images/write-new.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
           <%-- <asp:LinkButton ID="lnkreptabuse" runat="server" Text="Report Abuse"></asp:LinkButton>--%>
           <a id="lnkreptabuse" runat="server" class="pointer"><asp:Label ID="Label2" runat="server" Text="Report Abuse"></asp:Label></a>
          </td>
          </tr>
  </table>
  </td>
        </tr>
    <tr>
      <td align="left"  ><table width="100%" border="0" style="background:url(images/write-new.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
           <%--<asp:LinkButton ID="lnklocatemap" runat="server" Text="Locate Map"></asp:LinkButton>--%>
            <a id="lnklocatemap" runat="server" class="pointer"><asp:Label ID="Label1" runat="server" Text="Locate Map"></asp:Label></a>
         </td>
          </tr>
  </table>
  </td>
        </tr>
        <tr>
      <td align="left" ><table width="100%" border="0" style="background:url(images/write-newbg.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
          <%--<asp:LinkButton ID="lnklife" runat="server" Text="Advertise Your Company" 
                  onclick="lnklife_Click"></asp:LinkButton>--%>
           <a id="lnklife" runat="server" onserverclick="lnklife_Click"><asp:Label ID="lbkAdCompny" runat="server" Text="Advertise Your Company"></asp:Label></a>
          </td>
          </tr>
      </table>
  </td>
        </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    <tr>
      <td>&nbsp;</td>
      </tr>
    
    </table>
 <table>
  <tr><td>
  <asp:Panel ID="pnlincorrect" runat="server" BorderColor="Gray">
<%--  <fieldset style="width: 350px">--%>
     <table width="100%" border="0" style="background:url(images/panel/dialog_box_bg.png) no-repeat; width:350px; 
		  height:266px; margin:0px auto; top:100px;">
  <tr>
    <td width="60%" class="sub_menu" align="right">
    <asp:Label ID="lblreport" runat="server" Text="Report Incorrect ?" CssClass="sub_menu"></asp:Label></td>
    <td width="37%" height="38" align="right">
        <asp:ImageButton ID="btnimgGo" runat="server" Width="21" Height="22" ImageUrl="images/panel/cencel.png"/>
   </td>
    <td width="3%">&nbsp;</td>
  </tr>
<tr>
    <td height="176" colspan="3">
    <table width="100%" border="0">
     <tr>
      <td class="side_menu" style="padding-left:5px;">If you find any details incorrect, let us know by 
         entering a comment here.</td>
     </tr>
    <tr>
    <td align="center">
     <asp:TextBox ID="txtrpt" runat="server" TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox>
       <asp:RequiredFieldValidator ID="rfvtxtrpt" runat="server" 
            ControlToValidate="txtrpt" ErrorMessage="Please enter comment" 
            ValidationGroup="incorrect">*</asp:RequiredFieldValidator>
     </td>
    </tr>
    <tr>
     <td>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="16px" 
            ShowMessageBox="True" ShowSummary="False" ValidationGroup="incorrect" 
            Width="287px" />
         &nbsp;&nbsp;&nbsp; Eg: Invalid phone number 
     </td>
     </tr>
    </table>
    </td>
   
  </tr>
  <tr>
   <td height="41" align="right" colspan="2">
   <asp:ImageButton ID="imgbtnIncorrect" ImageUrl="../images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="incorrect"
      onclick="imgbtnIncorrect_Click" />
  </td>
    <td>&nbsp;</td>
  </tr>
</table>
  
  </asp:Panel>
  </td></tr>
    </table>
    <cc1:ModalPopupExtender ID="incorrect" runat="server" PopupControlID="pnlincorrect" TargetControlID="lnkincorrect" 
     OkControlID="btnimgGo" BackgroundCssClass="modalBackground" DropShadow="false"></cc1:ModalPopupExtender>
<table width="324px"><tr><td>
 <asp:Panel ID="pnlreportabuse" runat="server" Width="350px">
   <table width="350px" style="background:url(images/panel/dialog_box_bg.png) no-repeat; width:350px; 
		  height:266px;margin:0px auto;top:100px;">
<tr>
  <td colspan="3" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Report Abuse ! 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="btncancel" ImageUrl="~/images/panel/cencel.png" width="21" height="22" runat="server"/>
 </td>
</tr>
<tr>
  <td height="184" colspan="3">
     <table align="center" width="320px" style="height: 184px;">
      <tr style="margin-left:5px">
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblname" runat="server" Text="Name" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtname" runat="server" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
             ControlToValidate="txtname" ErrorMessage="Please enter your Name" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
       </td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblcontno" runat="server" Text="Contact No" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtcntno" runat="server" MaxLength="11" Width="160px" Height="25px"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="only numbera are allowed" 
             ValidationExpression="\d{11}" ValidationGroup="abuse">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="Please enter your contact number" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
             <asp:RangeValidator ID="RangeValidator2" runat="server" 
          ControlToValidate="txtcntno" ErrorMessage="Number must start with 0" 
          MaximumValue="1" MinimumValue="0" ValidationGroup="abuse">*</asp:RangeValidator></td>
        </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="lblemail" runat="server" Text="Email Id" ForeColor="Black" Font-Bold="false"></asp:Label></td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
          <asp:TextBox ID="txtmail" runat="server" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="please enter your email id" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="regmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="incorrect format of email id" 
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
             ValidationGroup="abuse">*</asp:RegularExpressionValidator>
        </td>
        </tr>
      <tr>
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblcomment" runat="server" Text="Comment" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtcmnt" runat="server" TextMode="MultiLine" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="reqcmnt" runat="server" 
             ControlToValidate="txtcmnt" ErrorMessage="Please report your abuse" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
          <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                validationgroup="abuse" ShowMessageBox="True" ShowSummary="False" />
      </td>
      </tr>
      </table>
 </td>
</tr>
<tr>
  <td valign="top" colspan="3" align="right" style="padding-right:5px;">
  <asp:ImageButton ID="imgsubmit1" OnClick="imgsubmit1_Click" ImageUrl="../images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="abuse"/>
  </td>
</tr>
</table>
  </asp:Panel> 
 </td></tr></table>
     <cc1:ModalPopupExtender ID="poprptabuse" runat="server" TargetControlID="lnkreptabuse" PopupControlID="pnlreportabuse"
      BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btncancel"></cc1:ModalPopupExtender>
   <asp:Panel ID="pnledit" runat="server" Width="350px" BorderColor="Gray">
    <table width="100%" border="0" style="background:url(images/panel/dialog_box_bg.png) no-repeat; width:350px; 
		  height:266px;margin:0px auto;top:100px;">
  <tr>
    <td width="60%" class="sub_menu" align="right">
    <asp:Label ID="Label12" runat="server" Text="Edit Listing" CssClass="sub_menu"></asp:Label></td>
    <td width="37%" height="38" align="right">
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="btncan" runat="server" ImageUrl="../images/panel/cencel.png" Width="21" Height="22" />
    </td>
    <td width="3%">&nbsp;</td>
  </tr>
    <tr>
    <td height="176" colspan="3" valign="top">
    <table width="100%" border="0">
    <tr>
     <td class="side_menu" style="padding-left:5px;">
     <%--&nbsp; Select the appropriate option and click Go <br /><br />--%>
         Please select an appropriate option from below to make changes
     </td>
    </tr>
  <tr><td>
   <table width="100%">
   <tr>
    <td height="30" style="padding-left:5px;">
      <asp:RadioButton ID="rbown" runat="server" ValidationGroup="user" GroupName="usertype" /></td>
    <td>I own this listing / I work here. </td></tr>
   <tr>
     <td height="30" style="padding-left:5px;">
        <asp:RadioButton ID="rbuser" runat="server" GroupName="usertype" ValidationGroup="user" /></td>
     <td>I'm a normal user.</td>
   </tr>
  </table>
  </td></tr>
    </table>
    </td>
  </tr>
  <tr>
   <td height="41" align="right" colspan="2">
    <asp:ImageButton ID="Imgedit" ImageUrl="../images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="user"
      onclick="Imgedit_Click" />
  </td>
    <td>&nbsp;</td>
  </tr>
</table>
   </asp:Panel>
   <cc1:ModalPopupExtender ID="modpopupedit" runat="server" TargetControlID="lnkedit" PopupControlID="pnledit"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="btncan"></cc1:ModalPopupExtender>

  <asp:Panel ID="pnlmaploc" runat="server" BackColor="White">
   <div id="divMap" style="width:690px; height:400px;">
  </div>
    <div id="infoPanel">
    <b>Marker status:</b>
    <div id="markerStatus"><i>Click and drag the marker.</i></div>
    <b>Current position:</b>
    <div id="info"></div>
    <b>Closest matching address:</b>
    <div id="address"></div>
    <br />
     </div>
     <table>
     <tr>
         <td width="100px"></td>
    <td width="150px">
    <asp:ImageButton ID="imgsubmit" runat="server" 
            ImageUrl="../images/submit_dialog.png"/>
    </td>
    <td>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="../images/panel/cancel.png" 
            onclick="imgcancel_Click" />
    </td>
    </tr>
     </table>
  </asp:Panel>
  <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="lnklocatemap" PopupControlID="pnlmaploc"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="btncan"></cc1:ModalPopupExtender>
  <asp:Panel ID="pnlmapsubmit" runat="server" BackColor="White">
  <table width="250px">
  <tr><td></td></tr>
  <tr><td></td></tr>
  <tr><td align="left"><asp:RadioButton ID="rbtnexact" runat="server" GroupName="radiomap" Text="Exact Location" Checked="true"/></td></tr>
  <tr><td align="left"><asp:RadioButton ID="RadioButton1" runat="server" GroupName="radiomap" Text="Approx By 100 Metres"/></td></tr>
  <tr><td align="left"><asp:RadioButton ID="RadioButton2" runat="server" GroupName="radiomap" Text="Approx By 200 Metres" /></td></tr>
  <tr><td align="left"><asp:RadioButton ID="RadioButton3" runat="server" GroupName="radiomap" Text="I'm Not sure about it" /></td></tr>
  <tr><td></td></tr>
  <tr><td><asp:Button ID="btnmapsubmit" runat="server" Text="submit" 
          onclick="btnmapsubmit_Click1"/></td></tr>
          <tr><td></td></tr>
          <tr><td></td></tr>
  </table>
  </asp:Panel>
  <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" TargetControlID="imgsubmit" PopupControlID="pnlmapsubmit"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="btncan"></cc1:ModalPopupExtender>
       <%--<asp:Panel ID="pnlconfirm" runat="server" BackColor="White">
      <table>
      <tr>
      <td></td>
      </tr>
      <tr><td>Are you Sure , About This Location ?</td></tr>
      <tr><td></td></tr>
      <tr>
      <td align="center"><asp:Button ID="btnyes" runat="server" Text="Yes" />&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnno" runat="server" Text="No" /></td>
      <asp:Button ID="hide" runat="server" Visible="false" />
      </tr>
      </table>
      </asp:Panel>
      <cc1:ModalPopupExtender ID="confirmpopup" runat="server" TargetControlID="btnmapsubmit" PopupControlID="pnlconfirm"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="btnyes" CancelControlID="btnno"></cc1:ModalPopupExtender>--%>