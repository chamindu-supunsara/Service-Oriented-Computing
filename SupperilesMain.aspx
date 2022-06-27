<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupperilesMain.aspx.cs" Inherits="SPC_Warehouse.SupperilesMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tender Proposal</title>
    <link rel="Stylesheet" href="SupperilesMain.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg"> 
        <div class="wrapper">
      	    <div class="title"> Submit Tenders </div>
            <div class="form">
      	        <div class="input_field">
                    <span class="details">Drug ID</span>
                    <asp:TextBox ID="txtDrugid" runat="server" type="text" placeholder="eg: DRUG001" required class="input"></asp:TextBox>
                </div>
      	        <div class="input_field">
                    <span class="details">Drug Name</span>
                    <asp:TextBox ID="txtDrugname" runat="server" type="text" placeholder="eg: Panedol" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Quantity</span>
                    <asp:TextBox ID="txtDQuantity" runat="server" type="text" placeholder="eg: 200" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Product Date</span>
                    <asp:TextBox ID="txtProDate" runat="server" type="text" placeholder="eg: 2/3/2022" required class="input"></asp:TextBox>
                </div>
                <div class="input_field">
                    <span class="details">Expiration Date</span>
                    <asp:TextBox ID="txtExDate" runat="server" type="text" placeholder="eg: 2/3/2024" required class="input"></asp:TextBox>
                </div>
                <asp:Button ID="btnSubmit" runat="server" class="btn" Text="SUBMIT" OnClick="btnSubmit_Click" />
            </div>
          </div>
        </div>
    </form>
</body>
</html>
