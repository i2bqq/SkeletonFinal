<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentList.aspx.cs" Inherits="PaymentList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment List</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvPayments" runat="server" AutoGenerateColumns="False" OnRowCommand="gvPayments_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PaymentID" HeaderText="Payment ID" />
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="PaymentMethod" HeaderText="Payment Method" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" DataFormatString="{0:C}" />
                <asp:CheckBoxField DataField="Status" HeaderText="Refund" />
                <asp:BoundField DataField="CreatedOn" HeaderText="Created On" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:ButtonField ButtonType="Link" CommandName="EditPayment" Text="Edit" />
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txtFilter" runat="server" Width="200px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear Filter" OnClick="btnClear_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDeleteSelected" runat="server" Text="Delete Selected" OnClick="btnDeleteSelected_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="error" Visible="false"></asp:Label>
        <asp:Button ID="btnReturnToMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnReturnToMainMenu_Click" />
    </form>
</body>
</html>
