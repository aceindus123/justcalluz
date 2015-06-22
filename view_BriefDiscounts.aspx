<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_BriefDiscounts.aspx.cs" Inherits="view_BriefDiscounts" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/CheckPostLeftMenu.ascx" TagName="leftcheckpost" TagPrefix="lcp" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Discounts page</title>--%>
<title>Justcalluz | Find Discount and coupon code in your city | we provide updated information on all your local search</title>
<meta name='description' content='Discount rates,sale,Event Management'/>
<meta name='keywords' content='Justcalluz,Discount rates,sale,Event Management,online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="awea" runat="server" />
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
<div class="content" style="padding:0; margin:0;">
<!-- start the inner left-->
<div class="content_innerleft">
<div>
<div class="contentbox_top">My Postings</div>
<div class="contentbox_mid">
 <lcp:leftcheckpost ID="leftcheckpost" runat="server" />
 </div>
<div class="contentbox_bottam"></div>
</div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid" style="width:79%">
  <div class="searchmid_box">
  <div class="searchmid_boxtop1"><%--<a href="Default.aspx" style="text-decoration:none;color:White">
      Home</a>--%>
    <asp:HyperLink ID="hyplink" runat="server" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute%>" Text="Home" Font-Underline="false" ForeColor="White"></asp:HyperLink>&gt;&gt;<a href="ToCheckPostings.aspx" style="text-decoration:none;color:White">My Postings</a>&gt;&gt;Discounts</div>
  <div class="searchmid_boxmid1">
    <table width="100%" border="0">
      <tr id="trHeading" runat="server" class="sub_menu">
        <td align="center">
        <asp:Label ID="lblHeading1" runat="server" Font-Size="Medium" Text="Discount Posted By You"></asp:Label>
        </td>
      </tr>
      <tr>
        <td align="center">
        <asp:DataList ID="dlData" RepeatDirection="Vertical" CellPadding="4" runat="server" 
                        Height="200px" Width="100%" 
                 onitemdatabound="dlData_ItemDataBound" DataKeyField="id"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
         <table width="100%" border="0" style="line-height:40px">         
          <tr>                   
           <td colspan="3" align="center">
            <table width="100%" border="0">             
             <tr><td style="height:20px" colspan="3"></td></tr>   
              <tr id="trStatus" runat="server" class="side_menu">
                <td  align="center" colspan="3">Status &nbsp; :&nbsp;&nbsp;
                    <asp:Label ID="lblStatus" runat="server" Font-Size="Small" Text='<%#Eval("ApprovedStatus")%>' ></asp:Label>  
                </td>
            </tr>            
            <tr><td style="height:20px" colspan="3"></td></tr>
                       
             <tr id="trPerInfo" runat="server">
                <td colspan="2" align="right" class="sub_menu">
                    <asp:Label ID="Label20" runat="server" Text="Discount Information"></asp:Label>
                </td><td>&nbsp;</td>
             </tr>
             <tr id="trName" runat="server" class="side_menu" >
                <td align="right" width="45%">Company</td>
                <td width="1%" align="center">:</td>
                <td align="left" width="54%" >
                    <asp:Label ID="lblcompany" runat="server" Text='<%#Eval("company_name")%>'></asp:Label>  
                </td>
            </tr>
             <tr id="trSpeciality" runat="server" class="side_menu">
                <td align="right">Address</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lbladres" runat="server" Text='<%#Eval("address")%>'></asp:Label>  
                </td>
            </tr>
            <tr id="tr1" runat="server" class="side_menu">
                <td align="right">Land Mark</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lbllmark" runat="server" Text='<%#Eval("land_mark")%>'></asp:Label>  
                </td>
            </tr> 
            <tr id="tr2" runat="server" class="side_menu">
                <td align="right">Pincode</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblpincode" runat="server" Text='<%#Eval("pincode")%>'></asp:Label>  
                </td>
            </tr> 
            <tr id="tr4" runat="server" class="side_menu">
                <td align="right">Contact Person</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblcperson" runat="server" Text='<%#Eval("contact_person")%>'></asp:Label>  
                </td>
            </tr> 
            <tr id="trbName" runat="server" class="side_menu">
                <td align="right">Contact Number</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblmob" runat="server" Text='<%#Eval("mob")%>'></asp:Label>
                </td>
            </tr>
             <tr id="tr5" runat="server" class="side_menu">
                <td align="right">Contact MailId</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblemail" runat="server" Text='<%#Eval("Emailid")%>'></asp:Label>  
                </td>
            </tr> 
            <tr id="trBusDesc" runat="server" class="side_menu">
                <td align="right">Company Website</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblwebsite" runat="server" Text='<%#Eval("Website")%>'></asp:Label>  
                </td>
            </tr> 
            <tr class="side_menu" runat="server">
             <td align="right">StartDate</td>
             <td>:</td>
             <td align="left">
               <asp:Label ID="lblfDate" runat="server" Text='<%#Eval("event_startdate") %>'></asp:Label>
             </td>
             </tr>
             <tr class="side_menu" runat="server">
             <td align="right">EndDate</td>
             <td>:</td>
             <td align="left">
               <asp:Label ID="lbllDate" runat="server" Text='<%#Eval("event_enddate") %>'></asp:Label>
             </td>
             </tr>
            <tr id="tr3" runat="server" class="side_menu">
                <td align="right">Fax</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblfax" runat="server" Text='<%#Eval("fax")%>'></asp:Label>  
                </td>
            </tr> 
            <tr id="trLogo" runat="server">
            <td>
            <table border="0">
            <tr>
             <td align="right">Logo</td>
             <td>:</td>
             <td align="left">
              <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
             <asp:Image ID="imglogo" runat="server" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' Width="50px" Height="50px" AlternateText="companyLogo" /></td>
           </tr>
           <tr><td></td>
            </tr>
            </table>
            </td>
           </tr>
           </table> 
           </td></tr>
           </table>
        </ItemTemplate>
        </asp:DataList>
        </td>
      </tr>
       <tr id="trPName" runat="server">
            <td align="left">Photos</td></tr>
      <tr id="trPImages" runat="server">
            <td align="left"><asp:Panel ID="photopnl" runat="server">
            <fieldset>
            <asp:DataList ID="dlphoto" runat="server" DataKeyField="dataid" RepeatColumns="5">
            <ItemTemplate>
            <asp:Image ID="imgphoto" runat="server" ImageUrl='<%# Eval("PhotoName", "../Photos\\{0}") %>' Width="100px" Height="80px" AlternateText="CompanyPhotos" />
            </ItemTemplate>
            </asp:DataList>
            </fieldset>
            </asp:Panel>
            </td>
      </tr>
      <tr style="background-color:Silver" id="trMoreinfo" runat="server"><td colspan="10"><span style="font-weight:bold; font-size:small; font-family:Arial">
      Hours Of Operation</span></td></tr>
   <tr><td colspan="3"></td></tr>
    <tr><td>
   <asp:DataList ID="dlmoreinfo" runat="server" Width="700px" DataKeyField="dataid" Visible="false">
        <ItemTemplate>
   <table width="700px"> 
  <tr>
  <td width="200px">
  <span style="font-size:small; font-family:Arial">Monday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">          
      <asp:Label ID="lblMonday" runat="server" Text='<%#Eval("mon")%>'></asp:Label>
  </td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Tuesday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblTuesday" runat="server" Text='<%#Eval("tue")%>'></asp:Label></td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Wednesday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblWednesday" runat="server" Text='<%#Eval("wed")%>'></asp:Label></td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial" >Thursday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblThursday" runat="server" Text='<%#Eval("thu")%>'></asp:Label></td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Friday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblFriday" runat="server" Text='<%#Eval("fri")%>'></asp:Label></td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Saturday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblSaturday" runat="server" Text='<%#Eval("sat")%>'></asp:Label></td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Sunday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="lblSunday" runat="server" Text='<%#Eval("sun")%>'></asp:Label></td>
  </tr>
   <tr style="background-color:Silver">
   <td colspan="10"><span style="font-weight:bold; font-size:small; font-family:Arial">
     Mode of Payement</span>
  </td>
  </tr>   
  <tr>
   <td colspan="3" style="font-size:small; font-family:Arial;">
      <asp:Label ID="Label4" runat="server" Text='<%#Eval("PaymentMode")%>'></asp:Label></td>
  </tr>    
  <tr>
     <td>&nbsp;</td>
  </tr>
  </table> 
  </ItemTemplate>
  </asp:DataList> 
  </td>
  </tr>  
<tr><td colspan="3" align="center">&nbsp;</td></tr>
<tr><td colspan="3" align="center">&nbsp;</td></tr>  
<tr><td colspan="3" align="center" class="sub_menu">
<a id="lnkUpdate" onserverclick="lnkUpdate_Click" runat="server">Click Here To Update</a> 
<%--<asp:HyperLink ID="hyplinkUpdate" runat="server" 
                          NavigateUrl='<%# GetEditUrl(Eval("id"))%>' Text="Click Here To Update"></asp:HyperLink>--%>
 </td></tr> 
   <tr>
        <td align="center" valign="middle" style="padding-top:10px; font-size:medium">
                  <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </td>
       </tr>
      </table>
  </div>
  <div class="searchmid_boxbottam1"></div>
  </div>
  </div>

<!-- end of the mid Box-->
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>

<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />
</div>
<div class="footer" align="center">
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
    </form>
</body>
</html>
