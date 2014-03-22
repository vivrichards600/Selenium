Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

Public Class AddCustomer

    Shared Property PageUrl As String = "http://localhost:49641/AddCustomer.aspx/"
    Shared Property PageTitle As String = "Create customer - Selenium sample"

    Shared Sub SetCustomerName(ByVal WebBrowser As IWebDriver, ByVal Value As String)
        Dim customerName As IWebElement = WebBrowser.FindElement(By.Id("CustomerName")) 'TODO: need a way to reference web browser from a test across any page object
        customerName.SendKeys(Value)
    End Sub

    Shared Function CustomerNameValidationError(ByVal WebBrowser As IWebDriver) As Boolean
        Return WebBrowser.FindElement(By.Id("CustomerNameRequiredFieldValidator")).Displayed
    End Function

    Shared Sub SetCustomerNumber(ByVal WebBrowser As IWebDriver, ByVal Value As String)
        Dim customerNumber As IWebElement = WebBrowser.FindElement(By.Id("CustomerNumber"))
        customerNumber.SendKeys(Value)
    End Sub

    Shared Function CustomerNumberValidationError(ByVal WebBrowser As IWebDriver) As Boolean
        Return WebBrowser.FindElement(By.Id("CustomerNameRequiredFieldValidator")).Displayed
    End Function

    Shared Sub AddCustomerClick(ByVal WebBrowser As IWebDriver)
        Dim addCustomerButton As IWebElement = WebBrowser.FindElement(By.Id("AddCustomerButton"))
        addCustomerButton.Click()
    End Sub

    Shared Function NumberOfErrors(ByVal WebBrowser As IWebDriver) As Integer
        Return WebBrowser.FindElement(By.Id("ValidationSummary")).FindElements(By.TagName("li")).Count
    End Function

End Class
