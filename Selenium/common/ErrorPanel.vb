Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

Public Class ErrorPanel

    Shared Function NumberOfErrors(ByVal WebBrowser As IWebDriver) As Integer
        Return WebBrowser.FindElement(By.Id("ValidationSummary")).FindElements(By.TagName("li")).Count
    End Function

End Class
