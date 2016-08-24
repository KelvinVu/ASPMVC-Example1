<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangKhachHang.aspx.cs" Inherits="BaiTap.Bai02.TrangKhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Ký Khách Hàng</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 400px;
            margin: 50px auto;
            border-color:#ff6a00;
            border-style:dashed;
            font-weight:600;

        }
        .tieude{
            font-size:1.5em;
            background-color:#ff6a00;
            font-weight:bold;
            text-align:center;   
            color:white;
            padding:10px;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">

                <table cellpadding="3" cellspacing="3" class="auto-style1">
            <tr>
                <td colspan="2" class="tieude">THÔNG TIN ĐĂNG NHẬP</td>
            </tr>
            <tr>
                <td style="width:30%">Tên Đăng Nhập:</td>
                <td>
                    <asp:TextBox ID="txtDangNhap" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Mật Khẩu</td>
                <td>
                    <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="50%" MaxLength="20"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="tieude">THÔNG TIN CÁ NHÂN</td>
            </tr>
            <tr>
                <td>Họ Và Tên</td>
                <td>
                    <asp:TextBox ID="txtHoTen" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Giới Tính</td>
                <td>
                    <asp:RadioButton ID="rbtNam" runat="server" Text=" Nam" GroupName="GioiTinh" Checked="true" />
                    <asp:RadioButton ID="rbtNu" runat="server" Text="Nữ" GroupName="GioiTinh" />
                </td>
            </tr>
            <tr>
                <td>Ngày Sinh</td>
                <td>
                    <asp:DropDownList ID="ddlNgay" runat="server" Width="20%">
                    </asp:DropDownList>
&nbsp;/
                    <asp:DropDownList ID="ddlThang" runat="server" Width="20%">
                    </asp:DropDownList>
&nbsp;/
                    <asp:DropDownList ID="ddlNam" runat="server" Width="20%">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Sở Thích</td>
                <td>
                    <asp:Panel ID="panelSoThich" runat="server">

                    <asp:CheckBox ID="ckbAmNhac" runat="server" Text="Âm Nhạc" />
                    <asp:CheckBox ID="ckbPhim" runat="server" Text="Phim" />
                    <asp:CheckBox ID="ckbGame" runat="server" Text="Game"/>
                    <asp:CheckBox ID="ckbDocBao" runat="server" Text="Đọc Báo"/>
                    <asp:CheckBox ID="ckbRadio" runat="server" Text="Radio"/>
                    <asp:CheckBox ID="ckbTivi" runat="server" Text="Tivi"/>

                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập" OnClick="btnDangNhap_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                </td>
            </tr>
        </table>

            </asp:View>

            <asp:View ID="View2" runat="server" >
                <div style="text-align:center" >
                    <asp:Label ID="lbThongBao" runat="server" ForeColor="Blue" CssClass="text-center"></asp:Label>
                </div>
            </asp:View>
        </asp:MultiView>
       
    </form>
</body>
</html>
