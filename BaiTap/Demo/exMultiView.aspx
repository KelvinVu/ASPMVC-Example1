<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exMultiView.aspx.cs" Inherits="BaiTap.Demo.exMultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>DEMO - MULTIVIEW</h2>
        <asp:MultiView ID="mtv" runat="server" ActiveViewIndex="0" > 
            <asp:View ID="View1" runat="server">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/math_plus_blue-jelly.png" Height="200px" Width="300px"/>
                <asp:ImageButton ID="ImageButton1" runat="server" CommandName="NextView" ImageUrl="~/Images/prev.jpg" Width="24px" />
                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument="1" CommandName="SwitchViewByIndex">Prev</asp:LinkButton>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/math_plus_blue.png" Height="200px" Width="300px" />
                <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PrevView" ImageUrl="~/Images/next.jpg" Width="24px" />
                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument="0" CommandName="SwitchViewByIndex">Next</asp:LinkButton>
            </asp:View>


        </asp:MultiView>
    <div>
        <asp:Button ID="btn1" runat="server" Text="Next" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="Previous" OnClick="btn2_Click" />
        
    </div>        
    </form>
</body>
</html>
