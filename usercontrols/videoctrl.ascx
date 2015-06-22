<%@ Control Language="C#" AutoEventWireup="true" CodeFile="videoctrl.ascx.cs" Inherits="usercontrols_videoctrl" %>

<%--<asp:literal id="Literal1" runat="server"></asp:literal>--%> 
<object type="video/x-ms-wmv" data="<%=swfFileName%>" width="200" height="250">
   <param name="url" value="<%=swfFileName%>"/>
   <param name="src" value="<%=swfFileName%>" />
   <param name="autostart" value="true" />
   <param name="sound" value="false" />
   <param name="controller" value="true" />
   <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='200' height='250' designtimesp='5311' loop='false' >
  </embed>
</object>
<br /> 
    
 
 