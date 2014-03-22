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
    <div class="container">
        <h1>
            Customer database</h1>
        <form runat="server" role="form">
        <h2>
            Add a new customer</h2>
<div class="form-group">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" 
            CssClass="text-danger" ValidationGroup="AddCustomer" DisplayMode="BulletList" />
       </div>
       
        <div class="form-group">
           <label for="CustomerName" class="control-label">
                Customer name</label>
           <asp:TextBox ID="CustomerName" runat="server" MaxLength="30" 
                CssClass="form-control" ValidationGroup="AddCustomer" aria-required="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CustomerNameRequiredFieldValidator" runat="server"
                    ErrorMessage="Please enter a customer name" 
                ControlToValidate="customerName" CssClass="text-danger" 
                ValidationGroup="AddCustomer"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
           <label for="CustomerNumber" class="control-label">
                Customer number</label>
           <asp:TextBox ID="CustomerNumber" runat="server" MaxLength="8" 
                CssClass="form-control" ValidationGroup="AddCustomer" aria-required="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CustomerNumberRequiredFieldValidator" runat="server"
                    ErrorMessage="Please enter a customer number" 
                ControlToValidate="customerNumber" CssClass="text-danger" 
                ValidationGroup="AddCustomer"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="AddCustomerButton" runat="server" CssClass="btn btn-primary" Text="Add Customer"
                    PostBackUrl="~/Confirmation.aspx" ValidationGroup="AddCustomer" />
       
        </form>



    </div>
</body>
</html>
