Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports System.Threading
Imports System.Globalization
Imports OpenQA.Selenium.IE
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.PhantomJS

<TestClass()>
Public Class AddCustomerUnitTests

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property

    Public WebBrowser As IWebDriver
    <TestInitialize()>
    Public Sub Initialization()
        WebBrowser = New FirefoxDriver
        'WebBrowser = New PhantomJSDriver
        'WebBrowser = New ChromeDriver
        'WebBrowser = New InternetExplorerDriver
        'Only necessary for the correct date format, e.g. PublishedDate
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
    End Sub
    <TestCleanup()>
    Public Sub Termination()
        WebBrowser.Quit()
    End Sub

    ' the max. time to wait before timing out.
    Public Const TimeOut As Integer = 30
    ''' <summary>
    ''' Ensure that the page is presented
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub AssertPageIsPresented()

        WebBrowser.Navigate.GoToUrl("http://localhost:49641/AddCustomer.aspx/")

        Assert.AreEqual(WebBrowser.Title, "Create customer - Selenium sample")

    End Sub

    ''' <summary>
    ''' Ensure when required fields are completed that we get to the success page
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub AssertPageOnValidCompletionGoesToNextPage()

        Dim nav As INavigation = WebBrowser.Navigate()
        nav.GoToUrl("http://localhost:49641/AddCustomer.aspx/")

        AddCustomer.SetCustomerName(WebBrowser, "Viv Richards")
        AddCustomer.SetCustomerNumber(WebBrowser, "12345678")
        AddCustomer.AddCustomerSubmit(WebBrowser)

        Assert.AreEqual(WebBrowser.Title, "Success - Selenium sample")

    End Sub

End Class
