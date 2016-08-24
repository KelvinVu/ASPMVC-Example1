<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhKhoangCach2Diem.aspx.cs" Inherits="BaiTap.Bai03.TinhKhoangCach2Diem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TINH KHOANG CACH 2 DIEM</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Tính khoảng cách hai điểm</h2>
        <asp:Label ID="Label1" runat="server" Text="Điểm A: "></asp:Label>
        <asp:TextBox ID="txtDiemA" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Điểm B: "></asp:Label>
        <asp:TextBox ID="txtDiemB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Khoảng Cách: "></asp:Label>
        <asp:TextBox ID="txtKhoangCach" runat="server" Width="291px" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnGiai_Click" />
        <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
    </form>
</body>
</html>
