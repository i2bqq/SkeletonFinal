<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="526px" Width="864px" ></asp:ListBox>
        
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" /><asp:Button runat="server" Text="Edit" ID="btnEdit" OnClick="btnEdit_Click"></asp:Button>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label runat="server" ID="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
