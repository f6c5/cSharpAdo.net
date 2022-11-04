<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ado_2.aspx.cs" Inherits="venus_web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="BusinessEntityID" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="BusinessEntityID" HeaderText="ID" Visible="false" />
                    <asp:BoundField DataField="Title" HeaderText="Ünvan" />
                    <asp:BoundField DataField="FirstName" HeaderText="Ad" />
                    <asp:BoundField DataField="MiddleName" HeaderText="Ad2" />
                    <asp:BoundField DataField="LastName" HeaderText="Soyad" />
                    <asp:CommandField ButtonType="Button" CancelText="Vazgeç" DeleteText="Sil"
                        EditText="Düzenle" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Güncelle" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:AdventureWorks2019ConnectionString %>" 
                SelectCommand="SELECT [Title], [FirstName], [MiddleName], [LastName], [BusinessEntityID] FROM [Person].[Person]">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
