Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

Public Class AddCustomer

    Public Shared Sub SetCustomerName(ByVal driver As IWebDriver, ByVal Value As String)
        Dim customerName As IWebElement = driver.FindElement(By.Id("CustomerName"))
        customerName.SendKeys(Value)
    End Sub

    Public Shared Sub SetCustomerNumber(ByVal driver As IWebDriver, ByVal Value As String)
        Dim customerNumber As IWebElement = driver.FindElement(By.Id("CustomerNumber"))
        customerNumber.SendKeys(Value)
    End Sub

    Public Shared Sub AddCustomerSubmit(ByVal driver As IWebDriver)
        Dim addCustomerButton As IWebElement = driver.FindElement(By.Id("AddCustomerButton"))
        addCustomerButton.Click()
    End Sub

End Class
