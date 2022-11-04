<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_3.aspx.cs" Inherits="venus_web.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:DataList ID="DataList1"  align="center" runat="server" CellPadding="4" DataKeyField="personelID" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="686px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" CaptionAlign="Left">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                PERSONEL LİSTESİ
            </HeaderTemplate>
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                &nbsp;<table style="width: 89%; height: 209px;">
                    <tr>
                        <td class="auto-style1" rowspan="11">
                            <img alt="" src="resimler/<%# Eval("Resim") %>" width="150" />
                            <strong>No</strong>:
                            <asp:Label ID="personelIDLabel" runat="server" Text='<%# Eval("personelID") %>' />
                        </td>
                        <td class="auto-style2"><strong>Tc Kimlik</strong>&nbsp; </td>
                        <td>
                            <asp:Label ID="TCKIMLIKNOLabel" runat="server" Text='<%# Eval("TC") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>Adı</strong></td>
                        <td>
                            <asp:Label ID="ADILabel" runat="server" Text='<%# Eval("Adi") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>Soyadı</strong> </td>
                        <td>
                            <asp:Label ID="SOYADILabel" runat="server" Text='<%# Eval("Soyadi") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>Telefon</strong> </td>
                        <td>
                            <asp:Label ID="TELEFONLabel" runat="server" Text='<%# Eval("Telefon") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>Maaş</strong></td>
                        <td>
                            <asp:Label ID="MAASLabel" runat="server" Text='<%# Eval("Maas") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>E-posta</strong></td>
                        <td style="margin-left: 80px">
                            <asp:Label ID="EMAILLabel" runat="server" Text='<%# Eval("Email") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><strong>Adres</strong></td>
                        <td style="margin-left: 80px">
                            <asp:Label ID="ADRESLabel" runat="server" Text='<%# Eval("Adres") %>' />
                        </td>
                    </tr>
                </table>
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="<%$ ConnectionStrings:db_eticaretConnectionString %>"
                SelectCommand="SELECT [PersonelID], [Adi], [Soyadi], [TC], [Telefon], [Maas], [Email], [Adres], [Resim] FROM [Personel]">

            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
