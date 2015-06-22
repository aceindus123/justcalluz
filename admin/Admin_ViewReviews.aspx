<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ViewReviews.aspx.cs" Inherits="admin_Admin_ViewReviews" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%--<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>--%>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz - Admin Control Panel - View Reviews</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <%--<link href="includes/RatingStyle.css" rel="Stylesheet" type="text/css" />--%>
    <script src="js/statesopt.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
    <script type="text/javascript" src="js/jquery.rater.js"></script>
    <script type="text/javascript" src="js/tab.js"></script>
    <style type="text/css">        
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }
        .cal_theme .ajax__calendar_active   

        {     
            color: Red;      
            font-weight: bold;      
            background-color: #ffffff; 
        }
        </style>
      <script type="text/javascript">
function CurrentDateShowing(e)
{
      if (!e.get_selectedDate() || !e.get_element().value)

      e._selectedDate = (new Date()).getDateOnly();
}    
</script>
<script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeleteReview.aspx?cid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected Classified has been deleted Successfully");
}
function alertaccept()
{
alert("Selected Classified has been Accepted");
}
    </script>	
    <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>--%>
</head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
         <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
                    <table cellpadding="0" cellspacing="0">
              <tr>
               <td class="style39" valign="top" style="padding-top:10px">                       
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                <table width="750px">
                    <tr>
                       <td>
                          <%--<dataHead:dataHeader ID="datahead1" runat="server" />--%>
                         <cc2:MovieHeader ID="mheader" runat="server" />
                       </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <asp:ScriptManager ID="ScriptManager2" runat="server">
                            </asp:ScriptManager>
                            <a  target="_blank" href="http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                             <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>                           
                        </td>
                    </tr>   
                    <tr><td colspan="2" style="height:15px"></td></tr>
                    <tr>
                        <td colspan="2" align="center">
                            Reviews For 
                            <asp:Label ID="lblHeading" runat="server" Font-Size="Large" ForeColor="#C910C9"></asp:Label>
                        (<asp:Label ID="lblrating" runat="server"></asp:Label>)                                                                                           
                          <span class="ui-rater">                         
                                <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan0"></span></span>
                                <span class="ui-rater-rating" id="Span2" runat="server"></span>&#160;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                          </span>                                                   
                             <asp:Label ID="lblNotfound" runat="server"></asp:Label>
                        </td> 
                    </tr> 
                    <tr>
                        <td colspan="2">
                          <asp:DataList ID="dlReview" runat="server" Width="100%">
                           <ItemTemplate>
                            <table width="100%" border="0" style="border-bottom:#036 1px groove; border-top:#036 1px groove;  padding:5px; background: url(images/menubg.jpg) top repeat-x; height:35px;">
                             <tr>
                              <td style="width:20%" align="center">
                                  <asp:Image ID="imgReviewer" runat="server" ImageUrl='<%# Eval("ImageName", "~/Review_Images\\{0}") %>' Width="64" Height="64"  />                    
                              </td>
                             
                              <td style="width:80%"> 
                               <table width="100%" style="color:Blue">   
                                <tr>
                                 <td>
                                  <table width="100%" style="border-bottom-style:dotted; border-bottom-width:1px">
                                    <tr>
                                       <td height="26" align="left" valign="top" colspan="3">                                                                                                      
                                           <asp:Label ID="lblname" runat="server" Text='<%#Eval("rname") %>'></asp:Label>                                                   
                                        </td>
                                        
                                    </tr>
                                    <tr><td><table width="100%">
                                    <tr>
                                        <td style="width:50%" align="left">
                                            
                                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("remail") %>'></asp:Label>
                                            
                                        </td>
                                        <td style="width:10%">
                                            <asp:Label ID="Label6" runat="server" Text="|"></asp:Label>
                                        </td>
                                        <td align="center" style="width:40%" >
                                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("rmob") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    </table></td></tr>
                                    </table>
                                 </td>
                                </tr>                    
                                    
                                <tr><td></td></tr>
                                <tr>
                                   <td height="26" align="left" valign="top" colspan="3">
                                                                                                  
                                       <asp:Label ID="Label7" runat="server" Text='<%#Eval("review") %>'></asp:Label>         
                                         
                                    </td>
                                    
                                </tr>
                                </table>  
                               </td>
                               <td>
                                <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.rid")%>+");' />                                        
                               </td>
                              </tr>
                              
                              
                             </table>                                                                                              
                            </ItemTemplate>                                                                           
                          </asp:DataList>           
                    </td>
                    </tr>  
                    <tr>
                      <td colspan="2" align="center">
                        <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
                      </td>
                    </tr>  
                    <tr>
                        <td></td>
                    </tr>   
                    <tr>
                        <td>
                            <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
                        </td>
                    </tr> 
                     <tr>
                        <td colspan="2" align="center">
                           
                        </td>
                    </tr>  
                    <tr>
                        <td></td>
                    </tr>  
                    <tr>
                        <td colspan="2" align="center">
                            <asp:ImageButton ID="imgBtnBack" runat="server" 
                                ImageUrl="~/admin/images/back.png" onclick="imgBtnBack_Click" />
                        </td>
                    </tr>                                                     
                </table>
                </td>
                
              </tr>
                
            </table>   
                          
           </td>
         </tr>
         
       </table>
    </div>
    </center>
    </form>
</body>
</html>
