<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6PaymentLogIn.aspx.cs" Inherits="PaymentLogIn" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .container {
            max-width: 300px;
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
        .form-group input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group .error {
            color: red;
        }
        .buttons {
            text-align: center;
            margin-top: 20px;
        }
        .buttons input {
            padding: 10px 20px;
            margin: 0 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form-group">
            <label for="txtUserName">Username</label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPassword">Password</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" CssClass="error" Visible="False"></asp:Label>
        </div>
        <div class="buttons">
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
