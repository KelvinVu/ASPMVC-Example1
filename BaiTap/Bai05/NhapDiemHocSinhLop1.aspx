<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhapDiemHocSinhLop1.aspx.cs" Inherits="BaiTap.Bai05.NhapDiemHocSinhLop1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
 <form id="form1" runat="server">
        <div class="main-Content">
            <h2>Nhập Điểm_Học Sinh Lớp 1</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Lớp" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtLop" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Mã Số" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtMaSo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Họ Tên" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Toán" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtToan" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tiếng Việt" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtTiengViet" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Tập Viết" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtTapViet" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Điểm Trung Bình" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtDiemTrungBinh" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Kết Quả Học Tập" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtKetQuaHocTap" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Xếp Loại Khen Thưởng" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtXepLoaiKhenThuong" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="text-right" style="padding-right: 40px">
                <asp:Button ID="btnThucHien" runat="server" Text=" Thực Hiện " OnClick="btnTinh_Click" />
                <asp:Button ID="btnTiepTuc" runat="server" Text=" Tiếp Tục " OnClick="btnTiep_Click" />
            </div>
        </div>
    </form>
</body>
</html>
