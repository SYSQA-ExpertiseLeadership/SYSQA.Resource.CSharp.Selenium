using NUnit.Framework;
using SYSQA.Resource.CSharp.Selenium.Example.PageObjects.SUT;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.Example.TestCases
{
    [TestFixture]
    public class ExampleTestClass
    {
        /*
         De TearDown methode wordt automatisch aangeroepen aan het einde van iedere testcase.
         Omdat we niet willen dat alle browser tabs open blijven staan gebruiken we de CloseBrowser methode.
             */
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
