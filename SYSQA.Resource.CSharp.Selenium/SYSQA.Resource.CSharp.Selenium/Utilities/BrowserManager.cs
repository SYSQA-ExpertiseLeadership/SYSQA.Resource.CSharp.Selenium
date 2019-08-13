using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SYSQA.Resource.CSharp.Selenium.Utilities
{
    public static class BrowserManager
    {
        public static IWebDriver _driver;

        public static IWebDriver Instance
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                }
                return _driver;
            }
        }

        public static IWebElement TryFindElement(By by) {
            try
            {
                return Instance.FindElement(by);
            }
            catch (NoSuchElementException)
            {

                return null;
            }

        }
        public static void Quit()
        {
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}
