using NUnit.Framework;
using SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleHome;
using SYSQA.Resource.CSharp.Selenium.PageObjects;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.SUT
{
    public class ExampleSUT : BasePage //System Under Test 
    {
        [TearDown]
        public void TearDownMethod()
        {
            BrowserManager.CloseBrowser();
        }

        public ExampleHomePage GoToHomePage() {
            BrowserManager.Instance.Navigate().GoToUrl("https://www.sysqa.nl/");
            return new ExampleHomePage();
        }
    }
}
