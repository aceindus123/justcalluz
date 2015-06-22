<%@ Control Language="C#" AutoEventWireup="true" CodeFile="catageories.ascx.cs" Inherits="usercontrols_catageories" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

  <%--/* Autocomplete extender code */--%>
<%-- <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>--%>
<link href="css/jquery-ui.css" rel="stylesheet" type="text/css" />
<%-- <script src="js/jquery-ui.min.js" type="text/javascript"></script>--%>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>  
  <style type="text/css">
           div.selectBox
			{
				position:relative;
				display:inline-block;
				cursor:default;
				text-align:left;
				line-height:30px;
				clear:both;
				color:#888;
			}
			span.selected
			{
				width:167px;
				text-indent:20px;
				border:1px solid #ccc;
				border-right:none;
				border-top-left-radius:5px;
				border-bottom-left-radius:5px;
				background:#f6f6f6;
				overflow:hidden;
			}
			span.selectArrow
			{
				width:30px;
				border:1px solid #ccc;
				border-top-right-radius:5px;
				border-bottom-right-radius:5px;
				text-align:center;
				font-size:20px;
				-webkit-user-select: none;
				-khtml-user-select: none;
				-moz-user-select: none;
				-o-user-select: none;
				user-select: none;
				background:#f6f6f6;
			}
			
			span.selectArrow,span.selected
			{
				position:relative;
				float:left;
				height:30px;
				z-index:1; color:#666;
			}
			
			div.selectOptions
			{
				position:absolute;
				top:165px;
				left:10;
				width:200px;
				border:1px solid #ccc;
				border-bottom-right-radius:5px;
				border-bottom-left-radius:5px;
				overflow:hidden;
				background:#f6f6f6;
				padding-top:2px;
				display:none;
				z-index:3;
				overflow:scroll;
				height:200px;
			}
				
			span.selectOption
			{
				display:block;
				width:80%;
				line-height:20px; padding-left:16px;
/*				padding:5px 10%; */	
		}
			
			span.selectOption:hover
			{
				color:#f6f6f6;
				background:#4096ee;	
			}	

   </style>
    <script type="text/javascript" language="javascript">
        $(function () {
            $(".tabls").autocomplete({
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
    <script type="text/javascript" language="javascript">
        $(function () {
            $(".mytab").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchAreasList",
                       // data: "{ 'area': '" + request.term + "'}",
                        data: "{ 'area': '" + request.term + "' ," +
                          "'City': '" + $('.tabls').val() + "'}",
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
        </script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $(".seatoptd").autocomplete({
                source: function (request, response) {
                    var status = $('[name$="r1"]:radio:checked').val();
                    if (status == null) {
                        alert('Please check company name or Category');

                    }
                    $.ajax({
                        url: "AreasList.asmx/FetchSearchList",
                        data: "{ 'sear': '" + request.term + "' ," +
                          "'City': '" + $('.tabls').val() + "' ,"+
                         "'Type':'" + status + "'}",
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
	</script>
   
    <script type="text/javascript" language="javascript">
        function emptytxt(cntrls) {
            cntrls.value = "";
        }
    </script>

    <%--/* Autocomplete extender code */--%>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
    <ContentTemplate>
<table width="100%" border="0">
  <tr>
    <td width="25%" align="left"><strong>City</strong></td>
    <td width="3%">&nbsp;</td>
    <td width="44%" height="20" align="left">
    <table width="100%" border="0">
      <tr>
        <td width="20%" height="20"><strong>Search for&nbsp;&nbsp;&nbsp;</strong></td>
        <td width="5%" align="right"><strong>
          <asp:RadioButton ID="rb1comp" runat="server" GroupName="r1" AutoPostBack="true" Text="." ForeColor="White"/>
        </strong></td>
        <td width="34%" align="left"><strong>Company Name&nbsp;&nbsp;</strong></td>
        <td width="5%" align="right"><strong>
           <asp:RadioButton ID="rb2cat" runat="server" GroupName="r1" AutoPostBack="true" Text="." ForeColor="White"/>
        </strong></td>
        <td width="46%" align="left"><strong>Category</strong></td>
      </tr>
    </table>
     
    </td>
    <td width="2%">&nbsp;</td>
    <td width="36%" align="left"><strong><asp:Label ID="lblarea" runat="server" Width="200px" Height="20px" Text="Where in City?"></asp:Label></strong></td>
    <td width="2%">&nbsp;</td>
    <td width="4%">&nbsp;</td>

  <asp:ValidationSummary ID="ValSumSearch" runat="server" ShowMessageBox="True" 
            ShowSummary="False" ValidationGroup="SearchGroup" />
              </tr>
  <tr>
    <td valign="top"><asp:TextBox ID="txtSelectMCity" runat="server" Height="30px" Width="200px" CssClass="tabls" AutoPostBack="true" OnTextChanged="txtcityCha" ></asp:TextBox></td>
           <%-- <AjaxToolkit:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtSelectCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" 
           CompletionInterval="500" ServiceMethod="Getcities" ServicePath="<%$RouteUrl:RouteName=HomeRoute%>" ShowOnlyCurrentWordInCompletionListItem="true">
    </AjaxToolkit:AutoCompleteExtender>--%>
    <%--<AjaxToolkit:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtSelectCity" MinimumPrefixLength="1" EnableCaching="true"
     CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true">
    </AjaxToolkit:AutoCompleteExtender>--%>
    <AjaxToolkit:TextBoxWatermarkExtender ID="txtcitywater" runat="server" TargetControlID="txtSelectMCity" WatermarkText="Enter City" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>
    <td>&nbsp;</td>
    <td>
        <asp:TextBox ID="txtSearchMFor" runat="server" Width="387px"  Height="30px" CssClass="seatoptd" ></asp:TextBox>
         <%--<AjaxToolkit:TextBoxWatermarkExtender ID="TWEtxtSearchMFor" runat="server" TargetControlID="txtSearchMFor" WatermarkText="Enter companyname or category" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>--%>
        <%--<AjaxToolkit:AutoCompleteExtender ID="autoselect_catcomp" runat="server" TargetControlID="txtSearchMFor" MinimumPrefixLength="1" EnableCaching="true"
         CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetCategories1" ShowOnlyCurrentWordInCompletionListItem="true">
    </AjaxToolkit:AutoCompleteExtender>--%>
        <a id="A1" href="<%$RouteUrl:RouteName=N_Search%>" runat="server">National Search</a>&nbsp; |&nbsp;<%--<a id="adv_search" runat="server" onserverclick="adv_search_Click">
      <asp:Label ID="lblSearch" runat="server" Text="Advanced Search"></asp:Label></a>--%><asp:LinkButton 
            ID="adv_search" runat="server" Text="Advanced Search" 
            OnClick="adv_search_Click"></asp:LinkButton>
    <asp:RequiredFieldValidator ID="rfvSearchFor" runat="server" 
        ErrorMessage="Please enter a keyword to search" 
        ControlToValidate="txtSearchMFor" ValidationGroup="SearchGroup">*</asp:RequiredFieldValidator>
        <%--<AjaxToolkit:TextBoxWatermarkExtender ID="txtcatwater" runat="server" TargetControlID="txtSearchMFor" WatermarkText="Enter companyname or category" 
        WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>--%></td>
    <td>&nbsp;</td>
    <td valign="top">
    <asp:TextBox ID="txtWhereMIn" runat="server" Width="230px"  Height="30px" CssClass="mytab" >
    </asp:TextBox>
    <%--<AjaxToolkit:AutoCompleteExtender ID="autoarea" runat="server" TargetControlID="txtWhereMIn" MinimumPrefixLength="1" EnableCaching="true"
     CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetArea1" ShowOnlyCurrentWordInCompletionListItem="true">
    </AjaxToolkit:AutoCompleteExtender>--%>
    <br />
    <asp:CheckBox ID="chkremember" runat="server" Text=" Remember My Location" />
     <%--Remember My Location--%>
    <%--<AjaxToolkit:TextBoxWatermarkExtender ID="txtwherewater" runat="server" TargetControlID="txtWhereMIn" WatermarkText="Enter area" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>--%></td>
    <td>&nbsp;</td>
    <td align="left" valign="top"><asp:ImageButton ID="BtnSearch" runat="server" ImageUrl="../images/go.jpg" 
            onclick="BtnSearch_Click" 
            ValidationGroup="SearchGroup" /></td>
  </tr>
 <%-- <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td align="left"></td>
    <td>&nbsp;</td>
    <td><input type="checkbox" autocomplete="OFF" />
       </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>--%>
</table>
</ContentTemplate>
    </asp:UpdatePanel>
 
   
  <%--<table width="100%" border="0">
  <tr>
  <td width="180px">&nbsp;</td>
  <td width="280px" colspan="3">&nbsp;</td>
  <td width="250px">&nbsp;</td></tr>
<tr>
<td width="75px" style="color:#cc6600; font-weight:bold;" >Select City</td> 

<td width="50px" class="text" style="color:#cc6600; font-weight:bold;" align="left">Search for</td>
<td width="80px" align="left" style="color:#cc6600; font-weight:bold;">
    <asp:RadioButton ID="rb1comp" runat="server" GroupName="r1" AutoPostBack="true" Text="." ForeColor="White"/>&nbsp;Company Name</td>

<td width="60px" class="text" style="color:#cc6600; font-weight:bold;">
 <asp:RadioButton ID="rb2cat" runat="server" GroupName="r1" Checked="true" AutoPostBack="true" Text="." ForeColor="White"/>&nbsp;Category</td>


<td width="130px" style=" color:#cc6600; font-weight:bold; padding-right:30px">
    <asp:Label ID="lblarea" runat="server" Width="200px" Height="20px" Text="Where in City ?"></asp:Label></td>
   
<!--end of text-->
</tr>
</table>
   
        <asp:ValidationSummary ID="ValSumSearch" runat="server" ShowMessageBox="True" 
            ShowSummary="False" ValidationGroup="SearchGroup" />  

<table width="960" border="0" cellpadding="0" cellspacing="0">
<tr>

<td width="10">&nbsp;</td>
 <td colspan="6" style="background:url(images/rectanglebox.jpg) top no-repeat;  width:935px; height:49px">
<!--begin of innertext-->
<table width="900" border="0" cellpadding="0" cellspacing="0" align="center">
<tr>
<td align="center" style="color:Gray; font-size:12px;">
          <asp:Panel ID="Panel2" runat="server" BorderWidth="0px" BorderColor="#336699" 
            Height="25px" Width="164px">
        
    <table style="height: 25px" id="t"><tr><td>
        <asp:TextBox ID="txtSelectCity" runat="server" Height="20px" Width="126px" 
            ontextchanged="txtSelectCity_TextChanged" AutoPostBack="true"></asp:TextBox></td>
        </tr></table>
    </asp:Panel>
    <AjaxToolkit:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtSelectCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true">
    </AjaxToolkit:AutoCompleteExtender>
    <AjaxToolkit:TextBoxWatermarkExtender ID="txtcitywater" runat="server" TargetControlID="txtSelectCity" WatermarkText="Enter City" WatermarkCssClass="water"></AjaxToolkit:TextBoxWatermarkExtender>
</td>
    
<td style="width:425px" style="color:Gray; font-size:12px;">
       
    <asp:TextBox ID="txtSearchFor" runat="server" Width="387px" 
        ontextchanged="txtSearchFor_TextChanged" AutoPostBack="true"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvSearchFor" runat="server" 
        ErrorMessage="Please enter a keyword to search" 
        ControlToValidate="txtSearchFor" ValidationGroup="SearchGroup">*</asp:RequiredFieldValidator>
        <AjaxToolkit:TextBoxWatermarkExtender ID="txtcatwater" runat="server" TargetControlID="txtSearchFor" WatermarkText="Enter companyname or category" WatermarkCssClass="water"></AjaxToolkit:TextBoxWatermarkExtender>

</td>
<td style="color:Gray; font-size:12px;">
    <asp:TextBox ID="txtWhereIn" runat="server" Width="190px"></asp:TextBox>
    <AjaxToolkit:TextBoxWatermarkExtender ID="txtwherewater" runat="server" TargetControlID="txtWhereIn" WatermarkText="Enter area" WatermarkCssClass="water"></AjaxToolkit:TextBoxWatermarkExtender>
    </td>
    
    <td>
        <asp:Button ID="BtnSearch" runat="server" Text="Search" ForeColor="maroon" 
            Font-Bold="true" BackColor="YellowGreen" onclick="BtnSearch_Click" 
            ValidationGroup="SearchGroup" /></td>
   
<!--end of inner text-->

</tr>
</table>
</td>
<!--end of the rectanglebox-->
</tr>
</table>

--%>
<div class="clr" style="margin-bottom:10px;"></div>

