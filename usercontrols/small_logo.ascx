<%@ Control Language="C#" AutoEventWireup="true" CodeFile="small_logo.ascx.cs" Inherits="small_logo" %>
<%--<a href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server"><img alt="JustcalluzLogo" src="../images/logo_small.jpg" width="192" height="62" /></a>--%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%--<script type="text/javascript">
    function SetScrollPosition() {
        var div = document.getElementById('divMessages');
        div.scrollTop = 100000000000;
    }

    function SetToEnd(txtMessage) {
        if (txtMessage.createTextRange) {
            var fieldRange = txtMessage.createTextRange();
            fieldRange.moveStart('character', txtMessage.value.length);
            fieldRange.collapse();
            fieldRange.select();
        }
    }

    function ReplaceChars() {
        var txt = document.getElementById('txtMessage').value;
        var out = "<"; // replace this
        var add = ""; // with this
        var temp = "" + txt; // temporary holder

        while (temp.indexOf(out) > -1) {
            pos = temp.indexOf(out);
            temp = "" + (temp.substring(0, pos) + add +
                temp.substring((pos + out.length), temp.length));
        }

        document.getElementById('txtMessage').value = temp;
    }

    function LogOutUser(result, context) {
        // don't do anything here
    }

    function LogMeOut() {
        LogOutUserCallBack();
    }
    </script>--%>
    <%--<asp:ScriptManager Id="ScriptManager1" runat="server" EnablePartialRendering="true" />--%>
<table border="0" width="100%" cellpadding="0" cellspacing="0">
<tr>
<%--<td width="20px">&nbsp;</td>--%>
<td class="header" align="center" colspan="3" >
<a id="A1" href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server"><img alt="JustcalluzLogo" src="images/logo1.jpg" style="border:none;"></a>
</td>

<%--<td width="250" align="right">&nbsp;<asp:ImageButton ID="imgchat" runat="server" 
        ImageUrl="~/images/Chat-icon.png" onclick="imgchat_Click" /></td>--%>
<!--end of header-->

</tr>

<tr>
<%--
	<td style="width:40%;padding-right:0%;" align="right" ></td>--%>
				<td align="left" class="header">
                <%--<table align="left" width="250"><tr>
                <td align="right" style="width:95px;"><span id="sm6_Label2">Select Country &nbsp;<strong>:</strong>&nbsp;</span></td>
<td  align="center">
   <a id="sm6_HyperLink1" title="India" href="http://india.justcalluz.com" target="_parent"><img title="India" src="india/images/IndiaFlag_icon.jpg" alt="" style="border-width:0px;" /></a>
</td>
         
          <td  align="center">
         <a id="sm6_HyperLink2" title="USA" href="http://usa.justcalluz.com" target="_parent"><img title="USA" src="india/images/usa_icon.jpg" alt="" style="border-width:0px;" /></a>
          </td>
          
          <td align="center">
           <a id="sm6_HyperLink3" title="UK" href="http://UK.justcalluz.com" target="_parent"><img title="UK" src="india/images/uk_icon.jpg" alt="" style="border-width:0px;" /></a>
          </td>
          
          <td  align="center">
         
          <a id="sm6_HyperLink4" title="Australia" href="http://aus.justcalluz.com" target="_parent"><img title="Australia" src="india/images/australia_icon.jpg" alt="" style="border-width:0px;" /></a>
          </td>
         
</tr></table>--%></td>
<td align="right" style="padding-top:2px; ">Follow us :</td>

<td align="right" valign="bottom" style="width:65px; padding-right:5px;" ><a href="https://twitter.com/justcalluz" target="_blank"><img  style="vertical-align:middle; " alt="twitterIcon" src="images/Twitter-icon.png" width="24" height="20" /></a>
<a href="http://www.facebook.com/Justcalluz" target="_blank"><img style="vertical-align:middle; " alt="facebookIcon" src="images/facebook.png" width="24" height="20" /></a>
</td>
			</tr>
</table>
<%--<asp:Panel ID="pnlchat" runat="server" DefaultButton="btnSend">
<div>
        
        <asp:Label Id="lblRoomName" Font-Size="18px" runat="server" /><br /><br />
        <asp:Label Id="lblRoomId" Visible="false" runat="server" />
        <asp:UpdatePanel Id="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlId="Timer1" />
            </Triggers>
            <ContentTemplate>
                <asp:Timer Id="Timer1" Interval="7000" OnTick="Timer1_OnTick" runat="server" />
                <table border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="width: 500px;">
                            <div id="divMessages" style="background-color: White; border-color:Black;border-width:1px;border-style:solid;height:300px;width:592px;overflow-y:scroll; font-size: 11px; padding: 4px 4px 4px 4px;" onresize="SetScrollPosition()">
                                <asp:Literal Id="litMessages" runat="server" />
                            </div>
                        </td>
                        <%--<td>&nbsp;</td>--%>
                      <%-- <td>
                            <div id="divUsers" style="background-color: White; border-color:Black;border-width:1px;border-style:solid;height:300px;width:150px;overflow-y:scroll; font-size: 11px;  padding: 4px 4px 4px 4px;">
                               <asp:Literal Id="litUsers" runat="server" />
                            </div>
                        </td>--%>
                    <%--</tr>
                    <tr>
                        <td>
                            <asp:TextBox Id="txtMessage" onkeyup="ReplaceChars()" onfocus="SetToEnd(this)" runat="server" MaxLength="100" Width="500px" />
                            <asp:Button Id="btnSend" runat="server" Text="Send" OnClientClick="SetScrollPosition()" OnClick="BtnSend_Click" />
                            &nbsp;
                            <asp:Button ID="his" runat="server" Text="Conversation History" 
                                onclick="his_Click" />--%>
                            <%--<b>Color:</b> <asp:DropDownList Id="ddlColor" runat="server">
                                <asp:ListItem Value="Black" Selected="true">Black</asp:ListItem>
                                <asp:ListItem Value="Blue">Blue</asp:ListItem>
                                <asp:ListItem Value="Navy">Navy</asp:ListItem>
                                <asp:ListItem Value="Red">Red</asp:ListItem>
                                <asp:ListItem Value="Orange">Orange</asp:ListItem>
                                <asp:ListItem Value="#666666">Gray</asp:ListItem>
                                <asp:ListItem Value="Green">Green</asp:ListItem>
                                <asp:ListItem Value="#FF00FF">Pink</asp:ListItem>
                            </asp:DropDownList>--%>
                           <%-- &nbsp;
                            <asp:Button Id="btnLogOut" Text="Log Out" runat="server" OnClick="BtnLogOut_Click" />
                        </td>
                    </tr>
                </table>                
            </ContentTemplate>
        </asp:UpdatePanel> 
    </div>
</asp:Panel>
<cc1:ModalPopupExtender ID="chatmodal" runat="server" TargetControlID="imgchat" PopupControlID="pnlchat"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="btnLogOut"></cc1:ModalPopupExtender>--%>
      <div class="clr"></div>