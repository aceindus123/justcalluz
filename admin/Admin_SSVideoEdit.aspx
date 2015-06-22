<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SSVideoEdit.aspx.cs" Inherits="admin_Admin_SSVideoEdit" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_SSHeader.ascx" TagName="SSHeader" TagPrefix="SS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Success Stories Videos Post</title>
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
        .stylealign
        {
           align:center
        }        
        </style>
      <script language="javascript" type="text/javascript">

          function confirm_delete(uid) {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  document.location = 'Admin_DeleteAd.aspx?cid=' + uid;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected Ad has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected Ad has been Accepted");
          }
    </script>	
    <script type="text/javascript" language="javascript">
        function OnContactSelected(source, eventArgs) {

            var hdnValueID = "<%= hdnValue.ClientID %>";

            document.getElementById(hdnValueID).value = eventArgs.get_value();
            __doPostBack(hdnValueID, "");
        } 
    </script>
    <script type = "text/javascript">
    function SetContextKey() {

        $find('<%=autoselectCompany.ClientID%>').set_contextKey($get("<%=ddlCity.ClientID %>").value);
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
         <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/success_videos.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td>                      
                      <SS:SSHeader id="SSHead1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <a  target="_blank" href="http://www.justcalluz.com/success_stories.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                               <%-- <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>     
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Update Success Stories (partner says about justcalluz)</span> 
                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_SuccessStories.aspx?Type=SSText&s=Andhra Pradesh&c=Hyderabad" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>
                        </tr>                          
                        <tr><td height="20px"></td></tr>                                              
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           State
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:DropDownList ID="ddlState" runat="server" 
                                                onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true" Width="200px">
                                            </asp:DropDownList>
                                             <asp:RequiredFieldValidator ID="rfddlState" runat="server" 
                                                ErrorMessage="Please Select State" ControlToValidate="ddlState" 
                                                InitialValue="Select State" ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr> 
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           City
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:DropDownList ID="ddlCity" runat="server" Width="200px">
                                            </asp:DropDownList>
                                             <asp:RequiredFieldValidator ID="rfvddlCity" runat="server" 
                                                ErrorMessage="Please Select City" ControlToValidate="ddlCity" 
                                                InitialValue="Select City" ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr>
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           Company Name
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:hiddenfield id="hdnValue" onvaluechanged="hdnValue_ValueChanged" runat="server"/>
                                            <asp:TextBox ID="txtCompanyName" runat="server" AutoComplete="off" onkeyup = "SetContextKey()"  
                                                Width="270px" ontextchanged="txtCompanyName_TextChanged" AutoPostBack="true"></asp:TextBox>                                            
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wecName" runat="server" TargetControlID="txtCompanyName" WatermarkCssClass="water" WatermarkText="Enter Company Name"></AjaxToolkit:TextBoxWatermarkExtender>
                                            <AjaxToolkit:AutoCompleteExtender ID="autoselectCompany" runat="server" TargetControlID="txtCompanyName" MinimumPrefixLength="0" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="GetCompanyNames" ShowOnlyCurrentWordInCompletionListItem="false" OnClientItemSelected="OnContactSelected" UseContextKey="true">
                                            </AjaxToolkit:AutoCompleteExtender>
                                            <asp:RequiredFieldValidator ID="rfvCompName" runat="server" 
                                                ErrorMessage="Please enter company name" 
                                                ControlToValidate="txtCompanyName" ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr> 
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           Category
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:TextBox ID="txtCat" runat="server" Width="270px" Enabled="false"></asp:TextBox>                                            
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr>                                     
                                    <tr>
                                        <td colspan="3" height="1px">
                                            <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                                            <asp:Label ID="lblImageUploadStatus" runat="server" Visible="false"></asp:Label>                                                    
                                                    <asp:Label ID="lblVedioAudioUploadStatus" runat="server" Visible="false"></asp:Label>
                                        </td>
                                    </tr> 
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           Customer since
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:TextBox ID="txtMonth" runat="server" Width="100px" Enabled="false"></asp:TextBox>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="txtYear" runat="server" Width="100px" Enabled="false"></asp:TextBox>                                            
                                            <AjaxToolkit:TextBoxWatermarkExtender ID="wetxtYear" runat="server" TargetControlID="txtYear" WatermarkCssClass="water" WatermarkText="Enter year"></AjaxToolkit:TextBoxWatermarkExtender> 
                                            <asp:RequiredFieldValidator ID="rfvMonth" runat="server" 
                                                ErrorMessage="Please enter month" ControlToValidate="txtMonth" 
                                                ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>&nbsp;
                                            <asp:RequiredFieldValidator ID="rfvYear" runat="server" 
                                                ErrorMessage="Please enter year" ControlToValidate="txtYear" 
                                                ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr>     
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           Partner Name
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:TextBox ID="txtPName" runat="server" Width="270px" onkeypress="return Alphabets(event);"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvPName" runat="server" 
                                                ErrorMessage="Please enter partner's name" ControlToValidate="txtPName" 
                                                ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr> 
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                           Partner Designation
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:TextBox ID="txtPDesg" runat="server" Width="270px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvPDesg" runat="server" 
                                                ErrorMessage="Please enter partner's designation" 
                                                ControlToValidate="txtPDesg" ValidationGroup="UpdateSSVideo">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="1px"></td></tr>                                    
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                          Partner's Photo
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:FileUpload ID="ImgUpload" runat="server"/>
                                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="ImgUpload" ErrorMessage="Please upload Partner's photo" 
                                                ValidationGroup="UpdateSSVideo"></asp:RequiredFieldValidator>--%>
                                                <asp:CustomValidator ID="CVImgUpload" runat="server" 
                                                    ErrorMessage="CV" ControlToValidate="ImgUpload" ValidateEmptyText="true" Display="Dynamic" 
                                                    onservervalidate="CVImgUpload_ServerValidate" ValidationGroup="UpdateSSVideo"></asp:CustomValidator>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <asp:Image ID="Photo" runat="server" Width="100px" Height="100px"/><br />
                                            <asp:Label ID="imgName" runat="server"></asp:Label>
                                            <asp:Label ID="imgContentType" runat="server" Visible="false"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr class="adminform">
                                        <td width="33%" align="right">
                                          Partner's Speak Video
                                        </td>
                                        <td align="center" width="2%">:</td>
                                        <td align="left" width="65%">
                                            <asp:FileUpload ID="VideoUpload" runat="server" />
                                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="VideoUpload" ErrorMessage="Please upload Partner's Speak Video" 
                                                ValidationGroup="UpdateSSVideoVideo"></asp:RequiredFieldValidator>--%>
                                                <asp:CustomValidator ID="CVVideoUpload" runat="server" ErrorMessage="CV" ValidateEmptyText="true" 
                                                    ControlToValidate="VideoUpload" Display="Dynamic" 
                                                    onservervalidate="CVVideoUpload_ServerValidate" ValidationGroup="UpdateSSVideo"></asp:CustomValidator>                                                    
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <object type="video/x-ms-wmv" data="<%=swfFileName%>" width="320" height="320">
                                               <param name="url" value="<%=swfFileName%>"/>
                                               <param name="src" value="<%=swfFileName%>" />
                                               <param name="autostart" value="false" />
                                               <param name="sound" value="false" />
                                               <param name="controller" value="true" />
                                               <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
                                              </embed>
                                            </object>
                                            <br />
                                            <asp:Label ID="video_Name" runat="server"></asp:Label>
                                            <asp:Label ID="vContentType" runat="server" Visible="false"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <asp:ImageButton ID="imgBtnUpdateSSVideo" runat="server" 
                                                ImageUrl="~/admin/images/update.png" 
                                                ValidationGroup="UpdateSSVideo" onclick="imgBtnUpdateSSVideo_Click" />
                                                 &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>
                                <asp:ValidationSummary ID="validsumms" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="UpdateSSVideo" />
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
    </div>
    </center>
    </form>
</body>
</html>
