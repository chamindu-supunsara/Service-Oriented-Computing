<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="SPC_Warehouse.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
    <link rel="Stylesheet" href="StaffLogin.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg">
      <div class="wrapper">
      	<div class="title">Staff Log In</div>
        <div class="form">
            <div class="input_field">
                <span class="details">User ID</span>
                <asp:TextBox ID="txtStaffLogin" runat="server" type="text" placeholder="eg: admin" required class="input"></asp:TextBox>
            </div>
            <div class="input_field">
                <span class="details">Password</span>
                <asp:TextBox ID="txtStPassword" runat="server" TextMode="Password" placeholder="Password" required class="input"></asp:TextBox>
            </div>
                <asp:Button ID="btnStLogin" runat="server" class="submit" Text="LOGIN" OnClick="btnStLogin_Click" />
            </div>
         </div>
       </div>
    </form>
</body>
</html>
