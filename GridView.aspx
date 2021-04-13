<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="demo1.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="App_Themes/theme1/css/bootstrap.min.css" rel="stylesheet" />
    <link href="App_Themes/theme1/css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="App_Themes/theme1/css/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvBookinfo" runat="server" CssClass="table">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
