<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXMenu.aspx.cs" Inherits="BaiTap.Demo.EXMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>thiết kế menu</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
    
                <nav class="navbar navbar-inverse navbar-static-top">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#main-menu">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a href="#">Menu1</a>
                    </div>
                    <div class="navbar-collapse">
                          <ul class="nav navbar-nav">
                                <li><a href="Menu1">Home</a></li>
                                <li><a href="Menu1">About</a></li>
                                <li><a href="Menu1">Contact</a></li>
                         </ul>
                    </div>
                </nav>
            
        </div>
        <div id="content">

        </div>
        <div id="footer">

        </div>
    </form>
</body>
</html>
