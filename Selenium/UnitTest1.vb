Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox

<TestClass()>
Public Class UnitTest1

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
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region


    ' the max. time to wait before timing out.
    Public Const TimeOut As Integer = 30

    <TestMethod()> _
    Public Sub AssertPageTitle()

        Dim driver As IWebDriver = New FirefoxDriver()
        Dim nav As INavigation = driver.Navigate()
        nav.GoToUrl("http://www.google.com/")
        ' Dim element As IWebElement = driver.FindElement(By.Name("firstName"))
        ' Dim value As String = element.GetAttribute("value")
        Assert.AreEqual("google", driver.Title.ToLower)
        driver.Close()


    End Sub
End Class
