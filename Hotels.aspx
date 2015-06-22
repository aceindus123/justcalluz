<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Hotels.aspx.cs" Inherits="Hotels" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="SPLinks" TagPrefix="SPAds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Hotels page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            height: 20px;
        }
        .color
        {
            color:Chocolate;
            }
        .color:hover
        {
            color:#006699;
            
            }
    </style>
    

<script type="text/javascript" language="javascript">
        function OnContactSelected(source, eventArgs) {

            var hdnValueID = "<%= hdnValue.ClientID %>";

            document.getElementById(hdnValueID).value = eventArgs.get_value();
            __doPostBack(hdnValueID, "");
        } 
    </script>

      
<%--<link rel="stylesheet" href="css/jquery-ui.css" />
        <script src="js/jquery-1.9.1.js" type="text/javascript"></script>
        <script src="js/jquery-ui.js" type="text/javascript"> </script>
        <script language="javascript" type="text/javascript">
            $(function () {
                $('#<%=txtSearchFor.ClientID%>').autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "Hotels.aspx/GetCompanyName",
                            data: "{ 'pre':'" + request.term + "'}",
                            dataType: "json",
                            type: "POST",
                            contentType: "application/json; charset=utf-8",
                            success: function (data) {
                                response($.map(data.d, function (item) {
                                    return { value: item }
                                }))
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                alert(textStatus);
                            }
                        });
                    }
                });
            });
</script>--%>

</head>
<body>
    <form id="form1" runat="server">
   <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
    <div class="layout">
    <div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="uye" runat="server" />
