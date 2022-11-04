<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="venus_web._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BusinessEntityID" DataValueField="BusinessEntityID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ado_8.aspx?Function=New">Yeni bir telefon ekleyeceğim</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server">HyperLink</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server">HyperLink</asp:HyperLink>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="<%$ ConnectionStrings:AdventureWorks2019ConnectionString %>"
                SelectCommand="SELECT DISTINCT [BusinessEntityID] FROM Person.[PersonPhone] ORDER BY BusinessEntityID">

            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
