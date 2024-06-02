<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this order item"></asp:Label>
        </div>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 34px; top: 51px; position: absolute" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 109px; top: 40px; position: absolute" Text="No" />
    </form>
</body>
</html>
