<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentList.aspx.cs" Inherits="PaymentList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment List</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .container {
            margin-top: 20px;
        }
        .error {
            color: red;
            font-weight: bold;
            margin-top: 10px;
        }
    </style>
    <script type="text/javascript">
        function confirmDelete() {
            return confirm('Are you sure you want to delete the selected payments?');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <h2>Payment List</h2>
            <asp:Label ID="lblUser" runat="server" CssClass="text-info" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" placeholder="Filter by Payment Method" AutoPostBack="true" OnTextChanged="txtFilter_TextChanged" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear Filter" CssClass="btn btn-secondary my-2" OnClick="btnClear_Click" />
                    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-success my-2" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnDeleteSelected" runat="server" Text="Delete Selected" CssClass="btn btn-danger my-2" OnClick="btnDeleteSelected_Click" OnClientClick="return confirmDelete();" />
                    <asp:Button ID="btnReturnToMainMenu" runat="server" Text="Return to Main Menu" CssClass="btn btn-info my-2" OnClick="btnReturnToMainMenu_Click" />
                    <asp:Label ID="lblError" runat="server" CssClass="error" Visible="false"></asp:Label>
                    <asp:GridView ID="gvPayments" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" OnRowCommand="gvPayments_RowCommand" AllowPaging="True" PageSize="10" OnPageIndexChanging="gvPayments_PageIndexChanging" AllowSorting="True" OnSorting="gvPayments_Sorting">
                        <Columns>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkSelect" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="PaymentID" HeaderText="Payment ID" SortExpression="PaymentID" />
                            <asp:BoundField DataField="OrderID" HeaderText="Order ID" SortExpression="OrderID" />
                            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" DataFormatString="{0:dd/MM/yyyy}" SortExpression="PaymentDate" />
                            <asp:BoundField DataField="PaymentMethod" HeaderText="Payment Method" SortExpression="PaymentMethod" />
                            <asp:BoundField DataField="Amount" HeaderText="Amount" DataFormatString="{0:C}" SortExpression="Amount" />
                            <asp:CheckBoxField DataField="Status" HeaderText="Refund" SortExpression="Status" />
                            <asp:BoundField DataField="CreatedOn" HeaderText="Created On" DataFormatString="{0:dd/MM/yyyy}" SortExpression="CreatedOn" />
                            <asp:ButtonField ButtonType="Link" CommandName="EditPayment" Text="Edit" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
