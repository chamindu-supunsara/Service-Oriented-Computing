<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PharmacyMain.aspx.cs" Inherits="SPC_Warehouse.PharmacyMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pharmacies Menu</title>
    <link rel="Stylesheet" href="PharmacyMain.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg"> 
        <div class="wrapper">
      	    <div class="title"> Order Items </div>
            <div class="form">
      	        <div class="input_field">
                    <span class="details">Drug ID</span>
                    <asp:TextBox ID="txtDid" runat="server" type="text" placeholder="eg: DRUG001" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Quantity</span>
                    <asp:TextBox ID="txtQuantity" runat="server" type="text" placeholder="eg: 200" class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Pharmacy ID</span>
                    <asp:TextBox ID="txtPid" runat="server" type="text" placeholder="eg: PHA001" class="input"></asp:TextBox>
                </div>
                <asp:Button ID="btnSearch" runat="server" class="btn" Text="SEARCH" OnClick="btnSearch_Click" />
                <asp:Button ID="btnOrder" runat="server" class="btn" Text="ORDER" OnClick="btnOrder_Click" />
                <br>
                <br>
                <br>
                <asp:GridView ID="GridViewStock" runat="server"></asp:GridView>
            </div>
          </div>
        </div>
    </form>
</body>
</html>
