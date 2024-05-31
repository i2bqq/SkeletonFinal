<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STAFF DATA ENTRY</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 168px; top: 30px; position: absolute; right: 734px"></asp:TextBox>
<br />
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 83px; top: 31px; position: absolute; width: 70px" Text="STAFF ID"></asp:Label>
        <br />
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; top: 73px; position: absolute; left: 57px" Text=" FIRST NAME"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 168px; top: 73px; position: absolute; bottom: 449px"></asp:TextBox>
        <br />
        <div>
        </div>
        <br />
        <div>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 56px; position: absolute; top: 114px" Text="LAST NAME"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 167px; top: 113px; position: absolute"></asp:TextBox>
        <br />
        <asp:Label ID="lblContactNumber" runat="server" style="z-index: 1; left: 65px; top: 225px; position: absolute" Text="CONTACT"></asp:Label>
        <div>
        </div>
        <asp:Label ID="lblCountryCode" runat="server" style="z-index: 1; left: 20px; top: 189px; position: absolute" Text="COUNTRY CODE"></asp:Label>
        <br />
        <div>
            <asp:Label ID="lblEmailID" runat="server" style="z-index: 1; left: 75px; top: 153px; position: absolute" Text="EMAILID"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 167px; top: 152px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 170px; top: 293px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 91px; top: 296px; position: absolute" Text="ROLE"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 169px; top: 188px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; top: 223px; position: absolute; left: 169px"></asp:TextBox>
        <br />
        <div>
            <asp:Label ID="lblHireDate" runat="server" style="z-index: 1; left: 59px; top: 260px; position: absolute" Text="HIRE DATE"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 170px; top: 260px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassowrd" runat="server" style="z-index: 1; left: 58px; top: 329px; position: absolute" Text="PASSWORD"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 167px; top: 329px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 167px; top: 368px; position: absolute" Text="IS ACTIVE" />
        <br />
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 131px; top: 400px; position: absolute; width: 184px"></asp:Label>
        </div>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 428px; position: absolute; right: 916px" Text="OK" />
        <br />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 426px; position: absolute; left: 202px" Text="Cancel" />
        <div>
        </div>
    </form>
</body>
</html>

