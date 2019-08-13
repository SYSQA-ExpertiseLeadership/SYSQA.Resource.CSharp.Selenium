using SYSQA.Resource.CSharp.Selenium.PageObjects.ExampleResult;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.ExampleHome
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
