<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_AdsPost.aspx.cs" Inherits="admin_Admin_AdsPost" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_AdsHeader.ascx" TagName="AdsHeader" TagPrefix="Ads" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Post Ads</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
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
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              <script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeleteData.aspx?cid=' +uid;
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
        <script type="text/javascript" src="js/tab.js"></script>

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
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
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td colspan="3">                      
                       <Ads:AdsHeader ID="ads1" runat="server" />
                    </td>
                    </tr> 
                     <tr>
                      <td align="right" width="56%" >
                          <span style="font-size:21; font-weight:bold; color:DarkBlue; font-family:Verdana;">To Post Ads</span> 
                        </td>
                        <td align="right" style="padding-right:10px;padding-top:5px;"  width="44%">
                        <a href="http://www.justcalluz.com/tv_ads.aspx" target="_blank"> 
                           <img src="images/Click Here For SiteView.png"/>
                        </a></td> 
                      </tr>                                                
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                            <td align="right" style="padding-right:5px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_Ads.aspx"></asp:LinkButton> 
                            </td>
                        </tr>    
                                         
                        <tr>
                            <td colspan="3">
                                <table width="100%">
                                    <tr>
                                        <td colspan="3">
                                            <table width="100%">
                                                <tr class="adminform">
                                                    <td width="40%" align="right">
                                                       Type of the Ad
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlAdType" runat="server" Width="200px" 
                                                            AutoPostBack="true" onselectedindexchanged="ddlAdType_SelectedIndexChanged" 
                                                           >
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvddlAdType" runat="server" 
                                                            ControlToValidate="ddlAdType" ErrorMessage="Please select Type of the Ad" 
                                                            InitialValue="Select Ad Type" ValidationGroup="PostAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trSubType" runat="server" visible="false">
                                                    <td colspan="2">                                                        
                                                    </td>                                                    
                                                    <td align="left" width="50%">
                                                       <asp:DropDownList ID="ddlAdSubType" runat="server" Width="200px">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvddlAdSubType" runat="server" 
                                                            ControlToValidate="ddlAdSubType" 
                                                            ErrorMessage="Please Select" InitialValue="Select" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator> 
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trLanguage" runat="server" visible="false">
                                                    <td width="40%" align="right">
                                                       Language
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlLanguage" runat="server" Width="200px">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvLang" runat="server" 
                                                            ControlToValidate="ddlLanguage" 
                                                            ErrorMessage="Please Select Language" InitialValue="Select Language" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trCity" runat="server" visible="false">
                                                    <td align="right" width="40%">
                                                    City                                                        
                                                    </td>
                                                    <td align="center" width="5%">:</td>                                                    
                                                    <td align="left" width="50%">
                                                        <asp:DropDownList ID="ddlCity" runat="server" Width="200px" AutoPostBack="true">
                                                        </asp:DropDownList>
                                                         <asp:RequiredFieldValidator ID="rfvddlCity" runat="server" 
                                                            ControlToValidate="ddlCity" 
                                                            ErrorMessage="Please Select City" InitialValue="Select City" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator> 
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trPaper" runat="server">
                                                    <td align="right" width="40%">
                                                    Name of the Paper                                                        
                                                    </td>
                                                    <td align="center" width="5%">:</td>                                                    
                                                    <td align="left" width="50%">
                                                        <asp:TextBox ID="txtPaper" runat="server" Width="195px" onkeypress="return Alphabets(event);"></asp:TextBox>                                                                                                                   
                                                        <asp:RequiredFieldValidator ID="rfvPaper" runat="server" 
                                                            ControlToValidate="txtPaper" 
                                                            ErrorMessage="Please enter News Paper name" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator> 
                                                             <asp:Label ID="lblhidden" runat="server" Visible="false"></asp:Label>
                                                            <AjaxToolkit:AutoCompleteExtender ID="autoselectPaper" runat="server" TargetControlID="txtPaper" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetNewsPaper" ShowOnlyCurrentWordInCompletionListItem="true">
                                                            </AjaxToolkit:AutoCompleteExtender>
                                                            <AjaxToolkit:TextBoxWatermarkExtender ID="txtpaperwater" runat="server" TargetControlID="txtPaper" WatermarkText="Enter News Paper Name" WatermarkCssClass="water"></AjaxToolkit:TextBoxWatermarkExtender>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trTitle" runat="server" visible="false">
                                                    <td width="40%" align="right">
                                                      Title
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:TextBox ID="txtTitle" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                                            ErrorMessage="Please Enter Title to Display"
                                                            ControlToValidate="txtTitle" ValidationGroup="PostAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trThumbnail" runat="server" visible="false">
                                                    <td width="40%" align="right">
                                                        Thumbnail Upload
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:FileUpload ID="ImageUpload" runat="server" 
                                                          />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                            ControlToValidate="ImageUpload" ErrorMessage="Please Upload an image" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator> <br /> 
                                                        <asp:CustomValidator ID="CVImgUpload" runat="server" 
                                                            ErrorMessage="CustomValidator" ControlToValidate="ImageUpload" ValidateEmptyText="true" Display="Dynamic" 
                                                            onservervalidate="CVImgUpload_ServerValidate" ValidationGroup="PostAd"></asp:CustomValidator>                                                          
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trUpload" runat="server">
                                                    <td width="40%" align="right">
                                                        <asp:Label ID="lblUpload" runat="server"></asp:Label> Upload
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:FileUpload ID="MediaAudioPrintAdUpload" runat="server" />
                                                        <asp:RequiredFieldValidator ID="rfvFileUpload" runat="server" 
                                                            ControlToValidate="MediaAudioPrintAdUpload" ErrorMessage="Please Upload File" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator><br />
                                                        <asp:CustomValidator ID="CVFile" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true" 
                                                            ControlToValidate="MediaAudioPrintAdUpload" Display="Dynamic" 
                                                            onservervalidate="CVFile_ServerValidate" ValidationGroup="PostAd"></asp:CustomValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="2px">
                                                    <asp:Label ID="lblImageUploadStatus" runat="server" Visible="false"></asp:Label>                                                    
                                                    <asp:Label ID="lblVedioAudioUploadStatus" runat="server" Visible="false"></asp:Label>
                                                    </td>
                                                    </tr>
                                                    </table>
                                             </td></tr>
                                            </table>
                                        </td>
                                    </tr>
                        <tr>
                            <td align="center" colspan="3">
                                <asp:ImageButton ID="imgBtnPostAd" runat="server" 
                                    ImageUrl="~/admin/images/post.png" onclick="imgBtnPostAd_Click" 
                                    ValidationGroup="PostAd" />
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
