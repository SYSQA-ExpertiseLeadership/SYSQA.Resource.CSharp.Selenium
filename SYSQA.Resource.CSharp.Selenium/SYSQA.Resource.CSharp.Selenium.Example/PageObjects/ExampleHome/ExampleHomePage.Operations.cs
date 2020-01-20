using SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleResult;
using SYSQA.Resource.CSharp.Selenium.PageObjects;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleHome
{
    public partial class ExampleHomePage : BasePage
    {
        public ExampleHomePage()
        {
            WaitForElementToBeDisplayed(TopSearchButton);
        }

        public ExampleResultPage SearchString(string searchTerm)
        {
            WaitForElementToBeEnabled(TopSearchButton);
            TopSearchButton.Click();
            WaitForElementToBeDisplayed(SearchBar);
            SearchBar.SendKeys(searchTerm);
            SearchBar.Submit();
            return new ExampleResultPage();
        }
    }
}
