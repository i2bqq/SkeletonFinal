<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
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
        .form-container {
            background-color: #fff;
            padding: 30px 40px;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
            width: 400px;
            box-sizing: border-box;
        }
        .form-container h2 {
            text-align: center;
            margin-bottom: 25px;
            color: #333;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-group label {
            display: block;
            margin-bottom: 8px;
            font-weight: bold;
            color: #555;
        }
        .form-group input, .form-group .asp-checkbox {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
        }
        .form-group .asp-checkbox {
            display: flex;
            align-items: center;
            gap: 10px;
        }
        .form-actions {
            display: flex;
            justify-content: space-between;
        }
        .form-actions button {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            background-color: #007BFF;
            color: white;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s ease;
            width: 48%;
        }
        .form-actions button.cancel {
            background-color: #6c757d;
        }
        .form-actions button:hover {
            background-color: #0056b3;
        }
        .form-actions button.cancel:hover {
            background-color: #5a6268;
        }
        .error {
            color: red;
            margin-top: 10px;
            text-align: center;
            font-size: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Customer Data Entry</h2>
            <div class="form-group">
                <label for="txtCustomerID">Customer ID</label>
                <asp:TextBox ID="txtCustomerID" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtFirstNameId">First Name</label>
                <asp:TextBox ID="txtFirstNameId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtLastNameId">Last Name</label>
                <asp:TextBox ID="txtLastNameId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtEmailId">Email</label>
                <asp:TextBox ID="txtEmailId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPhoneId">Phone</label>
                <asp:TextBox ID="txtPhoneId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtCountryCodeId">Country Code</label>
                <asp:TextBox ID="txtCountryCodeId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtAddressId">Address</label>
                <asp:TextBox ID="txtAddressId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <div class="asp-checkbox">
                    <asp:CheckBox ID="chkActive" runat="server" Text="Is Active" AutoPostBack="True" />
                </div>
            </div>
            <div class="form-group">
                <label for="txtCreatedOnId">Created On</label>
                <asp:TextBox ID="txtCreatedOnId" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPasswordId">Password</label>
                <asp:TextBox ID="txtPasswordId" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
            <div class="form-actions">
                <asp:Button ID="btnOk" runat="server" Text="Ok" CssClass="btn btn-primary" OnClick="BtnOk_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary cancel" OnClick="BtnCancel_Click" />
            </div>
            <asp:Label ID="lblError" runat="server" Text="lblError" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>