</div>
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%">
<table width="100%" border="0">
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="center">
    <table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="91%" ><span class="bottam">Search Hotels by Type or Name.</span></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td width="100%" height="28" valign="top" ><table width="100%" border="0">
          <tr>
            <td width="40%" height="37" align="right"><span class="mid_menu">city </span></td>
            <td width="3%" align="center"><strong>:</strong></td>
            <td width="57%" height="37" align="left"><%--<span class="row">--%>
            <asp:Panel ID="pnltxtcity" runat="server" Width="215px" BackColor="ControlLight" Height="33px">
            <fieldset>
            <table>
            <tr>
            <td>
            <asp:TextBox ID="txtSelectCity" runat="server" Width="190px" 
                    Height="20px" BackColor="White" ReadOnly="true"></asp:TextBox>
            </td>
            <td>
            <asp:ImageButton ID="imgBtnSelectCity" runat="server" 
                   ImageUrl="images/downarrow5.jpg" 
                style="width: 20px" Width="20px"/>
            </td>
            </tr>
            </table>
                
             <%--</span>--%>
                </fieldset>
            </asp:Panel>
             </td>
          </tr>
          <tr>
            <td height="36" align="right"><span class="mid_menu">What</span><span class="mid_menu">?</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="36" align="left" ><span class="row">
                <asp:TextBox ID="txtSearchFor" runat="server" Width="220px" ></asp:TextBox>
          
                <%--<asp:TextBox ID="txtSearchFor" runat="server" Width="340px" CssClass="textboxAuto" class="ui-widget" style="text-align:left"></asp:TextBox>--%>
                <asp:RequiredFieldValidator ID="rfvSearchFor" runat="server" 
        ErrorMessage="Please enter a keyword to search" 
        ControlToValidate="txtSearchFor" ValidationGroup="SearchGroup_hotel">*</asp:RequiredFieldValidator>
            </span>
             <asp:hiddenfield id="hdnValue" onvaluechanged="hdnValue_ValueChanged" runat="server"/></td>
          </tr>
          <cc1:AutoCompleteExtender ID="autoselectcompany" runat="server" TargetControlID="txtSearchFor" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetHotels" ShowOnlyCurrentWordInCompletionListItem="true"
           OnClientItemSelected="OnContactSelected">
    </cc1:AutoCompleteExtender>
      <tr>
            <td height="37" align="right"><span class="mid_menu">Where in <asp:Label ID="Label10" runat="server"></asp:Label><span class="mid_menu">?</span></td>
             <td align="center"><strong>:</strong></td>
            <td height="37" align="left" ><span class="row">
                <asp:TextBox ID="txtWhereIn" runat="server" Width="220px" ForeColor="black" ></asp:TextBox>
            </span></td>
          </tr>
          <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtWhereIn" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetAreas" ShowOnlyCurrentWordInCompletionListItem="true">
        </cc1:AutoCompleteExtender>
          <tr>
            <td height="25">&nbsp;</td>
           <td align="center"></td>
            <td align="left" height="30">
             <asp:ImageButton ID="BtnSearch" runat="server" src="images/go.png" OnClick="BtnSearch_Click" ValidationGroup="SearchGroup_hotel"/></td>
              <asp:ValidationSummary ID="ValSumSearch" runat="server" ShowMessageBox="True" 
            ShowSummary="False" ValidationGroup="SearchGroup_hotel" />  
          </tr>
          <tr>
            <td  colspan="3"  
                  style="background-image:url(images/hr.gif);background-repeat:repeat-x" 
                  class="style1"></td>
          </tr>
          <tr>
            <td colspan="3"  height="30" style="padding-left:30px;" class="mid_menu">Popular Hotels in 
                <asp:Label ID="lblpcity" runat="server"></asp:Label></td>
          </tr>
          <tr>
            <td colspan="3"><hr/></td>
          </tr>
          <tr>
            <td colspan="3" valign="top"><table width="100%" border="0">
              <tr>
                <td width="43%" valign="top" class="bottam_menu"  style="padding-left:30px; line-height:2" colspan="2">
                	<asp:DataList ID="dlpophotels" runat="server" RepeatColumns="2">
                	<ItemTemplate>
                	    <asp:Button ID="lnkhotel" runat="server" Text='<%#Eval("company_name")%>' BorderStyle="None" BackColor="White" 
                	          CommandArgument='<%#Eval("company_name")+","+Eval("city")%>' OnCommand="lnktocompany" CssClass="pointer" />
                	  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                	  <%--  <a id="lnkhotel" runat="server" onserverclick="lnktocompany">
                	      
                	    </a>--%>
                	</ItemTemplate>
                	</asp:DataList>
                </td>
              </tr>
            <%--</tTaj Banjara</a></td>
              </tr>--%>
            </table>
    <asp:panel ID="Panel1" runat="server" BorderWidth="1" BorderColor="Black"
        style=" position: absolute; width: 700px; height:330px;  left: 58px; top: 310px;" 
        BackColor="White">
        
        <table border="0" style="border-color:#003366; margin-left:15px;" cellpadding="0" cellspacing="0" width="98%" align="left">
    <tr>
    <td valign="top">
    
        <asp:Panel ID="pnlAtoZ" runat="server" >
        <table border="0" cellpadding="0" cellspacing="0" style="width: 685px">
        
         <tr>       
        <td align="right" width="100%" colspan="2" >
            <asp:Button ID="Button3" runat="server" Text="X" Font-Size="Medium"  
                BackColor="White" BorderStyle="None"
                Width="20px"  ForeColor="Red" Font-Bold="true" />
         </td>
        </tr>
        <tr>
            <td height="10" colspan="2" style="padding-left:5px;">
                <asp:Label ID="Label1" runat="server" Text="All Cities: 410" ForeColor="Orange" Font-Bold="true" Font-Size="12px" Font-Names="Arial, Helvetica, sans-serif"></asp:Label>
            </td>
        </tr>
        <tr><td></td></tr>
        <tr>
            <td align="left" style="padding-left:5px;">
                <asp:Label ID="Label2" runat="server" Text="Popular Cities" ForeColor="Orange" Font-Bold="true" Font-Size="12px" Font-Names="Arial, Helvetica, sans-serif"></asp:Label>
            </td>
            <td style="padding-left:20px;">
                <asp:LinkButton ID="A" runat="server" Text="A" Font-Underline="true" Font-Overline="false" CommandArgument="A" OnCommand="get_city" 
                    CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px"/>&nbsp;&nbsp;
                      
                <asp:LinkButton ID="B" runat="server" Text="B" Font-Overline="false"  Font-Underline="true" CommandArgument="B" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="C" runat="server" Text="C" Font-Overline="false" Font-Underline="true" CommandArgument="C" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                          
                 <asp:LinkButton ID="D" runat="server" Text="D" Font-Overline="false"  Font-Underline="true" CommandArgument="D" OnCommand="get_city"
                    CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                    
                <asp:LinkButton ID="E" runat="server" Text="E" Font-Overline="false"  Font-Underline="true" CommandArgument="E" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
            
                <asp:LinkButton ID="F" runat="server" Text="F" Font-Overline="false"  Font-Underline="true" CommandArgument="F" OnCommand="get_city"
                   CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="G" runat="server" Text="G" Font-Overline="false"  Font-Underline="true" CommandArgument="G" OnCommand="get_city"
                    CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                        
                <asp:LinkButton ID="H" runat="server" Text="H" Font-Overline="false"  Font-Underline="true" CommandArgument="H" OnCommand="get_city"
                    CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
        
                <asp:LinkButton ID="I" runat="server" Text="I" Font-Overline="false"  Font-Underline="true" CommandArgument="I" OnCommand="get_city"
                    CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                   
                <asp:LinkButton ID="J" runat="server" Text="J" Font-Overline="false" Font-Underline="true" CommandArgument="J" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
          
                <asp:LinkButton ID="K" runat="server" Text="K" Font-Overline="false" Font-Underline="true" CommandArgument="K" OnCommand="get_city"
                  CssClass="color"  ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="L" runat="server" Text="L" Font-Overline="false"  Font-Underline="true" CommandArgument="L" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                      
                <asp:LinkButton ID="M" runat="server" Text="M" Font-Overline="false"  Font-Underline="true" CommandArgument="M" OnCommand="get_city"
                  CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                        
                <asp:LinkButton ID="N" runat="server" Text="N" Font-Overline="false"  Font-Underline="true" CommandArgument="N" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                      
                <asp:LinkButton ID="O" runat="server" Text="O" Font-Overline="false"  Font-Underline="true" CommandArgument="O" OnCommand="get_city"
                  CssClass="color"   Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                          
                <asp:LinkButton ID="P" runat="server" Text="P" Font-Overline="false"  Font-Underline="true" CommandArgument="P" OnCommand="get_city"
                   CssClass="color" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                           
                <asp:LinkButton ID="Q" runat="server" Text="Q" Font-Overline="false"  Font-Underline="true" CommandArgument="Q" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                          
                <asp:LinkButton ID="R" runat="server" Text="R" Font-Overline="false"  Font-Underline="true" CommandArgument="R" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                        
                <asp:LinkButton ID="S" runat="server" Text="S" Font-Overline="false"  Font-Underline="true" CommandArgument="S" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="T" runat="server" Text="T" Font-Overline="false"  Font-Underline="true" CommandArgument="T" OnCommand="get_city"
                  CssClass="color"   Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                          
                <asp:LinkButton ID="U" runat="server" Text="U" Font-Overline="false"  Font-Underline="true" CommandArgument="U" OnCommand="get_city"
                  CssClass="color"   Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="V" runat="server"  Text="V"  Font-Bold="true"  Font-Underline="true" CommandArgument="V" OnCommand="get_city"
                   CssClass="color" Font-Overline="false"  Font-Names="Arial, Helvetica, sans-serif" Font-Size="12px" />&nbsp;&nbsp;
                       
                <asp:LinkButton ID="W" runat="server" Text="W" Font-Overline="false"  Font-Underline="true" CommandArgument="W" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;

                   <asp:LinkButton ID="X" runat="server" Text="X" Font-Overline="false"  Font-Underline="true" CommandArgument="X" OnCommand="get_city"
                   CssClass="color"  Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;
                          
                <asp:LinkButton ID="Y" runat="server" Text="Y" Font-Overline="false"  Font-Underline="true" CommandArgument="Y" OnCommand="get_city"
                  CssClass="color"   Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />&nbsp;&nbsp;

                  <asp:LinkButton ID="Z" runat="server" Text="Z" Font-Overline="false"  Font-Underline="true" CommandArgument="Z" OnCommand="get_city"
                  CssClass="color"   Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" />
            </td>
      </tr>
      <tr><td  height="10" valign="top"></td></tr>
        </table>
        
        
        
        </asp:Panel>
        
      
        
        <table width="" border="0" cellpadding="0" cellspacing="0"> 
        <tr>
        <td valign="top">
            <asp:Panel ID="pnlcities" runat="server">
            <table width="110px" border="0" cellpadding="0" cellspacing="0" style="height: 200px; border-right: 2px dashed; border-color:Black;">
                <tr>
                    <td valign="top">
                        <asp:DataList ID="dlpopcities"   RepeatDirection="vertical" RepeatColumns="2" CellPadding="0"  runat="server" 
                            Height="200px" Width="50px"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="panel3">
                        <table border="0" style="vertical-align:top">
                            <tr>
                                <td valign="top" style="padding-right:30px;">
                                    
                                    <asp:Button ID="LinkButton1" runat="server" CommandArgument='<%#Eval("popcities")%>' Font-Underline="false" BorderStyle="None" BackColor="White"
                                     Text='<%# Eval("popcities") %>' CommandName="select" OnCommand="selectcity" Font-Size="Small" CssClass="pointer" />
                                       
                                </td>
                            </tr>
                        </table>
                       </div> 
                   </ItemTemplate>
                    </asp:DataList>
                    </td>
                </tr>
            </table>        
            </asp:Panel>
        </td>
        <td style="width:80%; padding-left:30px;" valign="top">
        <asp:Panel ID="pnl_othcities" runat="server" Width="600px">
        
        <asp:DataList ID="dl_bindcities" runat="server" RepeatColumns="3" Height="0px">
        <ItemTemplate>
        <asp:Button ID="lnkothcities" runat="server" Text='<%#Eval("city_name")%>' BorderStyle="None" BackColor="White" CssClass="pointer" 
            CommandArgument='<%#Eval("city_name")%>' OnCommand="selectcity" Font-Size="Small" Font-Underline="false" />&nbsp;&nbsp;&nbsp;
        </ItemTemplate>
        </asp:DataList>
        
        </asp:Panel>
        </td>
        
       </tr>
       
       </table>
        
         </td>
        </tr>
        
    </table>
        </asp:panel>
        <cc1:ModalPopupExtender ID="pop_search" runat="server" TargetControlID="imgBtnSelectCity" PopupControlID="Panel1"
      BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="Button3">
    </cc1:ModalPopupExtender>
            </td>
            </tr>
          <tr>
            <td height="25">&nbsp;</td>
            <td>&nbsp;</td>
            <td align="left">&nbsp;</td>
          </tr>
      -</table></td>
  </tr>
</table>
</td>
  </tr>
</table>
 </div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
      <SPAds:SPLinks ID="spads" runat="server" />
      <%--<img src="images/hotel.jpg" alt="sponserAds" width="175" height="500" /><br />--%>
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
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
