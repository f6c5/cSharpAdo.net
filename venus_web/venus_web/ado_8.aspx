<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_8.aspx.cs" Inherits="venus_web.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>ID</td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>PhoneTypeID</td>
                    <td>:</td>
                    <td><asp:DropDownList ID="ddlPTypeID" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>PhoneNumber</td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Date</td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMesaj" runat="server"></asp:Label>
                    </td>
                    <td></td>
                    <td><asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
