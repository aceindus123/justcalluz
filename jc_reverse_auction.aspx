<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jc_reverse_auction.aspx.cs" Inherits="jc_reverse_auction"  EnableSessionState="True"%>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ccl" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc2" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: JC Reverse Auction</title>--%>
<title>JC Reverse Auction | JustCalluz</title>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
 <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>  
<script  type="text/javascript"  language="javascript">
         function  OnCategorySelected(source, eventArgs) {

            var  hdnValueID = "<%= hdnValue.ClientID %>";

            document.getElementById(hdnValueID).value = eventArgs.get_value();
            __doPostBack(hdnValueID, "");
        }

        $(function () {
            $(".tb1").autocomplete({
           
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchAreasList",
                        data: "{ 'area': '" + request.term + "' ,"+
                          "'City': '" + $('#txtSelectCity').val() + "'}",
//                        City: "{ 'City': '" + $('#txtSelectCity').val() + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.areaname
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 1
            
            });
            
        }); 

        $(function () {
            $(".searchtd").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchAreasList1",
                        data: "{ 'sear': '" + request.term + "' ," +
                          "'City': '" + $('#txtSelectCity').val() + "'}",
                        //                        City: "{ 'City': '" + $('#txtSelectCity').val() + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.searchn
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 1
            });
        });
        $(function () {
            $(".tb").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchCitiesList",
                        data: "{ 'city': '" + request.term + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.Cityname
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 1
            });
        }); 

       
</script>
<script type="text/javascript">
    function Alphabets(nkey) {
        var keyval
        if (navigator.appName == "Microsoft Internet Explorer") {
            keyval = window.event.keyCode;
        }
        else if (navigator.appName == 'Netscape') {
            nkeycode = nkey.which;
            keyval = nkeycode;
        }
        //For A-Z
        if (keyval >= 65 && keyval <= 90) {
            return true;
        }
        //For a-z
        else if (keyval >= 97 && keyval <= 122) {
            return true;
        }
        //For Backspace
        else if (keyval == 8) {
            return true;
        }
        //For General
        else if (keyval == 0) {
            return true;
        }
        //For Space
        else if (keyval == 32) {
            return true;
        }
        else {
            return false;
        }
    } // End of the function


    </script>

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
<body >
 <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
     </asp:ScriptManager>
<div class="layout">
<div class="signin">
 <aa1:signin ID="suy" runat="server" />
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<div class="contentbox_top" id="dvcontentTop" runat="server" visible="false">
  <strong>Selected Categories</strong></div>
<div class="contentbox_mid" id="dvcontentmid" runat="server" visible="false">
  <asp:Panel ID="pnlchkcate" runat="server">
     <asp:DataList ID="Dlcategory1" runat="server" RepeatColumns="1" Width="100%"
              OnItemDataBound="Dlcategory1_ItemDataBound">   
       <ItemTemplate>
          <table>
           <tr>
            <td>
              <asp:CheckBox ID="ChkCategory1" Text='<%#Eval("SubCategory")%>' runat="server" AutoPostBack="true" OnCheckedChanged="ChkCategory1_CheckedChanged"/>
            </td>
           </tr>
          </table>
       </ItemTemplate>
     </asp:DataList>
  </asp:Panel>
