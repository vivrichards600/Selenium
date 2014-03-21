Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

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
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    Public Shared WebBrowser As IWebDriver = New FirefoxDriver()
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    '<TestInitialize()> Public Sub MyTestInitialize()
    'End Sub
    '
    ' Use TestCleanup to run code after each test has run
    <TestCleanup()> Public Sub MyTestCleanup()
        ' driver.Close()
    End Sub
    '
#End Region

    ' the max. time to wait before timing out.
    Public Const TimeOut As Integer = 30

    ''' <summary>
    ''' Ensure that the page is presented
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub AssertPageIsPresented()

        Dim nav As INavigation = webBrowser.Navigate()
        nav.GoToUrl("http://localhost:49641/AddCustomer.aspx/")

        Assert.AreEqual(webBrowser.Title, "Create customer - Selenium sample")

    End Sub

    ''' <summary>
    ''' Ensure when required fields are completed that we get to the success page
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub AssertPageOnValidCompletionGoesToNextPage()

        Dim nav As INavigation = WebBrowser.Navigate()
        nav.GoToUrl("http://localhost:49641/AddCustomer.aspx/")
        ' Dim element As IWebElement = driver.FindElement(By.Name("firstName"))
        ' Dim value As String = element.GetAttribute("value")
        AddCustomer.SetCustomerName(WebBrowser, "Viv Richards")
        AddCustomer.SetCustomerNumber(WebBrowser, "12345678")

        AddCustomer.AddCustomerSubmit(WebBrowser)

        Assert.AreEqual(WebBrowser.Title, "Success - Selenium sample")

    End Sub

End Class
