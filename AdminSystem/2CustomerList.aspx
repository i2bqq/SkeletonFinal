<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
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
            padding: 20px 40px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 400px;
            box-sizing: border-box;
            text-align: center;
        }
        .container h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label, .form-group input, .form-group select {
            display: block;
            width: 100%;
            margin-bottom: 10px;
        }
        .form-group input, .form-group select {
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
        }
        .form-actions {
            display: flex;
            justify-content: space-between;
            margin-top: 15px;
        }
        .form-actions button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s ease;
            width: 48%;
        }
        .form-actions button.cancel {
            background-color: #6c757d;
        }
        .form-actions button:hover {
            background-color: #0056b3;
        }
        .form-actions button.cancel:hover {
            background-color: #5a6268;
        }
        .error {
            color: red;
            margin-top: 10px;
            text-align: center;
            font-size: 13px;
        }
        .button-group {
            display: flex;
            justify-content: space-between;
            margin-top: 10px;
        }
        .button-group button {
            flex: 1;
            margin: 5px;
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s ease;
        }
        .button-group button.cancel {
            background-color: #6c757d;
        }
        .button-group button:hover {
            background-color: #0056b3;
        }
        .button-group button.cancel:hover {
            background-color: #5a6268;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Customer List</h2>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="200px" Width="100%" />
            <div class="button-group">
                <asp:Button ID="btnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" CssClass="add" />
                <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" CssClass="edit" />
                <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" CssClass="delete" />
            </div>
            <div class="form-group">
                <label for="txtFilter">Enter a First Name</label>
                <asp:TextBox ID="txtFilter" runat="server" Width="100%" />
            </div>
            <div class="button-group">
                <asp:Button ID="btnFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" CssClass="cancel" />
            </div>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="Button1_Click" Text="Return To Main Menu" CssClass="cancel" Width="100%" />
            <asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>