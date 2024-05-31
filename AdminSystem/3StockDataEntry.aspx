<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Data Entry</title>
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
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input, .form-group select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-actions {
            display: flex;
            justify-content: space-between;
            margin-top: 20px;
        }
        .form-actions button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
        }
        .form-actions button.cancel {
            background-color: #6c757d;
        }
        .form-group .error {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <label for="txtProductID">Product ID</label>
                <asp:TextBox runat="server" ID="txtProductID"></asp:TextBox>
                <asp:Button runat="server" Text="Find" ID="btnFind" OnClick="btnFind_Click"></asp:Button>
            </div>
            <div class="form-group">
                <label for="txtProductName">Product Name</label>
                <asp:TextBox runat="server" ID="txtProductName"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCategoryName">Category Name</label>
                <asp:TextBox runat="server" ID="txtCategoryName"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPrice">Price</label>
                <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStockQuantity">Stock Quantity</label>
                <asp:TextBox runat="server" ID="txtStockQuantity"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCreatedOn">Created On</label>
                <asp:TextBox runat="server" ID="txtCreatedOn"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:CheckBox runat="server" ID="txtInStock" Text="In Stock"></asp:CheckBox>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="BtnOk_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" CssClass="cancel" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>

