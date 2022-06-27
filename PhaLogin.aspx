<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhaLogin.aspx.cs" Inherits="SPC_Warehouse.PhaLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pharmacy Login</title>
    <link rel="Stylesheet" href="SupLogin.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg">
        <div class="wrapper">
      	<div class="title">Pharmacy Log In</div>
        <div class="form">
            <div class="input_field">
                <span class="details">User ID</span>
                <asp:TextBox ID="txtPhaLogin" runat="server" type="text" placeholder="eg: PHA001" required class="input"></asp:TextBox>
            </div>
            <div class="input_field">
                <span class="details">Password</span>
                <asp:TextBox ID="txtPhaPassword" runat="server" TextMode="Password" placeholder="Password" required class="input"></asp:TextBox>
            </div>
                <asp:Button ID="btnStLogin" runat="server" class="submit" Text="LOGIN" OnClick="btnStLogin_Click" />
            <div class="btn2"><a href="PhaReg.aspx" id="btn2"> First Register Here </a></div>
            </div>
         </div>
      </div>
    </form>
</body>
</html>
