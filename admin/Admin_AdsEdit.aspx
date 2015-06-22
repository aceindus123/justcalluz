<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_AdsEdit.aspx.cs" Inherits="admin_Admin_AdsEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_AdsHeader.ascx" TagName="AdsHeader" TagPrefix="Ads" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update Ads</title>
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
        <script type="text/javascript" src="js/tab.js"></script>

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
     
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
     </asp:ScriptManager>
     
        <table cellpadding="0" cellspacing="0" >
         <tr>
            <td >
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td >                  
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td>                      
                       <Ads:AdsHeader ID="ads1" runat="server" />
                    </td>
                    </tr> 
                    <tr>
                            <td colspan="2" align="right">
                             <a href="http://www.justcalluz.com/tv_ads.aspx" target="_blank"><img src="images/Click Here For SiteView.png" alt="siteview"/></a> 
                                
                            </td>
                        </tr>    
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">
                          <asp:Label ID="lblTitle" runat="server"></asp:Label></span> 
                        </td>
                      </tr>                     
                         <tr><td><table width="100%"> 
                         <asp:Panel style="width:100%;" id="pnlAdsInfo" runat="server">                                      
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                        <td align="right" colspan="2" style="padding-right:5px;">
                               <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_Ads.aspx"></asp:LinkButton>                              
                            </td>
                        </tr>                        
                        <tr>
                            <td>
                                <table width="100%">
                                    <tr>
                                        <td>
                                            <table width="100%">
                                                <tr class="adminform">
                                                    <td width="40%" align="right">
                                                       Type of the Ad
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlAdType" runat="server" Width="200px" Enabled="false" 
                                                            AutoPostBack="true" onselectedindexchanged="ddlAdType_SelectedIndexChanged" >
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvddlAdType" runat="server" 
                                                            ControlToValidate="ddlAdType" ErrorMessage="Please select Type of the Ad" 
                                                            InitialValue="Select Ad Type" ValidationGroup="UpdateAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trSubType" runat="server" visible="false">
                                                    <td colspan="2">                                                        
                                                    </td>                                                    
                                                    <td align="left" width="50%">
                                                       <asp:DropDownList ID="ddlAdSubType" runat="server" Width="200px" Enabled="false">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvddlAdSubType" runat="server" 
                                                            ControlToValidate="ddlAdSubType" 
                                                            ErrorMessage="Please Select" InitialValue="Select" 
                                                            ValidationGroup="UpdateAd"></asp:RequiredFieldValidator> 
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trLanguage" runat="server" visible="false">
                                                    <td width="40%" align="right">
                                                       Language
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:DropDownList ID="ddlLanguage" runat="server" Width="200px" Enabled="false">
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="rfvLang" runat="server" 
                                                            ControlToValidate="ddlLanguage" 
                                                            ErrorMessage="Please Select Language" InitialValue="Select Language" 
                                                            ValidationGroup="UpdateAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trCity" runat="server" visible="false">
                                                    <td align="right" width="40%">
                                                    City                                                        
                                                    </td>
                                                    <td align="center" width="5%">:</td>                                                    
                                                    <td align="left" width="50%"> 
                                                        <asp:DropDownList ID="ddlCity" runat="server" Width="200px" Enabled="false">
                                                        </asp:DropDownList>
                                                         <asp:RequiredFieldValidator ID="rfvddlCity" runat="server" 
                                                            ControlToValidate="ddlCity" 
                                                            ErrorMessage="Please Select City" InitialValue="Select City" 
                                                            ValidationGroup="UpdateAd"></asp:RequiredFieldValidator> 
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trPaper" runat="server">
                                                    <td align="right" width="40%">
                                                    Name of the Paper                                                        
                                                    </td>
                                                    <td align="center" width="5%">:</td>                                                    
                                                    <td align="left" width="50%">
                                                        <asp:TextBox ID="txtPaper" runat="server" Width="200px" ></asp:TextBox>                                                    
                                                        <asp:RequiredFieldValidator ID="rfvPaper" runat="server" 
                                                            ControlToValidate="txtPaper" 
                                                            ErrorMessage="Please enter News Paper name" 
                                                            ValidationGroup="PostAd"></asp:RequiredFieldValidator>                                                             
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
                                                        <asp:TextBox ID="txtTitle" runat="server" Width="200px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                                            ErrorMessage="Please Enter Title to Display"
                                                            ControlToValidate="txtTitle" ValidationGroup="UpdateAd"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trThumbnail" runat="server" visible="false">
                                                    <td width="40%" align="right">
                                                        Thumbnail Upload
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:FileUpload ID="ImageUpload" runat="server" />
                                                         <br /> 
                                                        <asp:CustomValidator ID="CVImgUpload" runat="server" 
                                                            ErrorMessage="CustomValidator" ControlToValidate="ImageUpload" ValidateEmptyText="true" Display="Dynamic" 
                                                            onservervalidate="CVImgUpload_ServerValidate" ValidationGroup="UpdateAd"></asp:CustomValidator>                                                          
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="1px"></td></tr>
                                                 <tr class="adminform" id="trImgThumbnail" runat="server" visible="false">                                                                                
                                                    <td align="center" colspan="3">
                                                        <asp:Image ID="imgThumbnail" runat="server" Height="250px" Width="300px"/>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="3px">
                                                    <asp:Label ID="lblAdSubType1" runat="server" Visible="false"></asp:Label></td></tr>
                                                <tr class="adminform" id="trUpload" runat="server">
                                                    <td width="40%" align="right">
                                                        <asp:Label ID="lblUpload" runat="server"></asp:Label> Upload
                                                    </td>
                                                    <td align="center" width="5%">:</td>
                                                    <td align="left" width="55%">
                                                        <asp:FileUpload ID="MediaAudioPrintAdUpload" runat="server" />                                                        
                                                        <asp:CustomValidator ID="CVFile" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true" 
                                                            ControlToValidate="MediaAudioPrintAdUpload" Display="Dynamic" 
                                                            onservervalidate="CVFile_ServerValidate" ValidationGroup="UpdateAd"></asp:CustomValidator>
                                                    </td>
                                                </tr>
                                                 <tr><td colspan="3" height="1px"></td></tr>
                                                <tr class="adminform" id="trVideoAudioDisplay" runat="server" visible="false">                                                                                                       
                                                    <td align="center" colspan="3">
                                                        <object type="video/x-ms-wmv" data="<%=swfFileName%>" width="420" height="340">
                                                           <param name="url" value="<%=swfFileName%>"/>
                                                           <param name="src" value="<%=swfFileName%>" />
                                                           <param name="autostart" value="false" />
                                                           <param name="sound" value="false" />
                                                           <param name="controller" value="true" />
                                                           <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
                                                          </embed>
                                                        </object>
                                                    </td>
                                                </tr>
                                                <tr class="adminform" id="trImg" runat="server" visible="false">                                                                                
                                                    <td align="center" colspan="3">
                                                        <asp:Image ID="img" runat="server"/>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="3" height="2px">
                                                    <asp:Label ID="lblImageUploadStatus" runat="server" Visible="false"></asp:Label>
                                                    <asp:Label ID="lblVedioAudioUploadStatus" runat="server" Visible="false"></asp:Label>                                                    
                                                    <asp:Label ID="lblFileName" runat="server" Visible="false"></asp:Label> 
                                                    <asp:Label ID="lblFileNameContent" runat="server" Visible="false"></asp:Label>                                                    
                                                    <asp:Label ID="lblThumblineName" runat="server" Visible="false"></asp:Label> 
                                                    <asp:Label ID="lblThumbContent" runat="server" Visible="false"></asp:Label>
                                                    </td></tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:Button ID="imgBtnUpdateAd" runat="server" Text="Submit"
                                                onclick="imgBtnUpdateAd_Click" 
                                                ValidationGroup="UpdateAd" style="border-radius:1px solid black;" Height="30px"/>
                                                &nbsp; &nbsp;
                                <asp:Button ID="imbBtnCancel" runat="server" 
                                onclick="imbBtnCancel_Click" Height="30px" Text="Cancel" style="border-radius:1px solid black;" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr> 
                       </asp:Panel>
                        </table></td></tr>                                                                                                    
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
