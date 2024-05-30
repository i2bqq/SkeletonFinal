<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="LstStockList" runat="server" Height="363px" Width="309px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" EnableTheming="False" Height="25px" OnClick="BtnAdd_Click" style="margin-left: 25px" Text="Add" Width="102px" />
        </p>
    </form>
</body>
</html>
