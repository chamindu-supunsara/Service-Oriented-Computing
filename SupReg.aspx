<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupReg.aspx.cs" Inherits="SPC_Warehouse.StaffReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Registation</title>
    <link rel="Stylesheet" href="PhaReg.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg"> 
        <div class="wrapper">
      	    <div class="title"> SUPPLIER REGISTATION </div>
            <div class="form">
      	        <div class="input_field">
                    <span class="details">Supplier ID</span>
                    <asp:TextBox ID="txtSid" runat="server" type="text" placeholder="eg: SUP001" required class="input"></asp:TextBox>
                </div>
      	        <div class="input_field">
                    <span class="details">Supplier Name</span>
                    <asp:TextBox ID="txtSname" runat="server" type="text" placeholder="eg: Chamindu" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Supplier NIC</span>
                    <asp:TextBox ID="txtSnic" runat="server" type="text" placeholder="eg: 200017503598" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Supplier Phone Number</span>
                    <asp:TextBox ID="txtSphone" runat="server" type="text" placeholder="eg: 0772038566" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Supplier Email</span>
                    <asp:TextBox ID="txtSemail" runat="server" type="text" placeholder="eg: tsupun9@gmail.com" required class="input"></asp:TextBox>
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
