Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

Public Class Accessibility

    Shared Function AriaRequiredPresent(ByVal WebBrowser As IWebDriver, ByVal ControlName As String) As Boolean
        Return WebBrowser.FindElement(By.Id(ControlName)).GetAttribute("aria-required")
    End Function

    Shared Function AriaInvalidPresent(ByVal WebBrowser As IWebDriver, ByVal ControlName As String) As Boolean
        Return WebBrowser.FindElement(By.Id(ControlName)).GetAttribute("aria-invalid")
    End Function

End Class
