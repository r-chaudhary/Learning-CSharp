<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practiacal4C.aspx.cs" Inherits="Practical4C.Practiacal4C" %>
<%@register Src="~/MyuserControl.ascx" TagPrefix="jpl" TagName="Student" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <jpl:Student Id="studentcontrol" runat="server" />
    </div>
    </form>
</body>
</html>
