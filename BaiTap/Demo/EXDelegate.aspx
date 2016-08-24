<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXDelegate.aspx.cs" Inherits="BaiTap.Demo.EXDelegate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chọn Phép Tính:
            <asp:RadioButton ID="rbTong" Text="Tổng" GroupName="Phép Tính" runat="server" />
            <asp:RadioButton ID="rbTich" Text="Tích" GroupName="Phép Tính" runat="server" />
        </div>
        <asp:Button ID="btnTinh" Text="Tính" runat="server" OnClick="btnTinh_Click" />
        <asp:Label ID="lbKetQua" runat="server" />
    </form>
</body>
</html>
