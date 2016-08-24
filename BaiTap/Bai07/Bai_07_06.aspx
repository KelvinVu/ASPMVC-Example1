<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_08_06.aspx.cs" Inherits="BaiTap.Bai07.Bai_07_06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>>Đọc - Ghi nội dung tập tin XML</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" cellpadding="4" cellspacing="0" border="1" bordercolor="#F04F26" style="width: 500px; border-collapse: collapse;">
            <tr>
                <td colspan="2" style="text-align: center; font-size: 16px; font-weight: bold; background-color:#F04F26; color: #ffffff; padding: 10px;">Hồ sơ học sinh</td>
            </tr>
            <tr>
                <td style="width: 100px;">Mã số (<span style="color: #f00">*</span>)</td>
                <td style="width: 400px;">
                    <asp:TextBox ID="txtMaSo" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Họ tên (<span style="color: #f00">*</span>)</td>
                <td>
                    <asp:TextBox ID="txtHoTen" runat="server" Width="90%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Điện thoại (<span style="color: #f00">*</span>)</td>
                <td>
                    <asp:TextBox ID="txtDienThoai" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; font-weight: bold;">Điểm thi</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center;">
                    Toán (<span style="color: #f00">*</span>): <asp:TextBox ID="txtDiemToan" runat="server" Width="100px"></asp:TextBox> &nbsp;&nbsp;&nbsp;
                    Văn (<span style="color: #f00">*</span>): <asp:TextBox ID="txtDiemVan" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px; text-align: center">
                    <asp:Button ID="btnGhiFile" runat="server" Text="Ghi nhận hồ sơ học sinh" OnClick="btnGhiFile_Click" Style="padding: 10px;" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px; text-align: center">
                    <asp:Button ID="btnDocFile" runat="server" Text="Đọc danh sách học sinh" OnClick="btnDocFile_Click" Style="padding: 10px;" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px; text-align: center; font-weight: bold;">
                    Danh sách học sinh đã nhập
                </td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px;">
                    <asp:Label ID="lblKetqua" runat="server">&nbsp;</asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