</div>
<div class="contentbox_bottam" id="dvmidbottam" runat="server" visible="false"></div>
<div class="contentbox_top"><strong> Reverse Auction </strong></div>
<div class="contentbox_mid" style="padding-left:15px;">
<ul>
<li style="line-height:20px; color:#003366;">Submit this form and get Best Deals</li>
<li style="line-height:20px; color:#003366;">Just Calluz Instantly forwards your details to relevant businesses</li>
<li style="line-height:20px; color:#003366;">They all compete to give you the lowest price</li>
<li style="line-height:20px; color:#003366;">They may call you or you can call them</li>
<li style="line-height:20px; color:#003366;">So, Go ahead and Negotiate</li>
</ul>
</div>
<div class="contentbox_bottam"></div>
</div>
<div class="content_innermid" style="width:78%; margin-left:10px;">
  <table width="100%" border="0">
    <tr>
      <td height="20" align="left" style="padding-left:3px;"><h1> JC Reverse Auction</h1> </td>
    </tr>
    <tr id="trCaption" runat="server">
      <td style="padding-left:3px; padding-bottom:10px;"><h2>Let FOUR vendors compete for your business and get the best deal!!!</h2> </td>
   </tr>
    <tr id="trCity" runat="server">
      <td class="jc_box">
       <table width="60%" border="0">
        <tr>
          <td><b><font style="font-size:24px; color:#F00">Step 1</font>&nbsp;&nbsp;Select city, select area, enter your requirement &amp; click &quot;GO&quot; </b></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td height="47">
          <table width="100%" border="0">
            <tr>
              <td width="21%"><strong>City</strong></td>
              <td width="4%">&nbsp;</td>
              <td width="75%"><strong>Where in &nbsp;<asp:Label ID="lblarea" runat="server" 
                         Width="130px" Height="20px" Text="Hyderabad?"></asp:Label></strong></td>
            </tr>
            <tr>
            <td>
               <asp:Panel ID="pnlCity" runat="server" BorderWidth="1px" BorderColor="#336699" 
                         Height="30px" Width="164px">
                     <table style="height: 30px;" width="100%">
                     <tr>
                      <td style="width:19%;">
                        <asp:TextBox ID="txtSelectCity" runat="server" style="padding:5px;" BorderColor="White"  AutoPostBack="true"  
                           BorderStyle="None" Height="15px" Width="120px" OnTextChanged="txtSelectCity_TextChanged" CssClass="tb" ></asp:TextBox>
                          <%--<ccl:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtSelectCity" 
                              MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" 
                              ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true"></ccl:AutoCompleteExtender>--%>   
                     </td>
                      <td style="width:2%;"> 
                        <asp:ImageButton ID="imgBtnSelectCity" AlternateText="btnSelectCity" runat="server" 
                             ImageUrl="images/arrow-down.png" style="width: 30px;height:31px;" />
                      </td>
                     </tr>
                    </table>
                  </asp:Panel>
              </td>
              <td>&nbsp;</td>
              <td style="color:#808080;">
                  <asp:TextBox ID="txtWhereIn" style="padding:5px; height:18px; width:190px;" runat="server"  CssClass="tb1"
                          ></asp:TextBox>
                  <%--<ccl:AutoCompleteExtender ID="autoWhereIn" runat="server" TargetControlID="txtWhereIn"
                         MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" 
                         ServiceMethod="GetAreas" ShowOnlyCurrentWordInCompletionListItem="true"></ccl:AutoCompleteExtender>--%> 
                  <ccl:TextBoxWatermarkExtender ID="txtwherewater" runat="server" TargetControlID="txtWhereIn" 
                        WatermarkCssClass="water1" WatermarkText="eg.kukatpally"></ccl:TextBoxWatermarkExtender>
              </td>
            </tr>
          </table>
          </td>
        </tr>
        <tr>
          <td style="padding-left:1px;"><strong>What?</strong></td>
        </tr>
        <tr>
          <td valign="bottom" style="padding-left:1px; color:#808080;">
              <asp:HiddenField ID="hdnValue" runat="server" 
                  onvaluechanged="hdnValue_ValueChanged" />
            <asp:TextBox ID="txtSearchFor" style="padding:5px; height:18px; width:380px;"  CssClass="searchtd" runat="server"></asp:TextBox>
            <ccl:TextBoxWatermarkExtender ID="txtsearchwater" runat="server" TargetControlID="txtSearchFor" 
                           WatermarkText="e.g Furniture Dealers" WatermarkCssClass="water1"></ccl:TextBoxWatermarkExtender>
            <asp:RequiredFieldValidator ID="rfvSearchFor" runat="server" 
                       ErrorMessage="Please enter a keyword to search" 
                       ControlToValidate="txtSearchFor" ValidationGroup="jc_reverse_auction">*</asp:RequiredFieldValidator>
            <div style="float:right"><asp:ImageButton ID="imgBtnGoSearch" AlternateText="btnGo" ImageUrl="images/go.jpg" 
                           width="32" height="32" runat="server" OnClick="imgBtnGoSearch_Click" ValidationGroup="jc_reverse_auction" /></div>
             <asp:ValidationSummary ID="ValSumSearch" runat="server" ShowMessageBox="True" 
                           ShowSummary="False" ValidationGroup="jc_reverse_auction" />  
                <%--<ccl:AutoCompleteExtender ID="autosearchfor" runat="server" TargetControlID="txtSearchFor" 
                           MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" 
                           ServiceMethod="GetCategories" ShowOnlyCurrentWordInCompletionListItem="true"  >
                </ccl:AutoCompleteExtender>--%>  
          </td>
        </tr>
      </table>
       <asp:panel ID="Panel1" runat="server" BorderWidth="1" BorderColor="Black"
        style=" position: absolute; width: 700px; height: 312px;  left: 58px; top: 310px;" 
        BackColor="White">
        
        <table border="0" cellpadding="0" cellspacing="0" width="765" align="left">
    <tr>
    <td valign="top">
    
        <asp:Panel ID="pnlAtoZ" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 700px">
        <tr>       
        <td align="right" width="980" colspan="2">
            <asp:Button ID="Button3" runat="server" Text="X" Font-Size="Medium"  
                BackColor="White" BorderStyle="None"
                Width="33px"  ForeColor="Red" Font-Bold="true" />
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
            <td>
                <asp:LinkButton ID="A" runat="server" Text="A" Font-Underline="true" Font-Overline="false" CommandArgument="A" OnCommand="get_city" 
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" />
                            
                <asp:LinkButton ID="B" runat="server" Text="B" Font-Overline="false"  Font-Underline="true" CommandArgument="B" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                         
                <asp:LinkButton ID="C" runat="server" Text="C" Font-Overline="false"  Font-Underline="true" CommandArgument="C" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                            
                 <asp:LinkButton ID="D" runat="server" Text="D" Font-Overline="false"  Font-Underline="true" CommandArgument="D" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                          
                <asp:LinkButton ID="E" runat="server" Text="E" Font-Overline="false"  Font-Underline="true" CommandArgument="E" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                           
                <asp:LinkButton ID="F" runat="server" Text="F" Font-Overline="false"  Font-Underline="true" CommandArgument="F" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                         
                <asp:LinkButton ID="G" runat="server" Text="G" Font-Overline="false"  Font-Underline="true" CommandArgument="G" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                           
                <asp:LinkButton ID="H" runat="server" Text="H" Font-Overline="false"  Font-Underline="true" CommandArgument="H" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                           
                <asp:LinkButton ID="I" runat="server" Text="I" Font-Overline="false"  Font-Underline="true" CommandArgument="I" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                        
                <asp:LinkButton ID="J" runat="server" Text="J" Font-Overline="false"  Font-Underline="true" CommandArgument="J" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                          
                <asp:LinkButton ID="K" runat="server" Text="K" Font-Overline="false"  Font-Underline="true" CommandArgument="K" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true" Font-Size="12px" ></asp:LinkButton>
                           
                <asp:LinkButton ID="L" runat="server" Text="L" Font-Overline="false"  Font-Underline="true" CommandArgument="L" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                         
                <asp:LinkButton ID="M" runat="server" Text="M" Font-Overline="false"  Font-Underline="true" CommandArgument="M" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                          
                <asp:LinkButton ID="N" runat="server" Text="N" Font-Overline="false"  Font-Underline="true" CommandArgument="N" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                          
                <asp:LinkButton ID="O" runat="server" Text="O" Font-Overline="false"  Font-Underline="true" CommandArgument="O" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                         
                <asp:LinkButton ID="P" runat="server" Text="P" Font-Overline="false"  Font-Underline="true" CommandArgument="P" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                        
                <asp:LinkButton ID="Q" runat="server" Text="Q" Font-Overline="false"  Font-Underline="true" CommandArgument="Q" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                          
                <asp:LinkButton ID="R" runat="server" Text="R" Font-Overline="false"  Font-Underline="true" CommandArgument="R" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                     
                <asp:LinkButton ID="S" runat="server" Text="S" Font-Overline="false"  Font-Underline="true" CommandArgument="S" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px"></asp:LinkButton>
                      
                <asp:LinkButton ID="T" runat="server" Text="T" Font-Overline="false"  Font-Underline="true" CommandArgument="T" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                       
                <asp:LinkButton ID="U" runat="server" Text="U" Font-Overline="false"  Font-Underline="true" CommandArgument="U" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
                      
                <asp:LinkButton ID="V" runat="server"  Text="V"  Font-Bold="true"  Font-Underline="true" CommandArgument="V" OnCommand="get_city"
                    Font-Overline="false" ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Size="12px"></asp:LinkButton>
                            
                <asp:LinkButton ID="W" runat="server" Text="W" Font-Overline="false"  Font-Underline="true" CommandArgument="W" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px"></asp:LinkButton>
                      
                <asp:LinkButton ID="Y" runat="server" Text="Y" Font-Overline="false"  Font-Underline="true" CommandArgument="Y" OnCommand="get_city"
                    ForeColor="Chocolate" Font-Names="Arial, Helvetica, sans-serif" Font-Bold="true"  Font-Size="12px" ></asp:LinkButton>
            </td>
      </tr>
      <tr><td  height="10"></td></tr>
        </table>
     </asp:Panel>
      <table width="" border="0" cellpadding="0" cellspacing="0"> 
        <tr>
        <td>
            <asp:Panel ID="pnlcities" runat="server">
            <table width="110px" border="0" cellpadding="0" cellspacing="0" style="height: 200px; border-right: 2px dashed; border-color:Black;">
                <tr>
                    <td>
                   <asp:DataList ID="dlpopcities" RepeatDirection="vertical" RepeatColumns="2" CellPadding="0" runat="server" 
                            Height="200px" Width="50px"> 
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                      <div class="panel3">
                        <table border="0" style="height:20px;">
                            <tr>
                                <td valign="top" style="padding-right:30px;">
                                   <asp:Button ID="LinkButton1" BackColor="White" runat="server" CommandArgument='<%#Eval("popcities")%>' Font-Underline="false"
                                     Text='<%# Eval("popcities") %>' CommandName="select" OnCommand="selectcity" Font-Size="Small" BorderStyle="None" CssClass="pointer"/>
                                     
                                    
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
        <td style="width:80%; padding-left:30px;">
        <asp:Panel ID="pnl_othcities" runat="server" Width="300px">
        <asp:DataList ID="dl_bindcities" runat="server" RepeatColumns="3" Height="200px">
        <ItemTemplate>
        <asp:Button ID="lnkothcities" BackColor="White" BorderStyle="None" runat="server" Text='<%#Eval("city_name")%>' CssClass="pointer" 
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
         <ccl:ModalPopupExtender ID="pop_search" runat="server" TargetControlID="imgBtnSelectCity" BackgroundCssClass="modalBackground" 
          CancelControlID="Button3" DropShadow="false" PopupControlID="Panel1"></ccl:ModalPopupExtender>
     </td>
    </tr>
   <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td class="jc_box_step02" id="tdCategory" runat="server" visible="false">
       <table width="95%" border="0">
        <tr>
          <td height="40" colspan="5"><b><font style="font-size:24px; color:#F00">Step 2</font>&nbsp;&nbsp;Select the keyword that matches your requirement </b></td>
        </tr>
        <tr>
          <td width="33%" valign="top" colspan="4">
            <asp:DataList ID="DlCategory" runat="server" RepeatColumns="2" CellSpacing="15" Width="100%">   
              <ItemTemplate>
                 <asp:CheckBox ID="ChkCategory" Text='<%#Eval("SubCategory")%>' runat="server" AutoPostBack="true"
                      OnCheckedChanged="ChkCategory_CheckedChanged" />
             </ItemTemplate>
            </asp:DataList>
          </td>
          <td width="2%">&nbsp;</td>
         </tr>
         </table>
         <table width="95%" border="0">
         <tr id="trMorecategories" runat="server">
          <td width="30%" align="right" valign="bottom"><strong>
            <%--<asp:LinkButton ID="lnkMoreCategory" runat="server" Text="More Keywords" OnClick="lnkMoreCategory_Click">
              </asp:LinkButton>--%>
              <a id="lnkMoreCategory" runat="server" onserverclick="lnkMoreCategory_Click">More Keywords</a>
           </strong>
          </td>
        </tr>
      </table>
    </td>
    </tr>
    <tr>
    <td style="padding-right:2px;" id="tdMoreCate" runat="server">
    <asp:Panel ID="pnlMoreCategory" runat="server" BorderStyle="Solid" BorderColor="AliceBlue" 
          BackColor="White" Visible="false" Width="100%">
    <fieldset>
     <table width="100%" border="0" style="padding:10px;">
       <tr>
        <td><asp:Image AlternateText="ReverseImge" ID="imgJc_reverse" ImageUrl="images/Jc_reverse.png" width="194px" 
                height="40px" runat="server" /><br />
        More Keywords that match your search for <strong>"<asp:Label ID="lblCategory" runat="server"></asp:Label>".</strong></td>
        <td width="40%" align="right" valign="top">
          <asp:ImageButton ID="imgBtnCancel" ImageUrl="images/cancel.png" width="24" height="24" 
                      OnClick="imgBtnCancel_Click" AlternateText="Cancel" runat="server" />
        </td>
      </tr>
      <tr>
        <td colspan="2" style="border-top:solid 2px #C90">&nbsp;</td>
      </tr>
      <tr>
       <td width="28%" colspan="2">
          <asp:DataList ID="DlMoreCategory" runat="server" RepeatColumns="3" CellSpacing="12"
              Width="100%">
            <ItemTemplate>
               <asp:CheckBox ID="ChkMoreCategory" runat="server" OnCheckedChanged="ChkMoreCategory_CheckedChanged"
                   Text='<%#Eval("SubCategory")%>' AutoPostBack="true" />
           </ItemTemplate>
          </asp:DataList>
            
      </td>
      </tr>
       <tr>
       <td>&nbsp;</td>
        <td align="right" valign="bottom">
           <%--<asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>--%>
             <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
        </td>
      </tr>
      </table>
    </fieldset>
    </asp:Panel>
    </td>
    </tr>
    <ccl:ModalPopupExtender ID="modpopupCategory" runat="server" TargetControlID="lnkMoreCategory" BackgroundCssClass="modalBackground" 
          OkControlID="imgcancel" DropShadow="false" PopupControlID="pnlMoreCategory"></ccl:ModalPopupExtender>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr valign="top">
      <td class="jc_box_step02" id="tdMessage" runat="server" visible="false">
      <table width="100%" border="0" style="height:50px;">
        <tr>
          <td height="40" colspan="5"><b><font style="font-size:24px; color:#F00">Step 3</font>&nbsp;&nbsp;Enter your name, mobile number, email id and validation code as displayed</b></td>
          </tr>
        <tr>
          <td width="14%" height="25" align="right">Name</td>
          <td width="3%" align="center"><strong>&nbsp;:&nbsp;</strong></td>
          <td width="83%" colspan="2">
            <asp:TextBox ID="txtName" runat="server" Width="60%" onkeypress="return Alphabets(event);"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td height="25" align="right">Mobile No.</td>
          <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
          <td colspan="2">
          <asp:TextBox ID="txt1" runat="server" Text="+91" ReadOnly="true" BackColor="#C1B7B7" 
                       Width="30px" BorderColor="#C1B7B7"></asp:TextBox>
             <asp:TextBox ID="txtMobileNo" runat="server" Width="53.8%" MaxLength="10"></asp:TextBox>
             <asp:RegularExpressionValidator ID="revtxtMobileNo" runat="server" 
                       ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" 
                       ValidationGroup="jc_reverse_auction" ControlToValidate="txtMobileNo"></asp:RegularExpressionValidator>
          </td>
        </tr>
        <tr>
          <td height="25" align="right">Email Id</td>
          <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
          <td colspan="2">
             <asp:TextBox ID="txtEmailId" runat="server" Width="60%"></asp:TextBox>
             <asp:RegularExpressionValidator ID="revtxtEmailId" runat="server" 
                    ErrorMessage="Please enter valid email address" ControlToValidate="txtEmailId" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="jc_reverse_auction">*</asp:RegularExpressionValidator>
          </td>
        </tr>
         <tr id="tdmsgVid" runat="server"> 
          <td height="25" colspan="5">
           <b> 
           <asp:Label ID="lblmsgVid" runat="server" ForeColor="#000000">
               Click on submit to get verification code
           </asp:Label>
           </b>
          </td>
         </tr>
        <tr id="tdVid" runat="server" visible="false">
          <td height="25" align="right">Verification Code</td>
          <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
          <td align="left" style="width:13%; height:15;">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
               <ContentTemplate> 
                <cc2:CaptchaControl ID="ccjoin" runat="server" BorderColor="#F00" BackColor="#C5C6BE" 
                     CaptchaBackgroundNoise="None" CaptchaHeight="31" CaptchaLength="6" 
                     CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
                     CaptchaMaxTimeout="200" Width="110px" Height="30px" />
               </ContentTemplate>
            </asp:UpdatePanel>
           </td>
           <td align="left" style="width:70%;">
                <asp:TextBox ID="txtVid" runat="server"></asp:TextBox> 
                <asp:RequiredFieldValidator ID="rfvtxtVid" runat="server"  
                   ErrorMessage="Please enter verification code" 
                   ControlToValidate="txtVid" ValidationGroup="jc_reverse_auction">*</asp:RequiredFieldValidator>
          </td>
           </tr>
           <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td height="30">
            <asp:ImageButton ID="imgBtnSubmit" AlternateText="Submit" ImageUrl="images/submit_buttan.png" width="53" height="25" 
                       runat="server" onclick="imgBtnSubmit_Click" ValidationGroup="jc_reverse_auction" />
            
          </td>
        </tr>
        <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td><asp:ValidationSummary ID="valsumReverseAuction" runat="server" ShowMessageBox="True" 
                        ShowSummary="False" ValidationGroup="jc_reverse_auction" /></td>
        </tr>
      </table>
      </td>
      </tr>
    </table>
</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
<!-- end of the content-->
 </form>
</body>
</html>
