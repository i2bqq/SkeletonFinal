<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentConfirmDelete.aspx.cs" Inherits="PaymentConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Are you sure you want to delete this payment?</h2>
            <asp:Label ID="lblPaymentID" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
