<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_07_04.aspx.cs" Inherits="BaiTap.Bai07.Bai_07_04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đọc tập tin theo định dạng</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="4" cellspacing="0" border="1" bordercolor="#F04F26" style="width: 500px; border-collapse: collapse;">
            <tr>
                <td colspan="2" style="text-align: center; font-size: 16px; font-weight: bold; background-color:#F04F26; color: #ffffff; padding: 10px;">Đọc nội dung tập tin văn bản theo định dạng&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px; text-align: center">
                    <asp:Button ID="thDoctaptin" runat="server" Text="Đọc nội dung tập tin" OnClick="thDoctaptin_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="min-height: 26px;">
                    <asp:Label ID="thKetqua" runat="server"></asp:Label>&nbsp;
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
