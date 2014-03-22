Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports Selenium.AddCustomer

<TestClass()>
Public Class AddCustomerIntegrationSpec

    Private testContextInstance As TestContext
    Public Shared WebBrowser As IWebDriver

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

    <TestInitialize()>
    Public Sub Initialization()
        WebBrowser = New FirefoxDriver

    End Sub

    <TestCleanup()>
    Public Sub Termination()
        WebBrowser.Quit()
    End Sub

    ''' <summary>
    ''' Ensure that the page is presented
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub PageIsPresented()

        'Arrange & Act
        WebBrowser.Navigate.GoToUrl(AddCustomer.PageUrl)

        'Assert
        Assert.AreEqual(WebBrowser.Title, AddCustomer.PageTitle)

    End Sub

    ''' <summary>
    ''' Ensure when required fields are completed that we get to the success page
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub ValidCompletionOfFormGoesToNextPage()

        'Arrange
        WebBrowser.Navigate.GoToUrl(AddCustomer.PageUrl)
        SetCustomerName(WebBrowser, "Viv Richards")
        SetCustomerNumber(WebBrowser, "12345678")

        'Act
        AddCustomerClick(WebBrowser)

        'Assert
        Assert.AreEqual(WebBrowser.Title, "Success - Selenium sample")

    End Sub

    ''' <summary>
    ''' Ensure when required fields are not completed that we get validation errors
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub InvalidCompletionOfFormDisplaysErrors()

        'Arrange
        WebBrowser.Navigate.GoToUrl(AddCustomer.PageUrl)

        'Act
        AddCustomerClick(WebBrowser)

        'Assert
        Assert.AreEqual(AddCustomer.NumberOfErrors(WebBrowser), 2)

    End Sub

    ''' <summary>
    ''' Ensure required fields have aria required labels
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub RequiredFieldsContainAriaRequiredAttributes()

        'Arrange & Act
        WebBrowser.Navigate.GoToUrl(AddCustomer.PageUrl)

        'Assert
        Assert.IsTrue(Accessibility.AriaRequiredPresent(WebBrowser, "CustomerName"))
        Assert.IsTrue(Accessibility.AriaRequiredPresent(WebBrowser, "CustomerNumber"))

    End Sub



End Class
