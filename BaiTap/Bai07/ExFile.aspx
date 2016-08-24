<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExFile.aspx.cs" Inherits="BaiTap.Bai07.ExFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDoc" runat="server" OnClick="btnDoc_Click" Text="Đọc " style="width: 41px" />
        <asp:Button ID="btnGhi" runat="server" OnClick="btnGhi_Click" style="width: 31px" Text="ghi" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="DocDong" runat="server" OnClick="Button1_Click" Text="Doc theo dong" />
        <br />
    
    </div>
    </form>
</body>
</html>
