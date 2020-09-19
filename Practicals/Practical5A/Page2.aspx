<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Practical5A.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="Label1" runat="server" Text="This is a my second page"></asp:Label>
        <br />
       
        <asp:SiteMapPath ID="SiteMapPath2" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
         </asp:SiteMapPath>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/practical5A.aspx">home page</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Page1.aspx">page 1</asp:HyperLink>
    </div>
    
    </div>
    </form>
</body>
</html>
