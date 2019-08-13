using SYSQA.Resource.CSharp.Selenium.PageObjects;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleResult
{
    public partial class ExampleResultPage : BasePage
    {
        public string ResultCounterText { get { return ResultCounter.Text; } }
    }
}
