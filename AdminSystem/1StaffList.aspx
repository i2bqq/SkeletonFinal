<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 578px;
        }
    </style>
</head>
<body style="height: 553px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="305px" Width="332px" OnSelectedIndexChanged="LstStaffList_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="ADD" />
        &nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="EDIT" style="height: 26px" />
        &nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblEnterStaffID" runat="server" Text="ENTER STAFFID"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtEnterStaffID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnApplyFilter" runat="server" CssClass="apply" OnClick="btnApplyFilter_Click" Text="APPLY FILTER" />
&nbsp;&nbsp;
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="CLEAR FILTER" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="RETURN TO MAIN MENU" />
        <br />
    </form>
</body>
</html>
