<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredFieldValidator.aspx.cs" Inherits="demo1.RequiredFieldValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登入</title>
    <link href="App_Themes/theme1/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="用户名：" Width="90px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="输入用户名"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="密码：" Width="90px"></asp:Label>
            <asp:TextBox ID="txtPwd" runat="server" TabIndex="1" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPwd" runat="server" ControlToValidate="txtPwd" ErrorMessage="请输入密码"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="确认密码：" Width="90px"></asp:Label>
            <asp:TextBox ID="txtRePwd" runat="server" TabIndex="1" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPwd0" runat="server" ControlToValidate="txtPwd" ErrorMessage="请输入密码"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="e-mail:" Width="90px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TabIndex="2"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" TabIndex="3" Text="注册"  CssClass="btn-group-lg"/>
            <asp:CompareValidator ID="cvPwd" runat="server" ControlToCompare="txtRePwd" ControlToValidate="txtPwd" ErrorMessage="密码不一致"></asp:CompareValidator>
        </div>
    </form>
</body>
</html>
