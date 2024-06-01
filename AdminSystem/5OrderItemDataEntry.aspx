<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderItemId" runat="server" Text="Order Item ID "></asp:Label>
            <asp:TextBox ID="txtOrderItemID" runat="server" ></asp:TextBox>
        </div>
                <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID "></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" ></asp:TextBox>
        </div>
                <div>
    <asp:Label ID="lblProductID" runat="server" Text="Product ID "></asp:Label>
    <asp:TextBox ID="txtProductID" runat="server" ></asp:TextBox>
</div>
                <div>
    <asp:Label ID="lblQuantity" runat="server" Text="Quantity "></asp:Label>
    <asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox>
</div>
                <div>
    <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price "></asp:Label>
    <asp:TextBox ID="txtUnitPrice" runat="server" ></asp:TextBox>
</div>
                        <div>
    <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" ></asp:TextBox>
</div>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="BtnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; top: 182px; position: absolute; left: 103px"></asp:Label>
    </form>
</body>
</html>
