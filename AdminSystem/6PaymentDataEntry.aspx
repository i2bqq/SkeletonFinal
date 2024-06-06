<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Data Entry</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .container {
            max-width: 500px;
            margin: 0 auto;
        }
        .form-group label {
            font-weight: bold;
        }
        .error {
            color: red;
            font-weight: bold;
            margin-top: 10px;
        }
        .success {
            color: green;
            font-weight: bold;
            margin-top: 10px;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#<%= txtPaymentDate.ClientID %>, #<%= txtCreatedOn.ClientID %>').on('input', function (e) {
                var input = $(this).val().replace(/[^0-9]/g, '');
                if (input.length > 2) {
                    input = input.substring(0, 2) + '/' + input.substring(2);
                }
                if (input.length > 5) {
                    input = input.substring(0, 5) + '/' + input.substring(5);
                }
                $(this).val(input);
            });
        });
    </script>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="needs-validation" novalidate>
            <asp:HiddenField ID="hfPaymentID" runat="server" />
            <div class="form-group">
                <label for="txtPaymentID">Payment ID</label>
                <asp:TextBox ID="txtPaymentID" runat="server" ReadOnly="false" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtOrderID">Order ID</label>
                <asp:TextBox ID="txtOrderID" runat="server" CssClass="form-control" required></asp:TextBox>
                <asp:Label ID="lblOrderIDError" runat="server" CssClass="error" Visible="false"></asp:Label>
            </div>
            <div class="form-group">
                <label for="txtPaymentDate">Payment Date</label>
                <asp:TextBox ID="txtPaymentDate" runat="server" CssClass="form-control" placeholder="dd/mm/yyyy" required></asp:TextBox>
                <asp:Label ID="lblPaymentDateError" runat="server" CssClass="error" Visible="false"></asp:Label>
            </div>
            <div class="form-group">
                <label for="txtPaymentMethod">Payment Method</label>
                <asp:TextBox ID="txtPaymentMethod" runat="server" CssClass="form-control" required></asp:TextBox>
                <asp:Label ID="lblPaymentMethodError" runat="server" CssClass="error" Visible="false"></asp:Label>
            </div>
            <div class="form-group">
                <label for="txtAmount">Amount</label>
                <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control" required></asp:TextBox>
                <asp:Label ID="lblAmountError" runat="server" CssClass="error" Visible="false"></asp:Label>
            </div>
            <div class="form-group form-check">
                <asp:CheckBox ID="chkStatus" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="chkStatus">Refund</label>
            </div>
            <div class="form-group">
                <label for="txtCreatedOn">Created On</label>
                <asp:TextBox ID="txtCreatedOn" runat="server" CssClass="form-control" placeholder="dd/mm/yyyy" required></asp:TextBox>
                <asp:Label ID="lblCreatedOnError" runat="server" CssClass="error" Visible="false"></asp:Label>
            </div>
            <div class="buttons text-center">
                <asp:Button ID="btnOK" runat="server" CssClass="btn btn-primary" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-secondary" OnClick="btnCancel_Click" Text="Cancel" />
                <asp:Button ID="btnFind" runat="server" CssClass="btn btn-info" OnClick="btnFind_Click" Text="Find" />
                <asp:Button ID="btnReturnToPaymentList" runat="server" CssClass="btn btn-warning" OnClick="btnReturnToPaymentList_Click" Text="Return to Payment List" />
                <asp:Label ID="lblError" runat="server" CssClass="error" Visible="false"></asp:Label>
                <asp:Label ID="lblSuccess" runat="server" CssClass="success" Visible="false"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
