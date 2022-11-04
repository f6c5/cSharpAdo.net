<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_4.aspx.cs" Inherits="venus_web.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td width="250">Fotoğraf</td>
                            <td width="250">Ürün</td>
                            <td width="250">Fiyat</td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table style="border-bottom-style:inset">
                        <tr>
                            <td width="250"><asp:Image ImageUrl='<%# "urunler/" + Eval("Resim")%>' runat="server" Height="150" ToolTip='<%# Eval("Adi") %>' /></td>
                            <td width="250"><asp:Label ID="lblurunadi" runat="server" Text='<%# Eval("Adi") %>'></asp:Label></td>
                            <td width="250"><asp:Label ID="lblfiyat" runat="server" Text='<%# Eval("Fiyat") %>'></asp:Label></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_eticaretConnectionString %>" SelectCommand="SELECT [UrunID], [Adi], [Fiyat], [Resim] FROM [urunler]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
