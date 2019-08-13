using OpenQA.Selenium;
using SYSQA.Resource.CSharp.Selenium.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.ExampleResult
{
    public partial class ExampleResultPage : BasePage
    {
        private IWebElement ResultCounter { get { return BrowserManager.TryFindElement(By.CssSelector("span.link-icon")); } }
    }
}
