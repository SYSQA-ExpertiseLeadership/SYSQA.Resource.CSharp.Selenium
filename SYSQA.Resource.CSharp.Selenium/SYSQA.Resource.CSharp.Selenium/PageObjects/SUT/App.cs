using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.SUT
{
    public class App : BasePage //System Under Test 
    {
        public ExampleHomePage GoToHomePage() {
            BrowserManager.Instance.Navigate().GoToUrl("https://www.sysqa.nl/");
            return new ExampleHomePage();
        }
    }
}
