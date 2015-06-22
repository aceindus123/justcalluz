<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_reviews.aspx.cs" Inherits="view_reviews" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="~/usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/boxes.ascx" TagName="boxes" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/discountcenter.ascx" TagName="discountcenter" TagPrefix="disccente2" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="~/usercontrols/discountright.ascx" TagName="discountright" TagPrefix="discright3" %>
<%@ Register Src="~/usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="~/usercontrols/Search.ascx" TagName="searchjob" TagPrefix="sj" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz/View Review</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="includes/style1.css" rel="stylesheet" type="text/css" />

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
          
     .starrating
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starfill
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starempty
    {
    	background-image:url(images/starash3.png);
    	width:18px;
    	height:18px;
    }
     .style24
    {
        font-family: Arial;
        color: #003366;
        font-size: 14px;
        height: auto;
        font-weight: bold;
        line-height: 22px;
        padding-left: 25px;
        width: 271px;
    }
        .style25
        {
            width: 416px;
            height: 801px;
            float: left;
            margin-left: 0px;
            background: url('images/left.jpg') no-repeat;
        }
        .style26
        {
            width: 416px;
        }
     </style>
     
     
         <script type="text/javascript">function postbackFromJS(sender, e) 
          {
            var postBack = new Sys.Preview.PostBackAction();
            postBack.set_target(sender);
            postBack.set_eventArgument(e);
            postBack.performAction();
          }      
             </script>
             
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
    <table><tr><td>
    <sig:signin ID="sig1" runat="server" />
   <aa2:topimage ID="bbb" runat="server" />
  
 
 
    
<sj:searchjob ID="sjs" runat="server" />


<aa6:catageories ID="fgu" runat="server" />
              <table border="1">
              <tr align="center">
              <td width="255" valign="top" class="left">
   
        <table width="255" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:2px;">
        <tr><td class="refinedsearch"><b>Category List</b></td></tr></table>
            <div class="innertext">
     <br />
     <table border="0" cellpadding="0" cellspacing="0"  align="left"
        style="margin-top:5px; border: 2px solid #003366; width: 240px;">
         <tr>
            <td  style="height:10px"></td>
         </tr>
         <tr>
            <td>
                <div class="innertext">
                     <table border="0">
                        <tr>
                            <td>
                                <asp:DataList ID="DataList2"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                                        Height="117px" Width="226px" OnItemCommand="DataList2_ItemCommand">
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="innertext">
                                    <table border="0">
                                        <tr>
                                            <td><img src="images/arrow1.jpg" />&nbsp;&nbsp;</td>
                                            <td valign="top">
                                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("Category")%>'
                                                     Text ='<%# Eval("Category") %>' CommandName="select">
                                                </asp:LinkButton>
                                                
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="10px"></td>
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
  </div>
  </td>
  <!-- Ending The left-->
<!-- Starting the middle  -->

              <td align="center">
              
<table width="425" border="0" cellpadding="0" cellspacing="0">
<tr><td valign="top"><object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="418" height="100">
  <param name="movie" value="images/discoutnew.swf" />
  <param name="quality" value="high" />
  <param name="wmode" value="opaque" />
  <param name="swfversion" value="6.0.65.0" />
  <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
  <param name="expressinstall" value="Scripts/expressInstall.swf" />
  <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
  <!--[if !IE]>-->
  <object type="application/x-shockwave-flash" data="images/discoutnew.swf" width="418" height="100">
    <!--<![endif]-->
    <param name="quality" value="high" />
    <param name="wmode" value="opaque" />
    <param name="swfversion" value="6.0.65.0" />
    <param name="expressinstall" value="Scripts/expressInstall.swf" />
    

    <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
    <div>
      <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
      <embed src="flash.swf" quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="418" height="100"></embed>

    </div>
    <!--[if !IE]>-->
  </object>
  <!--<![endif]-->
</object></td></tr></table>
              <table width="425" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:5px;">
<tr>
<td width="350" valign="top">
<table width="430" border="0" cellpadding="0" cellspacing="0" align="center" class="middle">
    <tr>
        <td class="refinedsearch">
           <b><a href="Default.aspx" style="color:#FFF; text-decoration:none;">Home&gt;&gt;</a><a href="Discount.aspx" style="color:#FFF; text-decoration:none;">Discount</a></b>
        </td>
    </tr>
</table>
    <table width="350" border="1" height="auto" bordercolor="#003366" cellpadding="0" cellspacing="0" style="margin-top:10px;">
