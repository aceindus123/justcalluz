<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Advanced_Search.aspx.cs" Inherits="Advanced_Search" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>Just Calluz | Advanced Search  page</title>--%>
<title>Advanced Search - JustCalluz | Perform Your Search All Over India</title>
<meta name='description' content='JustCalluz India's No.1 local search engine provides comprehensive updated information on all B2B and B2C Products & Services. Search for any business all over India and find the best match.' />
<meta name='keywords' content='justcalluz advanced search, justcalluz india search, yellow pages india, indian search engine, indian directory, indian business directory, indian local search engine, advanced yellow pages' />
		
		
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
 <form id="form1" runat="server">
 <script type="text/javascript">
     function onlyNos(e, t) {
         try {
             if (window.event) {
                 var charCode = window.event.keyCode;
             }
             else if (e) {
                 var charCode = e.which;
             }
             else { return true; }
             if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                 return false;
             }
             return true;
         }
         catch (err) {
             alert(err.Description);
         }
     }
        </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
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
<div class="content_innermid" style="width:1000px; padding:0;">
<table width="100%" border="0">
  <tr>
    <td><strong><a href="Default.aspx">Home</a></strong> &gt; Advanced Search</td>
  </tr>
  <tr>
    <td align="center">
    <table width="100%" border="0" style="background:url(images/search.jpg) center no-repeat; width:450px; height:355px;">
      <tr>
        <td height="47" colspan="5">&nbsp;</td>
        </tr>
      <tr>
        <td width="3%">&nbsp;</td>
        <td width="36%">Select A City<strong>*</strong><br /></td>
        <td width="4%" align="center"><strong>:</strong></td>
        <td width="55%" align="left"><asp:TextBox ID="txtcity" runat="server" Width="183px" Height="30px"></asp:TextBox></td>
        <td width="2%" height="30"></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>Search By Company / Name</td>
        <td align="center"><strong>:</strong></td>
        <td align="left"><asp:TextBox ID="txtcomp" runat="server" Width="183px" Height="30px"></asp:TextBox></td>
        <td height="30">&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td> Search By Person's Name</td>
        <td align="center"><strong>:</strong></td>
        <td align="left"><asp:TextBox ID="txtcnctper" runat="server" Width="183px" Height="30px"></asp:TextBox></td>
        <td height="30">&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>Search By Phone</td>
        <td align="center"><strong>:</strong></td>
        <td align="left"><asp:TextBox ID="txtphone" runat="server" Width="183px" Height="30px" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regabp" runat="server" ErrorMessage="enter phone number" ValidationExpression="\d{10}" ControlToValidate="txtphone"
        ValidationGroup="Advancedsearch">*</asp:RegularExpressionValidator>
        </td>
        <td height="30">&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td><asp:ImageButton ID="imgsrch" runat="server" ImageUrl="images/search_buttan.png" 
                onclick="imgsrch_Click" /></td>
        <td height="30">&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td align="right" valign="top"><strong>*</strong>Denotes mandatory fields</td>
        <td height="30" align="right">&nbsp;</td>
      </tr>
    </table>
    <cc3:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtcity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true">
    </cc3:AutoCompleteExtender>
    </td>
  </tr>
  <tr>
    <td><p style="text-align:justify;">To make your search experience more enhanced and precise you can use the Advanced search option. Unlike Basic search option, advanced search option allows you to search either by the Company Name, Person Name or Phone / Mobile number or a combination of any of the fields. So if you have the contact person's name but not the number just key in the name and then choose the accurate option from the displayed list. This option allows you to search for your desired contact with little information. Advanced search helps make your search faster and more accurate.<br /><br />
For e.g. you select the city Mumbai (selecting city is a mandatory option)<br /><br />
In Search by Person's name you type, 'Atul Shah/ 0900000000'<br /><br />
Instantly you will get a list of results from which you can choose your desired contact. The results you get would either have the Name of the contact person highlighted within the search results or the Phone Number of the contact number whichever you have provided during your search. This helps us enhance your search experience in case you do not have any more details handy.<br /><br />
We understand it gets frustrating at times to get apt listings for searched keywords however as we constantly update our Database, at times it becomes challenging to cope with the growing numbers in India. On occasions where you do not find better search results than expected, you can always inform us through, "Search Not Found" link found at the bottom of the page. This helps us improve our databases and makes your search experience perfect and we continue to remain a popular household name and India's No.1 Local Search Engine</p></td>
  </tr>
</table>

</div>
<!-- end of the content-->
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
</form>
</body>
</html>
