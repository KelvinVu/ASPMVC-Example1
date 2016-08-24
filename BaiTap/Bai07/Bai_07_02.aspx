<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_07_02.aspx.cs" Inherits="BaiTap.Bai07.Bai_07_02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đếm số dòng trong tập tin</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="4" cellspacing="0" border="1" bordercolor="#F04F26" style="width: 500px; border-collapse: collapse;">
            <tr>
                <td style="text-align: center; font-size: 16px; font-weight: bold; background-color:#F04F26; color: #ffffff; padding: 10px;">Đếm số dòng trong tập tin văn bản&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">Chọn tập tin : 
                    <asp:FileUpload ID="thTapTin" runat="server" AllowMultiple="True" />
                </td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="thDoctaptin" runat="server" Text="Upload và Đọc tập tin" OnClick="thDoctaptin_Click" />
                </td>
            </tr>
            <tr>
                <td style="min-height: 26px;">&nbsp;
                    <asp:Label ID="thKetqua" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
