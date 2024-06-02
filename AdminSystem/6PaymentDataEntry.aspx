<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Data Entry</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .container {
            max-width: 500px;
            margin: 0 auto;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input, .form-group .checkbox-label {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group .small-input {
            width: calc(50% - 10px);
            float: left;
            margin-right: 10px;
        }
        .form-group .small-input:last-child {
            margin-right: 0;
        }
        .buttons {
            text-align: center;
            margin-top: 20px;
        }
        .buttons input {
            padding: 10px 20px;
            margin: 0 10px;
        }
        .error {
            color: red;
            font-weight: bold;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form-group">
            <label for="txtPaymentID">Payment ID</label>
            <asp:TextBox ID="txtPaymentID" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtOrderID">Order ID</label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <asp:Label ID="lblOrderIDError" runat="server" CssClass="error" Visible="false"></asp:Label>
        </div>
        <div class="form-group">
            <label for="txtPaymentDate">Payment Date</label>
            <asp:TextBox ID="txtPaymentDate" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox>
            <asp:Label ID="lblPaymentDateError" runat="server" CssClass="error" Visible="false"></asp:Label>
        </div>
        <div class="form-group">
            <label for="txtPaymentMethod">Payment Method</label>
            <asp:TextBox ID="txtPaymentMethod" runat="server"></asp:TextBox>
            <asp:Label ID="lblPaymentMethodError" runat="server" CssClass="error" Visible="false"></asp:Label>
        </div>
        <div class="form-group">
            <label for="txtAmount">Amount</label>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
            <asp:Label ID="lblAmountError" runat="server" CssClass="error" Visible="false"></asp:Label>
        </div>
        <div class="form-group">
            <label for="chkStatus">Refund</label>
            <asp:CheckBox ID="chkStatus" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtCreatedOn">Created On</label>
            <asp:TextBox ID="txtCreatedOn" runat="server"></asp:TextBox>
            <asp:Label ID="lblCreatedOnError" runat="server" CssClass="error" Visible="false"></asp:Label>
        </div>
        <div class="buttons">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <div class="error">
            <asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
