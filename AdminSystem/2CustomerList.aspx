<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="262px" Width="306px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" EnableTheming="False" OnClick="BtnAdd_Click" Text="Add" CssClass="add" />
<asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" CssClass="edit" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
