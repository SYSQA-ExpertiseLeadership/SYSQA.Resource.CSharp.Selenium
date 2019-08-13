using NUnit.Framework;
using SYSQA.Resource.CSharp.Selenium.PageObjects.SUT;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.TestCases
{
    [TestFixture]
    public class ExampleTestClass
    {
        [TearDown]
        public void TearDownMethod()
        {
            BrowserManager.CloseBrowser();
        }

        [TestCase]
        public void Search_Operation_Should_Return_Expected_Amount_Of_Results()
        {
            //Arrange
            
            //Act
            var page = new ExampleSUT()
                .GoToHomePage()
                .SearchString("Tester");
            
            //Assert
            Assert.That(page.ResultCounterText.Contains("10"));
        }
    }
}
