<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Item List</title>
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
            width: 400px;
            text-align: center;
        }
        .container h2 {
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input, .form-group select {
            width: calc(100% - 22px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-group button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            width: 100px;
            margin-right: 10px;
        }
        .form-group button:last-child {
            margin-right: 0;
        }
        .form-group .error {
            color: red;
        }
        .form-group .buttons {
            display: flex;
            justify-content: space-between;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Order Item List</h2>
            <div class="form-group">
                <asp:ListBox ID="lstOrderItemList" runat="server" Height="200px" Width="100%"></asp:ListBox>
            </div>
            <div class="form-group buttons">
                <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
                <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
                <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblFilter" runat="server" Text="Enter an Order ID"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </div>
            <div class="form-group buttons">
                <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply Filter" />
                <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" Text="Clear Filter" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