<tr>
<td class="text" style="text-align:center;" valign="top"><b>Result for :<font color="#336633"> 
    Reviews of Discounts </font></b>
    
    <br />
    <asp:UpdatePanel ID="ratingpnl" runat="server">
    <ContentTemplate>
    <table width="500" height="30" style="background-image:url(images/rating_bg.png)">
    <tr><td class="style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Overall Rating :</td>
    <td>
    
    <AjaxToolkit:Rating ID="avgrating" runat="server" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starrating" WaitingStarCssClass="starfill" EmptyStarCssClass="starempty"></AjaxToolkit:Rating>
    
    </td>
   <td></td>
    </tr>
    </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    
             
    <asp:DataList ID="reviewdl" runat="server"  RepeatDirection="Horizontal" OnItemDataBound="reviewdl_ItemDataBound"
                                                RepeatColumns="1" cellpadding="5" cellspacing="5" Width="450px"  
                            Font-Size="Small">                                                
                                            <ItemTemplate>
                                                <table align="center" width="380px" border="0" style="border-left:#036 1px dashed; border-right:#036 1px dashed; border-bottom:#036 1px dashed;  padding:5px; background-color:#BFD9FF; height:35px; width:450px" >
                                                   <tr style="background-color:#003366"><td colspan="5" style="color:White; font-family:Monotype Corsiva; font-weight:bold; font-size:medium;" align="left"><asp:Label ID="lblcmp" runat="server" ></asp:Label></td></tr>
                                                    <tr>
                                                       <td align="left" border="1" width="40%" style="color:#003366">
                                                            <asp:Image  ID="imgReviewer"  runat="server"  ImageUrl='<%# Eval("ImageName", "~/Review_Images\\{0}") %>'  Width="70"  Height="80"   /> <br />                                                         
                                                        <br />
                                                        
                                                        Rating : &nbsp;<asp:Label ID="lblrating" runat="server" BorderColor="AliceBlue"></asp:Label>
                                                         <asp:Label ID="rates" runat="server" Text='<%#Eval("Stars_Rating") %>' Visible="false"></asp:Label>
                                                        <br />&nbsp;&nbsp;<asp:Label ID="rate" runat="server" Text='<%#Eval("rating") %>' Visible="false"></asp:Label>
                                                        
                                                        <%--<%#DataBinder.Eval(Container.DataItem, "rating")%>--%>
                                                             
                                                        </td>
                                                        
                                                        <td>
                                                        
                                                        <table border="0" width="100%"><tr>
                                                        <td style="color:#003366" align="left">
                                                        <%#DataBinder.Eval(Container.DataItem, "rname")%> Says
                                                                <%--<asp:Label ID="Label4" runat="server" Text='<%#Eval("rname") %>'>&nbsp;Says</asp:Label>--%>
                                                            
                                                        </td>
                                                        
                                                        <td style="color:#003366">
                                                         
                                                        <%--<asp:Label ID="lblrate" runat="server" Text='<%#Eval("rating") %>'></asp:Label>--%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="padding-top:10px; color:#003366" align="left">
                                                         <%#DataBinder.Eval(Container.DataItem, "review")%>
                                                            <%--<asp:TextBox ID="txtDesc" runat="server" Text='<%#Eval("review") %>' TextMode="MultiLine"  MaxLength="100" Width="740px" BorderStyle="None" BorderColor="White" BorderWidth="0"></asp:TextBox>--%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                    <td style="padding-top:10px; color:#003366" align="left">
                                                    <asp:Image ID="mail" runat="server" ImageUrl="~/images/mail1.png" /> &nbsp; <%#DataBinder.Eval(Container.DataItem, "email")%>
                                                    <%--<asp:Label ID="lblmail" runat="server" Text='<%#Eval("remail') %>'></asp:Label>--%></td></tr>
                                                    <tr>
                                                    <td style="padding-top:10px; color:#003366" align="left"><asp:Image ID="mob" runat="server" ImageUrl="~/images/phone.png" />
                                                   &nbsp;&nbsp;&nbsp;
                                                     <%#DataBinder.Eval(Container.DataItem, "mob")%>
                                                    <%--<asp:Label ID="rmob" runat="server" Text='<%#Eval("rmob") %>'></asp:Label>--%></td></tr>
                                                    <tr><td colspan="5" style="padding-top:10px; color:#003366" align="left">
                                                    <%#DataBinder.Eval(Container.DataItem, "Img_Caption")%>
                                                    </td></tr>
                                                    </table>
                                                    </td>
                                                    </tr></table>
                                                                                                                                                
                                            </ItemTemplate>
                                            
                                            
                                        </asp:DataList>
                                        </td>
                                        </td>
                                        </tr>
                                        </table>
                                        
                                        
                                        </td>
                                        </tr>
                                        </table>
                                        
                                        </td>
                                        <td width="255" valign="top" class="left">
<table width="255" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:5px;">
<tr><td class="refinedsearch"><b>Sponsor Ads</b></td></tr></table>

<table width="255" border="1" bordercolor="#003366" cellpadding="0" cellspacing="0" style="margin-top:18px;">
<tr>
<td class="style1">
<table width="255" border="0" bordercolor="#003366" cellpadding="0" cellspacing="0"">
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
                <asp:DataList ID="DataList3"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="226px"  OnItemCommand="DataList3_ItemCommand">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0" width="220px">
                        <tr>
                            <td valign="top" height="15px">
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("heading")%>'
                                 Text ='<%# Eval("heading") %>' CommandName="select" ForeColor="Orange">
                                </asp:LinkButton>
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
<!--end of 3 column-->
</td>

                                        </tr>
                                        </table>
<aa10:footer1 ID="bvu" runat="server" />

<aa11:footer2 ID="ayh" runat="server" />
                                        </td></tr></table>
                                        
    </div>
    </form>
</body>
</html>
