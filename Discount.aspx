<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Discount.aspx.cs" Inherits="_Default" %>

<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>

<%@ Register Src="usercontrols/boxes.ascx" TagName="boxes" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/discountcenter.ascx" TagName="discountcenter" TagPrefix="disccente2" %>
<%@ Register Src="usercontrols/discountright.ascx" TagName="discountright" TagPrefix="discright3" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="~/usercontrols/Search.ascx" TagName="searchjob" TagPrefix="sj" %>
<%@ Register Src="~/usercontrols/discount_left.ascx" TagName="disleft" TagPrefix="discl" %>
<%@ Register Src="~/usercontrols/discount_right.ascx" TagName="disright" TagPrefix="discr" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz-Discounts Home</title>
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
     </style>
     
     
         <script type="text/javascript">function postbackFromJS(sender, e) 
          {
            var postBack = new Sys.Preview.PostBackAction();
            postBack.set_target(sender);
            postBack.set_eventArgument(e);
            postBack.performAction();
          }      
             </script>


<link href="includes/style1.css" rel="stylesheet" type="text/css" />
<link href="includes/style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    
<form id="f1" runat="server" >
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<!--begin of table-->
<table width="960" border="0" bordercolor="#003366"cellpadding="0" cellspacing="0" align="center">
<tr>
<td>
<!--begin of buttons-->
<aa1:signin ID="ghbn" runat="server" />
<aa2:topimage ID="gfgh" runat="server" />
<%--<aa4:selectcity ID="ewwe" runat="server" />--%>
<sj:searchjob ID="sjs" runat="server" />

<aa6:catageories ID="dff" runat="server" />
<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    </asp:UpdatePanel>
    --%>

<table width="950" border="0" cellpadding="0" cellspacing="0" align="center" height="20">
<tr>

 <!-- start the left-->
 <discl:disleft ID="dlm" runat="server" /> 
  <!-- Ending The left-->
<!-- Starting the middle  -->

<td valign="top">
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
<table width="425" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:5px;" class="middle">
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
    Discounts </font></b>
    
    <br />
    <table border="0" style="width:300px">
     <tr><td>
    <asp:UpdatePanel ID="ratingpnl" runat="server">
    <ContentTemplate>
    <table border="0" style="background-color:Silver; width: 403px;">
    <tr><td></td>
    <tr><td class="text6">Rating :</tr>
    
    <td>
             
   <AjaxToolkit:Rating ID="avgrating" runat="server" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starrating" WaitingStarCssClass="starfill" EmptyStarCssClass="starempty"></AjaxToolkit:Rating>
   
  <b> <asp:Label ID="lbl1rate" runat="server" ForeColor="#003366"></asp:Label></b>
    
    </td>
   
    </tr>
    <tr><td></td></tr>
    </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    </td></tr>
    <tr><td><asp:ImageButton ID="post_btn" runat="server" 
            ImageUrl="~/images/post_Discount.jpg" 
            Height="39px" Width="401px" PostBackUrl="~/post_discount.aspx" /> </td></tr>
