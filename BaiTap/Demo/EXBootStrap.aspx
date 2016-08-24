<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXBootStrap.aspx.cs" Inherits="BaiTap.Demo.EXBootStrap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Khóa học bootstrap 3</title>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body >
    <form id="form1" runat="server">
        <p>thẻ  chỉ từng đoạn khác nhau</p>
        <a href="http://cumeotv.net" target="_blank">CuMeoTV.NET</a>
        <img src="../Photos/Northern_lights1.jpg" width="50" height="50"/>
        <ul>
            <li>List1</li>
            <li>List1</li>
            <li>List1</li>
        </ul>

        <ol>
            <li>List1</li>
            <li>List1</li>
            <li>List1</li>
        </ol>

        <div id="header" class="textcolor">
            <h1>header</h1>

        </div> <%--end header--%>

        <div id="content">
            <p>Content</p>
            <div class="container">
                <div class="row show-grid">
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="col-md-1">
                        <p>1</p>
                    </div>
                    <div class="row show-grid"></div>
                        <div class="col-md-3 col-xs-12">
                            <p>LEFT</p>
                        </div>
                        <div class="col-md-7 col-xs-12">
                            <p>RIGHT</p>
                        </div>
                        <div class="col-md-2 col-xs-12">
                            <p>RIGHT</p>
                        </div>
                    </div>
                </div>
            </div>
        </div> <%--end content--%>

        <div id="footer">
            <p>footer</p>
        </div> <%--end footer--%>

    </form>
</body>
</html>
