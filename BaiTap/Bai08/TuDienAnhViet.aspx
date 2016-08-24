<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TuDienAnhViet.aspx.cs" Inherits="BaiTap.Bai08.TuDienAnhViet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tự điển</title>
    <link href="../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="main-ContentGreen" >
    <h2>Từ điển Anh-Việt</h2>
                <div class="form-group">

                    <asp:Label ID="Label1" runat="server" Text="Từ Tiếng Anh" CssClass="col-left control-label"></asp:Label>

                    <div class="col-right">
                        <asp:TextBox ID="txtTuTienAnh" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">

                    <asp:Label ID="Label2" runat="server" Text="Nghĩa Tiếng Việt" CssClass="col-left control-label"></asp:Label>

                    <div class="col-right">
                        <asp:TextBox ID="txtNghiaTiengViet" runat="server" CssClass="form-control" Height="140px" ReadOnly="True" Rows="4" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                </div>
            <div class="text-right" style="padding-right:50px">
                    <br />
                    <asp:Button ID="btnThucHien" runat="server" Text="Thực hiện" OnClick="btnThucHien_Click" CssClass="control-button"  />
                    <asp:Button ID="btnTiepTuc" runat="server" Text="Tiếp tục" OnClick="btnTiepTuc_Click" CssClass="control-button"  />
                    &nbsp;
                </div>
    </div>
    </form>
</body>
</html>
