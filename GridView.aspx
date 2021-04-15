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
            <asp:GridView ID="gvBookinfo" runat="server" CssClass="table" AutoGenerateColumns="False" AllowPaging="True" HorizontalAlign="Center" OnPageIndexChanging="gvBookinfo_PageIndexChanging" OnSelectedIndexChanged="gvBookinfo_SelectedIndexChanged" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="bookcode" HeaderText="图形码" />
                    <asp:BoundField DataField="bookname" HeaderText="图书名称" />
                    <asp:BoundField DataField="price" DataFormatString="{0:F}" HeaderText="单价" />
                    <asp:HyperLinkField DataNavigateUrlFields="bookcode" DataNavigateUrlFormatString="~/HomeWork.aspx" HeaderText="操作" NavigateUrl="~/HomeWork.aspx" Text="修改" />
                </Columns>
            </asp:GridView>
<%--            <asp:Label ID="Label2" runat="server" Text='<%# DateTime.Now%>'></asp:Label><br />
            <asp:Label ID="Label1" runat="server" Text='<%# DataToString(DateTime.Now) %>'></asp:Label>--%>
        </div>
    </form>
</body>
</html>
