<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentList.aspx.cs" Inherits="PaymentList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment List</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstPaymentList" runat="server" Width="500px" Height="200px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" Width="200px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear Filter" OnClick="btnClear_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="error" Visible="false"></asp:Label>
    </form>
</body>
</html>
