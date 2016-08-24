<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinMayTinh.aspx.cs" Inherits="BaiTap.Bai04.ThongTinMayTinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông Tin Máy Tính</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="main-Content">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            
            <h2>Nhập thông tin Máy Tính</h2>
            <div class="form-group">
               
                <asp:Label ID="lblMaso" runat="server" Text="Số Hiệu" CssClass="col-left control-label"></asp:Label>
               
                <div class="col-right">
                    <asp:TextBox ID="txtSoHieu" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                
                <asp:Label ID="lblHoTen" runat="server" Text="Đơn GIá " CssClass="col-left control-label"></asp:Label>
               
                <div class="col-right">
                    <asp:TextBox ID="txtDonGia" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="form-group">
                <asp:Label ID="lblNgaySinh" runat="server" Text="Hãng Sản Xuất" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtHangSanXuat" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLoaiNhanVien" runat="server" Text="Loại Máy Tính" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    
                    <asp:RadioButton ID="rdbMTDB" runat="server" GroupName="LoaiMayTinh" Text="Máy Tính Để Bàn" Checked="True" AutoPostBack="True" />
                    &nbsp;<asp:RadioButton ID="rdbMTXT" runat="server" GroupName="LoaiMayTinh" Text="Máy Tính Xách Tay" AutoPostBack="True" />
                    
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label0" runat="server" Text="CPU" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtCPU" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                        <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="RAM" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtRAM" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                        <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Trọng Lượng" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtTrongLuong" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                                    <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Thời Gian Pin" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtThoiGianPin" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                                    <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Kích Thước Màn Hình" CssClass="col-left control-label"></asp:Label>
                <div class="col-right">
                    <asp:TextBox ID="txtKichThuocManHinh" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="text-right" style="padding-right:40px">
                   <asp:Button ID="btnXuatThongTin" runat="server" Text="Xuất thông tin" OnClick="btnXuatThongTin_Click" /> &nbsp;
             </div>
                                                <div class="form-group">
                <h2>Danh Sách Máy Tính</h2>
                <div class="col-right">
                    <asp:TextBox ID="txtXuatThongTin" runat="server" CssClass="form-control" Height="117px" TextMode="MultiLine" Width="166%"></asp:TextBox>
                </div>
        
        </asp:View>
        </asp:MultiView>
              </div>
    </form>
</body>
</html>
