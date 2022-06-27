<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffMain.aspx.cs" Inherits="SPC_Warehouse.StaffMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff</title>
    <link rel="Stylesheet" href="StaffMain.css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="bg"> 
        <div class="wrapper">
      	    <div class="title"> Manage Stock </div>
            <div class="form">
      	        <div class="input_field">
                    <span class="details">Drug ID</span>
                    <asp:TextBox ID="txtDid" runat="server" type="text" placeholder="eg: DRUG001" required class="input"></asp:TextBox>
                </div>
      	        <div class="input_field">
                    <span class="details">Drug Name</span>
                    <asp:TextBox ID="txtDname" runat="server" type="text" placeholder="eg: Panedol" class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Quantity</span>
                    <asp:TextBox ID="txtQuantity" runat="server" type="text" placeholder="eg: 200" class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Product Date</span>
                    <asp:TextBox ID="txtPdate" runat="server" type="text" placeholder="eg: 2/3/2022" class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Expiration Date</span>
                    <asp:TextBox ID="txtEdate" runat="server" type="text" placeholder="eg: 2/3/2024" class="input"></asp:TextBox>
                </div>
                <asp:Button ID="btnAdd" runat="server" class="btn" Text="ADD" OnClick="btnAdd_Click" />
                <asp:Button ID="btnUpdate" runat="server" class="btn" Text="UPDATE" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnSearch" runat="server" class="btn" Text="SEARCH" OnClick="btnSearch_Click" />
                <br>
                <br>
                <asp:GridView ID="GridViewStock" runat="server"></asp:GridView>
            </div>
          </div>
        </div>
    </form>
</body>
</html>
