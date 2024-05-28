<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 31px; top: 209px; position: absolute" Text="Total amount" width="128px" height="22px"></asp:Label>
            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 29px; top: 246px; position: absolute" Text="Status" width="128px" height="22px"></asp:Label>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 31px; top: 129px; position: absolute" Text="Customer ID" width="128px" height="22px"></asp:Label>
            <asp:Label ID="lblOrderdate" runat="server" style="z-index: 1; left: 33px; top: 169px; position: absolute; width: 128px;" Text="Date of order" height="22px"></asp:Label>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 30px; top: 97px; position: absolute" Text="Order ID" width="128px" height="22px"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 139px; top: 129px; position: absolute; bottom: 423px;" width="128px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 136px; top: 205px; position: absolute" width="128px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 140px; top: 96px; position: absolute; width: 128px;" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 137px; top: 165px; position: absolute" width="128px" height="22px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 31px; top: 294px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 183px; top: 296px; position: absolute"></asp:Label>
        <p>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 135px; top: 242px; position: absolute; margin-top: 0px;"  width="128px"></asp:TextBox>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 54px; top: 353px; position: absolute; margin-top: 2px;" Text="Cancel" height="26px" width="52px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 179px; top: 355px; position: absolute; width: 52px; margin-top: 0px;" Text="OK" />
        </p>
    </form>
</body>
</html>
