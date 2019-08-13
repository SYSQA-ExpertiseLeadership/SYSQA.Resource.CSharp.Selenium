using SYSQA.Resource.CSharp.Selenium.PageObjects.Template;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.SUT
{
    public class ExampleApp
    {
        public TemplatePage GoToHomePage()
        {
            BrowserManager.Instance.Navigate().GoToUrl("https://www.sysqa.nl/");
            return new TemplatePage();
        }
    }
}