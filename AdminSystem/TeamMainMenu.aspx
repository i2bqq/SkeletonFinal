<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f9;
        }
        .container {
            max-width: 600px;
            margin: 50px auto;
            padding: 30px;
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .buttons {
            margin-top: 20px;
        }
        .buttons .btn {
            margin: 10px;
            width: 180px;
            height: 50px;
            font-size: 18px;
            border-radius: 5px;
        }
        .header {
            font-size: 28px;
            font-weight: bold;
            margin-bottom: 30px;
            color: #343a40;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblTitle" runat="server" Text="Team Main Menu" CssClass="header"></asp:Label>
            <div class="buttons">
                <asp:Button ID="BtnCustomer" runat="server" OnClick="BtnCustomer_Click" Text="Customer" CssClass="btn btn-outline-primary" />
                <asp:Button ID="btnStaff" runat="server" OnClick="btnClick" Text="Staff" CssClass="btn btn-outline-secondary" />
                <asp:Button ID="btnPayment" runat="server" Text="Payment" OnClick="btnPayment_Click" CssClass="btn btn-outline-success" />
                <asp:Button ID="btnStock" runat="server" Text="Stock" OnClick="btnStock_Click" CssClass="btn btn-outline-danger" />
                <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" CssClass="btn btn-outline-warning" />
                <asp:Button ID="btnOrderItem" runat="server" Text="Order Item" OnClick="btnOrderItem_Click" CssClass="btn btn-outline-info" />
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
