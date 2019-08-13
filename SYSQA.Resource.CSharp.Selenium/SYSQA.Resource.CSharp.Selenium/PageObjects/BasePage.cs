using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SYSQA.Resource.CSharp.Selenium.Utilities;
using System;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects
{
    public abstract class BasePage
    {
        protected void WaitForElementToBeDisplayed(IWebElement element, int timeOut = 30)
        {
            var wait = new WebDriverWait(BrowserManager.Instance, TimeSpan.FromSeconds(timeOut));
            wait.Until(_ => element?.Displayed ?? false);
        }
        protected void WaitForElementToBeEnabled(IWebElement element, int timeOut = 30)
        {
            var wait = new WebDriverWait(BrowserManager.Instance, TimeSpan.FromSeconds(timeOut));
            wait.Until(_ => element?.Enabled ?? false);
        }
    }
}
