<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemLoginPage.aspx.cs" Inherits="_5OrderItemLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 557px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 546px; top: 49px; position: absolute" Text="OrderItem Login Page"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 446px; top: 97px; position: absolute" Text="UserName:"></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 704px; top: 182px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 448px; top: 133px; position: absolute; width: 34px" Text="Password"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 548px; top: 97px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 540px; top: 133px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 457px; top: 201px; position: absolute" Text="Login" />
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 604px; top: 200px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
