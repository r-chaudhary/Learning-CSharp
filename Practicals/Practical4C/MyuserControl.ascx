<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyuserControl.ascx.cs" Inherits="Practical4C.MyuserControl" %>
<h3>This is User Contro1 </h3>
<table>
<tr>
<td>Name</td>
<td>
 <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>City</td>
<td><asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
</tr> 
<tr>
<td></td>
<td>
 </td>
</tr>
<tr>
<td></td>

<td>
 <asp:Button ID="txtSave" runat="server" Text="Save" onclick="txtSave_Click" />
</td>
</tr>
</table><br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
