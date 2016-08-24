<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXFile.aspx.cs" Inherits="BaiTap.Demo.EXFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtNoiDung" runat="server" TextMode="MultiLine"  />
        <br />
        <asp:Button ID="btnDoc" Text="Đọc" runat="server" OnClick="btnDoc_Click" />
        <asp:Button ID="btnGhi" Text="Ghi" runat="server" OnClick="btnGhi_Click" />
        <asp:Button ID="btnDocTheoDong" Text="Đọc Theo Dòng" runat="server" OnClick="btnDocTheoDong_Click" />
    </form>
</body>
</html>
