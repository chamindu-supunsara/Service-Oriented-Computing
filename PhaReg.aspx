<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhaReg.aspx.cs" Inherits="SPC_Warehouse.PhaReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pharmacy Registation</title>
    <link rel="Stylesheet" href="PhaReg.css" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="bg">
        <div class="wrapper">
      	    <div class="title"> PHARMACY REGISTATION </div>
            <div class="form">
      	        <div class="input_field">
                    <span class="details">Pharmacy ID</span>
                    <asp:TextBox ID="txtPid" runat="server" type="text" placeholder="eg: PHA001" required class="input"></asp:TextBox>
                </div>
      	        <div class="input_field">
                    <span class="details">Pharmacy Name</span>
                    <asp:TextBox ID="txtPname" runat="server" type="text" placeholder="eg: New Pharmacy Kandy" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Pharmacy Email</span>
                    <asp:TextBox ID="txtPemail" runat="server" type="text" placeholder="eg: info@pharmacykandy.com" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Pharmacy Phone Number</span>
                    <asp:TextBox ID="txtPphone" runat="server" type="text" placeholder="eg: 0252265550" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Pharmacy Location</span>
                    <asp:TextBox ID="txtPlocation" runat="server" type="text" placeholder="eg: Kandy" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Password</span>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" required class="input"></asp:TextBox>
                </div>
                <asp:Button ID="btnRegister" runat="server" class="btn" Text="REGISTER" OnClick="btnRegister_Click" />
            </div>
          </div>
       </div>
    </form>
</body>
</html>
