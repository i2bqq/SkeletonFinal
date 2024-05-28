<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
            <asp:TextBox runat="server" ID="txtProductID"></asp:TextBox>
            <asp:Button runat="server" Text="Find" ID="btnFind" OnClick="btnFind_Click"></asp:Button>
        </div>
        <br />
        <div>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox runat="server" ID="txtProductName"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Category Name" ID="lblCategoryName"></asp:Label>
            <asp:TextBox runat="server" ID="txtCategoryName"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Price" ID="lblPrice"></asp:Label>
            <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Stock Quantity" ID="lblStockQuantity"></asp:Label>
            <asp:TextBox runat="server" ID="txtStockQuantity"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblCreatedOn" runat="server" Text="Created On:" AssociatedControlID="txtCreatedOn"></asp:Label>
            <asp:TextBox runat="server" ID="txtCreatedOn" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:CheckBox runat="server" ID="txtInStock" Text="In Stock"></asp:CheckBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="BtnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
