<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TongHaiSo.aspx.cs" Inherits="BaiTap.Bai02.TongHaiSo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Tổng hai số</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            margin: 50px auto;
        }
        .auto-style2 {
            width: 30%;
            height: 19px;
        }
        .auto-style3 {
            height: 19px;
        }
        .tieude{
            font-size:1.2em;background-color:#ff6a00; font-weight:300 }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="txtSoA" defaultbutton="txtTinh">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="auto-style1 table table-bordered">
            <tr>
                <td colspan="2" class="info text-center">&nbsp;Tính tổng hai số</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;Số A</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSoA" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp; Số B</td>
                <td>
                    <asp:TextBox ID="txtSoB" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;Tổng</td>
                <td>
                    <asp:Textbox ID="txtTong" runat="server" Enabled="False" ViewStateMode="Disabled"></asp:Textbox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center" >
                    <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnTinh_Click" />
                    <asp:Button ID="btnLamLai" runat="server" Text="Làm Lại" OnClick="btnLamLai_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center" >
                    <asp:Label ID="lbLoi" runat="server" ViewStateMode="Disabled"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
