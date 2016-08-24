<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExHtmlCtr_Server.aspx.cs" Inherits="BaiTap.Demo.ExHtmlCtr_Server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            margin: 50px auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table cellpadding="0" cellspacing="0" class="auto-style1 table table-bordered">
            <tr class="info text-center">
                <td colspan="2">Demo HTML ConTrol-Client</td>
            </tr>
            <tr>
                <td style="width:30%">Họ Tên</td>
                <td>
                    
                    <input id="txtHoTen" type="text" runat="server" /></td>
            </tr>
            <tr>
                <td>Ngày Sinh</td>
                <td>
                   
                    <input id="txtNgaySinh" type="text" runat="server" /></td>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    
                    <input id="btnThucHien" type="button" value="Thực Hiện" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2">
    <div id="divKetQua" class="text-danger text-center" runat="server">sdfsdfsdf
    </div>

                </td>
            </tr>
        </table>
    
    </div>
    </form>
    </body>
</html>
