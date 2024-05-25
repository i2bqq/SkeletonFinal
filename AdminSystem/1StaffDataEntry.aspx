<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Last Name" ID="lblLastName"></asp:Label>
            <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Email" ID="lblEmail"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Phone" ID="lblPhone"></asp:Label>
            <asp:TextBox runat="server" ID="txtPhone"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblCountryCode" runat="server" Text="Country Code:" AssociatedControlID="ddlCountryCode"></asp:Label>
            <asp:DropDownList ID="ddlCountryCode" runat="server">
                <asp:ListItem Text="US" Value="US"></asp:ListItem>
                <asp:ListItem Text="UK" Value="UK"></asp:ListItem>
                <asp:ListItem Text="AU" Value="AU"></asp:ListItem>
                <asp:ListItem Text="CA" Value="CA"></asp:ListItem>
                <asp:ListItem Text="IN" Value="IN"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Role" ID="lblRole"></asp:Label>
            <asp:TextBox runat="server" ID="txtRole"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblHireDate" runat="server" Text="Hire Date:" AssociatedControlID="txtHireDate"></asp:Label>
            <asp:TextBox ID="txtHireDate" runat="server" TextMode="Date"> </asp:TextBox>
        </div>
        <br />
        <div>
            <asp:CheckBox runat="server" ID="Active" Text="Active"></asp:CheckBox>
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Password" ID="lblPasswordHash"></asp:Label>
            <asp:TextBox runat="server" ID="txtPasswordHash"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Add Staff" OnClick="BtnAdd_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
        </div>
    </form>
</body>
</html>

