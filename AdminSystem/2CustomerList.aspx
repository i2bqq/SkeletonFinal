<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .edit {
            margin-left: 65px;
        }
        .add {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="262px" Width="306px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" EnableTheming="False" OnClick="BtnAdd_Click" Text="Add" CssClass="add" Width="54px" />
<asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" CssClass="edit" Width="48px" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" style="margin-left: 60px" />
        </p>
        <p>
            <asp:Label ID="LblFirstName" runat="server" Text="Enter a First Name "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 11px" Width="143px" Height="20px"></asp:TextBox>
            <asp:Button ID="btnMainMenu" runat="server" Height="27px" OnClick="Button1_Click" style="margin-left: 45px" Text="Return To Main Menu" Width="140px" />
        </p>
        <p>
            <asp:Button ID="btnFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter " Width="78px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="margin-left: 67px" Text="Clear Filter " Width="81px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
