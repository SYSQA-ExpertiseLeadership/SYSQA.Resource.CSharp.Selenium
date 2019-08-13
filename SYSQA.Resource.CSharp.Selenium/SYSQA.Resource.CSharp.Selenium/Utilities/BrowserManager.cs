using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SYSQA.Resource.CSharp.Selenium.Utilities
{
    /*
     
         */
    public static class BrowserManager
    {
        public static IWebDriver _driver;

        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// Zoek een WebElement op de pagina.
        /// wanneer je het element niet kan vinden geef dan niets terug.
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sluit de browser en onderliggende driver.
        /// De volgende keer dat we BrowserManager.Instance aanroepen wordt er een nieuwe browser geopent.
        /// </summary>
        public static void CloseBrowser()
        {
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}
