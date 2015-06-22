<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VideoNew.aspx.cs" Inherits="VideoNew" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">   
<object type="video/x-ms-wmv" data="<%=swfFileName%>" width="420" height="340">   
   <param name="url" value="<%=swfFileName%>"/>
   <param name="src" value="<%=swfFileName%>" />
   <param name="autostart" value="false" />
   <param name="sound" value="false" />
   <param name="controller" value="true" />
   <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
  </embed>
</object>
<%=swfFileName%>
    </form>
</body>
</html>
