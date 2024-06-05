<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .container h2 {
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            margin: 5px;
        }
        .form-group .no-button {
            background-color: #6c757d;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Confirm Delete</h2>
            <div class="form-group">
                <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this order item?"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
                <asp:Button ID="BtnNo" runat="server" CssClass="no-button" OnClick="BtnNo_Click" Text="No" />
            </div>
        </div>
    </form>
</body>
</html>
