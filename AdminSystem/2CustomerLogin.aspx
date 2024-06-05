<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerLogin.aspx.cs" Inherits="_2CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Login Page</title>
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
        .login-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }
        .login-container h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group .error {
            color: red;
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
        }
        .form-actions button.cancel {
            background-color: #6c757d;
        }
        .cancel {
            margin-left: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Customer Login Page</h2>
            <div class="form-group">
                <label for="txtUserName">User Name</label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error" ForeColor="Red"></asp:Label>
            <div class="form-actions">
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" Width="53px" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>
