<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainmenu.aspx.cs" Inherits="SPC_Warehouse.Mainmenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <link rel="Stylesheet" href="MenuMain.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
        <ul>
        	<li><a href="Mainmenu.aspx"><b>Home</a></li>
            <li><a href="SupLogin.aspx">Suppliers</a></li>
            <li><a href="PhaLogin.aspx">Pharmacy</a></li>
            <li><a href="StaffLogin.aspx">Staff</a></li>
            <li><a href="ContactUs.aspx">Contact Us</a></li>
            <li><a href="AboutUs.aspx">About Us</a></li>
      </ul>
    </div>

    <div class="bg">
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <div class="button"><a href="ContactUs.aspx" id="button"> MORE </a></div>
        <div class="logo"></div>
    </div>

    <footer class="footer">
  	 	<div class="foo">
  	 	<div class="row">
  	 		<div class="footer-col">
  	 			<h4>SP Cooperation</h4>
  	 			<ul>
  	 				<li><a href="AboutUs.aspx">About Us</a></li>
  	 				<li><a href="ContactUs.aspx">Contact Us</a></li>
  	 				<li><a href="StaffLogin.aspx">Staff Login</a></li>
  	 			</ul>
  	 		</div>
  	 		<div class="footer-col">
  	 			<h4>GET HELP</h4>
  	 			<ul>
  	 				<li><a href="AboutUs.aspx">FAQ</a></li>
  	 				<li><a href="ContactUs.aspx">Contact Us</a></li>
  	 			</ul>
  	 		</div>
  	 		<div class="footer-col">
  	 			<h4>REGISTER FROMS</h4>
  	 			<ul>
  	 				<li><a href="SupReg.aspx">Suppliers</a></li>
  	 				<li><a href="PhaReg.aspx">Pharmacy</a></li>
  	 			</ul>
  	 		</div>
  	 		<div class="footer-col">
  	 			<h4>FOLLOW US</h4>
                <ul>
  	 				<li><a href="#">Facebook</a></li>
  	 				<li><a href="#">Instagram</a></li>
  	 				<li><a href="#">Twitter</a></li>
  	 			</ul>
  	 		</div>
  	 	</div>
  	 </div>
    </footer>
    </form>
</body>
</html>
