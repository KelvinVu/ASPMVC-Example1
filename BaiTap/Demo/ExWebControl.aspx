<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExWebControl.aspx.cs" Inherits="BaiTap.Demo.ExWebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DEMO</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>DEMOOOOOOOOOOOOO</h2>
        <p>Nội dung <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>
        <p><asp:Label ID="lbThongBao" runat="server"></asp:Label></p>
        <asp:ImageButton ID="imb" runat="server" Height="37px" ImageUrl="~/Images/math_minus_blue.png" Width="39px" ToolTip="xứ lý" />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
    </form>
</body>
</html>
