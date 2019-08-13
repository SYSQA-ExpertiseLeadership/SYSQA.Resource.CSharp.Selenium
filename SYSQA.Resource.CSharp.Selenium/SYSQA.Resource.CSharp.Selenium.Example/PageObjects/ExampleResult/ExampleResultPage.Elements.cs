using OpenQA.Selenium;
using SYSQA.Resource.CSharp.Selenium.PageObjects;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleResult
{
    public partial class ExampleResultPage : BasePage
    {
        private IWebElement ResultCounter { get { return BrowserManager.TryFindElement(By.CssSelector("span.link-icon")); } }
    }
}
