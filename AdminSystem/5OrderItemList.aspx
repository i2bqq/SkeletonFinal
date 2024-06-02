<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderItemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 339px; top: 320px; position: absolute"></asp:Label>
            <asp:ListBox ID="lstOrderItemList" runat="server" style="z-index: 1; left: 138px; top: 23px; position: absolute; height: 244px; width: 265px"></asp:ListBox>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 149px; top: 298px; position: absolute" Text="Add" />
        <p>
            <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" style="z-index: 1; left: 257px; top: 295px; position: absolute" Text="Edit" />
        </p>
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 324px; top: 278px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
