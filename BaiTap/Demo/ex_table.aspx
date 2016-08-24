<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ex_table.aspx.cs" Inherits="BaiTap.Demo.ex_table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 600px;
        }
    </style>
</head>
<body>
    <div style="text-align: center">
    <form id="form1" runat="server" style="text-align: center">
    
        <table cellpadding="3" cellspacing="0" class="autoStyle" style="border-style: dashed">
            <tr>
                <td colspan="2" style="text-align: center">&nbsp;đăng ký thông tin học viên&nbsp;</td>
            </tr>
            <tr>
                <td style="width:30%">họ và tên</td>
                <td>
                    <asp:TextBox ID="txtHoTen" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>lớp</td>
                <td>
                    <asp:TextBox ID="txtLop" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnDangKy" runat="server" Text="đăng ký" OnClick="btnDangKy_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="lbDangKyThanhCong" runat="server" ForeColor="#33CC33"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
           </div>
</body>
</html>
