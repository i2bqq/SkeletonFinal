﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>
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
            width: 300px;
        }
        .container h2 {
            margin-bottom: 20px;
        }
        .buttons {
            display: flex;
            justify-content: space-between;
        }
        .buttons button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            width: 100px;
        }
        .buttons button.cancel {
            background-color: #6c757d;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Confirm Delete</h2>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this Product?"></asp:Label>
            <div class="buttons">
                <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
                <asp:Button ID="BtnNo" runat="server" Text="No" OnClick="BtnNo_Click" CssClass="cancel" />
            </div>
        </div>
    </form>
</body>
</html>

