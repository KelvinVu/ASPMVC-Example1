<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiaiPhuonnTrinhBac1.aspx.cs" Inherits="BaiTap.Bai03.GiaiPhuonnTrinhBac1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2><u>GIẢI PHƯƠNG TRÌNH BẬC 1</u></h2><br />
        <asp:Label ID="Label1" runat="server" Text="Hệ Số A: "></asp:Label>
        <asp:TextBox ID="txtSoA" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Hệ Số B: "></asp:Label>
        <asp:TextBox ID="txtSoB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kết Quả: "></asp:Label>
        <asp:TextBox ID="txtKetQua" runat="server" Width="291px" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Button ID="btnGiai" runat="server" Text="Giải" OnClick="btnGiai_Click" />
        <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />


    </form>
</body>
</html>
