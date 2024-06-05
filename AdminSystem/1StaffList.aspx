<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <style>
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
        .form-actions button.delete {
            background-color: #dc3545;
        }
        .form-actions button.edit {
            background-color: #ffc107;
        }
        .form-actions button.clear {
            background-color: #6c757d;
        }
        .form-actions button.add {
            background-color: #28a745;
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
                 <label for="LstStockList">Staff List</label>
                 <asp:ListBox ID="lstStaffList" runat="server" Height="200px" Width="100%"></asp:ListBox>
             </div>

             <div class="form-group">
                 <asp:Label ID="lblEnterStaffID" runat="server" Text="ENTER STAFFID"></asp:Label>
                 <asp:TextBox ID="txtEnterStaffID" runat="server"></asp:TextBox>
             </div>
             
             <div class="container">
                 <asp:Button ID="btnApplyFilter" runat="server" CssClass="apply" OnClick="btnApplyFilter_Click" Text="APPLY FILTER" />
                 <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="CLEAR FILTER" />
                 <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="RETURN TO MAIN MENU" />
             </div>

             <div class="container">
                 <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="ADD" />
                 <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="EDIT" />
                 <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE" />
             </div>
             <asp:Label ID="lblError" runat="server" CssClass="error" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
