﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" ></asp:TextBox>
            <div>
                <asp:Label ID="lbFirstNameId" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox runat="server" ID="txtFirstNameId"></asp:TextBox>
</div>
<div>
    <asp:Label runat="server" Text="Last Name" ID="lblLastNameId"></asp:Label>
    <asp:TextBox runat="server" ID="txtLastNameId"></asp:TextBox>
</div>
<div>
    <asp:Label runat="server" Text="Email" ID="lblEmailId"></asp:Label>
    <asp:TextBox runat="server" ID="txtEmailId"></asp:TextBox>
</div>
<div>
    <asp:Label runat="server" Text="Phone" ID="lblPhoneId"></asp:Label>
    <asp:TextBox runat="server" ID="txtPhoneId"></asp:TextBox>
            <div>
                              <asp:Label runat="server" Text="Country Code " ID="lblCountryCodeId"></asp:Label>
<asp:TextBox runat="server" ID="txtCountryCodeId"></asp:TextBox> 
                <div>
                    <asp:Label runat="server" Text="Address" ID="lblAddressId"></asp:Label>
<asp:TextBox runat="server" ID="txtAddressId"></asp:TextBox>                       
</div>
            <asp:CheckBox runat="server" ID="txtActive" Text="Is Active"></asp:CheckBox>


</div>
    </div>
            <asp:Label runat="server" Text="Created On " ID="Label5"></asp:Label>
<asp:TextBox runat="server" ID="txtCreatedOnId"></asp:TextBox>
</div>
                                      <asp:Label runat="server" Text="Password " ID="lblPasswordId"></asp:Label>
        <asp:TextBox runat="server" ID="txtPasswordId"></asp:TextBox> 
<div>
    <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="BtnOk_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
</div>
    </form>
</body>
</html>