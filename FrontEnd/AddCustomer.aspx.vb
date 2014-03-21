Public Class AddCustomer
    Inherits System.Web.UI.Page

    

    Protected Sub AddCustomerButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddCustomerButton.Click
        Response.Redirect("Confirmation.aspx")
    End Sub
End Class