<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXArrayList.aspx.cs" Inherits="BaiTap.DemoCollections.EXArrayList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnAdd" Text="ADD-1" runat="server" OnClick="btnAdd_Click" />
        <asp:Button ID="btnAddRange" Text="ADDRANGE" runat="server" OnClick="btnAddRange_Click" />
        <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" />
        <asp:Button ID="btnRemove" Text="Remove" runat="server" OnClick="btnRemove_Click" />
        <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" />
        <asp:Button ID="btnDS" Text="Xuất DS" runat="server" OnClick="btnDS_Click" />
        <asp:Button ID="btnSort" Text="Sort DS" runat="server" OnClick="btnSort_Click" />
        <br />
        <asp:TextBox ID="txtKQ" TextMode="MultiLine" runat="server" />
    </div>
    </form>
</body>
</html>
