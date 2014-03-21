<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm.aspx.vb" Inherits="FrontEnd.WebForm" %>

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
    <h1>
        Add new customer</h1>
   
    <div class="form-item">
        <label for="dealerName">
            Customer name
        </label>
        <input type="text" id="customerName" name="dealerName" value="" maxlength="30" autocomplete="off">
    </div>
    <div class="form-item">
        <label for="dealerPostcode">
            Customer Number
        </label>
        <input type="text" id="customerNumber" name="dealerPostcode" value="" maxlength="8"
            autocomplete="off">
    </div>
   
        
</body>
</html>
