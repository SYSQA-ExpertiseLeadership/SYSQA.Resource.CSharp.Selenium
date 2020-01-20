using OpenQA.Selenium;
using SYSQA.Resource.CSharp.Selenium.PageObjects;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleHome
{
    public partial class ExampleHomePage : BasePage
    {
        private IWebElement TopSearchButton { get { return BrowserManager.TryFindElement(By.CssSelector("div.pageloader__inner")); } }
        private IWebElement SearchBar { get { return BrowserManager.TryFindElement(By.CssSelector(".advanced-search__searchfield")); } }
    }
}
