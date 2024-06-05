<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Data Entry</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="form-group row">
            <label for="txtOrderID" class="col-sm-2 col-form-label">Order ID</label>
            <div class="col-sm-8">
                <asp:TextBox ID="txtOrderID" runat="server" CssClass="form-control" />
            </div>
            <div class="col-sm-2">
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" CssClass="btn btn-primary" Text="Find" />
            </div>
        </div>
        <div class="form-group row">
            <label for="txtCustomerID" class="col-sm-2 col-form-label">Customer ID</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCustomerID" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group row">
            <label for="txtOrderDate" class="col-sm-2 col-form-label">Date of Order</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTotalAmount" class="col-sm-2 col-form-label">Total Amount</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-2">Order Status</div>
            <div class="col-sm-10">
                <asp:CheckBox ID="chkOrderStatus" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="chkOrderStatus">Order Status</label>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" CssClass="btn btn-success" Text="OK" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" CssClass="btn btn-danger" Text="Cancel" />
                <asp:Label ID="lblError" runat="server" CssClass="text-danger ml-3"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
