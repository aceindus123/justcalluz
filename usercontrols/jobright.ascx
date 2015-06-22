<%@ Control Language="C#" AutoEventWireup="true" CodeFile="jobright.ascx.cs" Inherits="usercontrols_jobright" %>

<table width="255" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:5px;">
<tr><td class="refinedsearch"><b>Sponsor Ads</b></td></tr></table>

<table width="255" border="1" bordercolor="#003366" cellpadding="0" cellspacing="0" style="margin-top:18px;">
<tr>
<td class="style1">
<table width="255" border="0" bordercolor="#003366" cellpadding="0" cellspacing="0">
<tr>
  <td><object id="FlashID2" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="210" height="190" style="margin-left:20px">
    <param name="movie" value="images/discountflash.swf" />
    <param name="quality" value="high" />
    <param name="wmode" value="opaque" />
    <param name="swfversion" value="6.0.65.0" />
    <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
    <param name="expressinstall" value="Scripts/expressInstall.swf" />
    <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
    <!--[if !IE]>-->
    <object type="application/x-shockwave-flash" data="images/discountflash.swf" width="210" height="190">
      <!--<![endif]-->
      <param name="quality" value="high" />
      <param name="wmode" value="opaque" />
      <param name="swfversion" value="6.0.65.0" />
      <param name="expressinstall" value="Scripts/expressInstall.swf" />
      <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
      <div>
        <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
        <embed src="flash.swf" quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="210" height="190"></embed>


      </div>
      <!--[if !IE]>-->
    </object>
    <!--<![endif]-->
  </object></td>
  </tr>
  </table>
  <div class="sponseredlink">
     <table border="0" style="margin-left:6px; width: 229px; margin-right: 0px;">
    <tr>
         <td>
                <asp:DataList ID="dlsponsoredlinks"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="226px">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0" width="220px">
                        <tr>
                            <td valign="top" height="15px">
                                <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Text='<%# Eval("heading") %>' NavigateUrl='<%# Eval("website") %>'>                            
                             </asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:justify">
                                <%#DataBinder.Eval(Container.DataItem, "heading1")%>
                            </td>
                        </tr>
                        <tr>
                            <td height="5px"></td>
                        </tr>
                    </table>
                    </div>
               </ItemTemplate>
                </asp:DataList>
         </td>
    </tr>
  </table>
  </div>
</td>
</tr>
</table>
