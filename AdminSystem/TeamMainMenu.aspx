<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .container {
            max-width: 600px;
            margin: 0 auto;
            text-align: center;
        }
        .buttons {
            margin-top: 20px;
        }
        .buttons input {
            padding: 10px 20px;
            margin: 10px;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Team Main Menu" Font-Size="24px" Font-Bold="True"></asp:Label>
        </div>
        <div class="buttons">
            <asp:Button ID="btnPayment" runat="server" Text="Payment" OnClick="btnPayment_Click" />
            <asp:Button ID="btnStock" runat="server" Text="Stock" OnClick="btnStock_Click" />
            
        </div>
    </form>
</body>
</html>
