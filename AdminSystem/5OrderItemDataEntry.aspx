<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Item Data Entry</title>
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
            text-align: left;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input {
            width: calc(100% - 20px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            margin-bottom: 10px;
        }
        .form-group button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            width: calc(50% - 10px);
            margin-right: 10px;
        }
        .form-group button:last-child {
            margin-right: 0;
            background-color: #6c757d;
        }
        .form-group .error {
            color: red;
            margin-top: 10px;
        }
        .inline-group {
            display: flex;
            align-items: center;
        }
        .inline-group input {
            flex: 1;
        }
        .inline-group button {
            flex: 0 0 auto;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Order Item Data Entry</h2>
            <div class="form-group inline-group">
                <asp:Label ID="lblOrderItemId" runat="server" Text="Order Item ID"></asp:Label>
                <asp:TextBox ID="txtOrderItemID" runat="server"></asp:TextBox>
                <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
                <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
                <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price"></asp:Label>
                <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price"></asp:Label>
                <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="BtnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
