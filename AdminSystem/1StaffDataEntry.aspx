<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STAFF DATA ENTRY</title>
    <style type="text/css">
        body {
    font-family: Arial, sans-serif;
    background-color: #f2f2f2;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}
.container {
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    width: 400px;
}
.form-group {
    margin-bottom: 15px;
}
.form-group label {
    display: block;
    margin-bottom: 5px;
}
.form-group input, .form-group select {
    width: 100%;
    padding: 8px;
    box-sizing: border-box;
}
.form-actions {
    display: flex;
    justify-content: space-between;
    margin-top: 20px;
}
.form-actions button {
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    background-color: #007BFF;
    color: white;
    cursor: pointer;
}
.form-actions button.cancel {
    background-color: #6c757d;
}
.form-group .error {
    color: red;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
              <div class="form-group">
                  <div>
                      <asp:Label ID="lblStaffID" runat="server" Text="STAFF ID"></asp:Label>
                      <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
                      <asp:Button runat="server" Text="Find" ID="btnFind" OnClick="btnFind_Click"></asp:Button>
                  </div>
                  
                  <div class="form-group">
                      <asp:Label ID="lblFirstName" runat="server" Text=" FIRST NAME"></asp:Label>
                      <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                  </div>
                  
                  <div class="form-group">
                      <asp:Label ID="lblLastName" runat="server" Text="LAST NAME"></asp:Label>
                      <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                  </div>
                  
                  <div class="form-group">
                      <asp:Label ID="lblContactNumber" runat="server" Text="CONTACT"></asp:Label>
                      <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                  </div>

                  <div class="form-group">
                      <asp:Label ID="lblCountryCode" runat="server" Text="COUNTRY CODE"></asp:Label>
                      <asp:TextBox ID="txtCountryCode" runat="server"></asp:TextBox>
                  </div>

                  <div class="form-group">
                      <asp:Label ID="lblEmailID" runat="server" Text="EMAILID"></asp:Label>
                      <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
                  </div>

                  <div class="form-group">
                      <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
                      <asp:Label ID="lblRole" runat="server" Text="ROLE"></asp:Label>
                  </div>

                  <div class="form-group">
                      <asp:Label ID="lblHireDate" runat="server" Text="HIRE DATE"></asp:Label>
                      <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                  </div>

                  <div class="form-group">                  
                      <asp:Label ID="lblPassowrd" runat="server" Text="PASSWORD"></asp:Label>
                      <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                  </div>

                  <div class="form-group"> 
                      <asp:CheckBox ID="chkActive" runat="server" Text="IS ACTIVE" />
                  </div>

                  <div>
                      <asp:Label ID="lblError" runat="server"></asp:Label>
                  </div>

                  <div class="form-group">
                      <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
                      <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                      <asp:Button ID="Button2" runat="server" Text="RETURN TO MAIN MENU" OnClick="Button2_Click" />
                  </div>
    </form>
</body>
</html>

