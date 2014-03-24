Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.IE

Public Class Driver

    Public Shared WebBrowser As IWebDriver

    ''' <summary>
    ''' browser types
    ''' </summary>
    ''' <remarks></remarks>
    Enum Type
        Firefox
        Chrome
        InternetExplorer
        PhantomJS
    End Enum

    ''' <summary>
    ''' Select which web browser to use to execute integration tests
    ''' </summary>
    ''' <param name="Browser"></param>
    ''' <remarks></remarks>
    Public Shared Function Use(ByVal Browser As Type) As IWebDriver
        Select Case Browser
            Case Type.Chrome
                Return New Chrome.ChromeDriver("C:\Users\richarv\Documents\visual studio 2010\Projects\Selenium\Selenium\drivers")
            Case Type.InternetExplorer
                Return New InternetExplorerDriver("C:\Users\richarv\Documents\visual studio 2010\Projects\Selenium\Selenium\drivers")
            Case Type.PhantomJS
                Return New PhantomJS.PhantomJSDriver("C:\Users\richarv\Documents\visual studio 2010\Projects\Selenium\Selenium\drivers")
            Case Else
                Return New FirefoxDriver
        End Select
    End Function
End Class
