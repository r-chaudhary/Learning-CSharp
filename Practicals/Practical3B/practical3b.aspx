<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="practical3b.aspx.cs" Inherits="Practical3B.practical3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC"
    BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest"
    Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px"
    NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender"
    ShowGridLines="True" Width="300px"
    OnSelectionChanged="Calendar1_SelectionChanged" >
        <NextPrevStyle BorderStyle="Solid" BorderWidth="2px" Font-Size="9pt" ForeColor="#FFFFCC" />
        <OtherMonthDayStyle BackColor="#FFCC99" BorderStyle="Solid" ForeColor="#CC9966" />
        <SelectedDayStyle BackColor="Red" Font-Bold="True" />
        <SelectorStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <WeekendDayStyle Height="50px" />
 </asp:Calendar><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>        <asp:Button ID="btnResult" runat="server" Text="submit"  />        <asp:Button ID="btnReset"  runat="server" Text="reset" />
    </div>
    </form>
</body>
</html>
