<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeWork.aspx.cs" Inherits="demo1.HomeWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 756px;
            height: 45px;
        }
        .auto-style2 {
            height: 24px;
        }
        .auto-style3 {
            width: 108px;
        }
        .auto-style4 {
            height: 24px;
            width: 108px;
        }
    </style>
    <link href="App_Themes/theme1/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="App_Themes/theme1/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1" src="img/tianjiaxiugaitushuxinxi.gif" /><br />
            <table>
                <tr>
                    <td class="auto-style3">条形码：</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">图书名称：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td class="auto-style4">图书类型：</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="188px">
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">作者：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">译者：</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">出版社：</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">价格：</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">页码：</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">书架：</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="188px">
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">库存数量：</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">入馆时间：</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server" TextMode="Date"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">操作员</td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3" colspan="2" rowspan="1">
                        <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="Button3_Click" CssClass="btn-group-justified"/>
                        <asp:Button ID="btnChange" runat="server" Text="修改" CssClass="btn-toolbar"/>
                        <asp:Button ID="Button5" runat="server" Text="取消" CssClass="btn-sm"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
