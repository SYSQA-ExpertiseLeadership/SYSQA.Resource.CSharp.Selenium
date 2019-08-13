namespace SYSQA.Resource.CSharp.Selenium.PageObjects.Example
{
    public partial class ExamplePage : BasePage
    {
        public ExamplePage()
        {
            WaitForElementToBeDisplayed(test);
        }

        public ExamplePage DoSomeThing()
        {
            test.Click();
            return this;
        }
    }
}
