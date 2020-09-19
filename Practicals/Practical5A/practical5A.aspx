<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="practical5A.aspx.cs" Inherits="Practical5A.practical5A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
        <br />
        <asp:Label ID="Label1" runat="server" Text="this is a siteMapPath control in asp.net"></asp:Label>
         <br />

        <asp:Label ID="Label2" runat="server" Text="sitemap"></asp:Label>
         <br />
        <asp:Label ID="Label3" runat="server" Text="Click any link to got to that page"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page1.aspx">page 1</asp:HyperLink>
         <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Page2.aspx">page 2</asp:HyperLink>
  
    
    </div>
    </form>
</body>
</html>
