<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order List</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="form-group">
            <asp:ListBox ID="lstOrderList" runat="server" CssClass="form-control" Height="526px" Width="864px"></asp:ListBox>
        </div>
        <div class="form-group row">
            <div class="col">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-primary" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="btn btn-secondary ml-2" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="btn btn-danger ml-2" Text="Delete" />
                <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" CssClass="btn btn-info ml-2" Text="Return to main menu" />
            </div>
        </div>
        <div class="form-group row">
            <label for="txtEnterCustomerID" class="col-sm-2 col-form-label">Enter a Customer ID</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEnterCustomerID" runat="server" CssClass="form-control" Width="160px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <div class="col">
                <asp:Button ID="btnApplyFilter" runat="server" CssClass="btn btn-success" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" CssClass="btn btn-warning ml-2" Text="Clear Filter" OnClick="btnClearFilter_Click" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="lblError" CssClass="text-danger"></asp:Label>
        </div>
    </form>
</body>
</html>

