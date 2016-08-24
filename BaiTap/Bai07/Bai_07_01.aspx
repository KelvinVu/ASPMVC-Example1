<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_07_01.aspx.cs" Inherits="BaiTap.Bai07.Bai_07_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload tập tin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 50px auto;">
    
        <table align="center" cellpadding="4" cellspacing="0" border="1" bordercolor="#F04F26" style="width: 500px; border-collapse: collapse;">
            <tr>
                <td style="text-align: center; font-size: 16px; font-weight: bold; background-color:#F04F26; color: #ffffff; padding: 10px;">Upload Files</td>
            </tr>
            <tr>
                <td style="text-align: center">Chọn tập tin cần upload: 
                    <asp:FileUpload ID="thTapTin" runat="server" AllowMultiple="True" />
                </td>
            </tr>
            <tr>
                <td style="min-height: 26px; text-align: center;">&nbsp;
                    <asp:Button ID="btnDoc" runat="server" Text="Upload lên host" OnClick="btnDoc_Click" />
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
