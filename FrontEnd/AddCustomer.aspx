<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddCustomer.aspx.vb" Inherits="FrontEnd.AddCustomer" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Create customer - Selenium sample</title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form runat="server">
    <h1>
        Add new customer</h1>
    <div class="form-item">
        <label for="CustomerName">
            Customer name
        </label>
        <asp:TextBox ID="CustomerName" runat="server" MaxLength="30"></asp:TextBox>
        <asp:RequiredFieldValidator ID="CustomerNameRequiredFieldValidator" runat="server"
            ErrorMessage="Please enter a customer name" ControlToValidate="customerName"></asp:RequiredFieldValidator>
    </div>
    <div class="form-item">
        <label for="CustomerNumber">
            Customer Number
        </label>
        <asp:TextBox ID="CustomerNumber" runat="server" MaxLength="8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="CustomerNumberRequiredFieldValidator" runat="server" ErrorMessage="Please enter a customer number"
            ControlToValidate="customerNumber"></asp:RequiredFieldValidator>
    </div>
    <asp:Button ID="AddCustomerButton" runat="server" Text="Add Customer" 
        PostBackUrl="~/Confirmation.aspx" />
    </form>
</body>
</html>
