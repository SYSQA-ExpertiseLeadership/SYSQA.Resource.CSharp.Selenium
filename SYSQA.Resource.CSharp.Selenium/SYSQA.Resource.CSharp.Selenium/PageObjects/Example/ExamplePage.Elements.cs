using OpenQA.Selenium;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.Example
{
    public partial class ExamplePage : BasePage
    {
        private IWebElement test { get { return BrowserManager.Instance.FindElement(By.CssSelector("")); } }
    }
}