<tr>
<td class="style1">
    <asp:DataList ID="DataList1" DataKeyField="id" runat="server" Width="290px" Height="400px"
        style="margin-left: 0px" >
          <HeaderTemplate>
            <table>
            
        </HeaderTemplate>
          <ItemTemplate>
            <tr>
                <td valign="top">
                    <table width="45%">
                        <tr>
                            <td>
                            </td>
                        </tr>
                         <tr>
                            <td width="25%" valign="top" align="left"  style=" border: 1px solid green; background-color:#FFFFcc; padding: 2px;">
                               <table width="70%" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td class="dashboardbg" style=" padding:10px;">
                                            <table cellpadding="0Px" cellspacing="0px" width="370PX" align="center">
                                               <tr>
                                                   <td valign="top" width="24%">
                                                       <div style="padding: 0px; margin: 0px;">
                                                                <table border="0">
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            <asp:LinkButton  ID="Linkbutton1" ForeColor="Red" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?id=" + Eval("id").ToString()) %>' 
                                                                                 Text ='<%# Eval("company_name") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td> 
                                                                        <td colspan="3" width="31%" class="dbtextcolr" style="color:#514c48; font-size:12px; font-family:Arial; font-weight:bold" align="right">
                                                                                                                                                   
                                                                        <asp:LinkButton  ID="LinkButton4" ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("postreview1.aspx?id=" + Eval("id").ToString())%>'   
                                                                                     Text="Rate this"  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>    
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:5px"></td>
                                                                     </tr>
                                                                     <tr>
                                                                       <td colspan="18" width="31%" class="dbtextcolr" style="color:#993333; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            <asp:Literal ID="Literal7" runat="server" Text='<%#Eval("event_desc")%>' /></td>
                                                                         </tr>
                                                                     <tr>
                                                                        <td style="height:5px"></td>
                                                                     </tr>
                                                                     <tr>
                                                                    
                                                                        <td width="18%"  style="font-family: Arial; font-size: 12px; font-weight: bold;
                                                                            text-align: left; color: Green">
                                                                            Category&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#036; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                       
                                                                        <td width="31%" class="dbtextcolr" style="color:orange; font-size:12px; font-family:Arial; font-weight:bold">
                                                                          
                                                                       <asp:LinkButton  ID="Linkbutton2" ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?id=" + Eval("id")) %>' 
                                                                             Text ='<%# Eval("Category") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td></td>
                                                                     </tr>
                                                                     <tr>
                                                                    
                                                                        <td width="18%"  style="font-family: Arial; font-size: 12px; font-weight: bold;
                                                                            text-align: left; color: Green">
                                                                            Locality&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#036; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                       
                                                                        <td width="31%" class="dbtextcolr" style="color:orange; font-size:12px; font-family:Arial; font-weight:bold">
                                                                          
                                                                       <asp:LinkButton  ID="Linkbutton3" CssClass="linkbutton"  ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?val={0}", Eval("id")) %>' 
                                                                             Text ='<%# Eval("city") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:10px;"></td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td colspan="3">
                                                                            <table border="0" width="350px">
                                                                                <tr>
                                                                                    <td style="width:80px">
                                                                                        <asp:Button ID="Button3" runat="server" CssClass="button" BorderStyle="None" />            
                                                                                        <asp:Button ID="Button4" runat="server" CssClass="button2" Text='<%# Eval("event_startdate") %>' CommandName ="Select"  BorderStyle="None" />(mm/dd/yyyy)
                                                                                    </td>
                                                                                    <td style="width:20px;"><img src="images/arrow_new.JPG"/></td>
                                                                                    <td style="width:80px" align="right">
                                                                                        <asp:Button ID="Button5" runat="server" CssClass="button1" BorderStyle="None" />            
                                                                                        <asp:Button ID="Button6" runat="server" CssClass="button2" Text='<%# Eval("event_enddate") %>'  CommandName ="Select"  BorderStyle="None" />(mm/dd/yyyy)
                                                                                    </td>
                                                                                    <td style="width:100px" valign="bottom" align="right">
                                                                                         <asp:HyperLink ID="hyp1" runat="server" Text="View Details" Font-Size="13px" ForeColor="Maroon" NavigateUrl='<%# "Discount1.aspx?id=" + Eval("id").ToString() %>' ></asp:HyperLink>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                     </tr>
                                                                  </table>           
                                                            </div>
                                                    </td>
                                               </tr>
                                            </table>
                                        </td>
                                    </tr>
                               </table>
                             </td>
                         </tr>
                     
                    </table>
                </td>
            </tr>
           
        </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
        
        
        </asp:DataList>
        
     
       
 <table border="0" 
        style="background-color:white; width: 100px; margin-right: 0px; height: 0px;">
            <tr>
                <td>
                    <asp:DropDownList ID="ddlPageSize" runat="server" 
                        OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" 
                        style="height: 22px">
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                </td>
               <td>
                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Previous</asp:LinkButton>
                </td>
                <td>
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal" 
                        ForeColor="#996633">            
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnPaging" runat="server" 
                        CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" 
                        Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>&nbsp;
                    </ItemTemplate>
               </asp:DataList>

                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Next</asp:LinkButton>
                </td>
            </tr>
        </table>
        
</td>
</tr>  
   
        
</table>
</td>





</tr>
</table>
        </td>
    </tr>
</table>
</td>

<!-- Ending the Middle -->

<discr:disright ID="drm" runat="server" /> 
</tr>
</table>
<aa10:footer1 ID="dffd" runat="server" />
<aa11:footer2 ID="mnj" runat="server" />
</td>
</tr>
</table>

    </form>
</body>
</html>
