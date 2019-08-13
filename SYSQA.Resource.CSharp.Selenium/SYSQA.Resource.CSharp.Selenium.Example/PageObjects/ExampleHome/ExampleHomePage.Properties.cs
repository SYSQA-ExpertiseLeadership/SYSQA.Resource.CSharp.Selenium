using SYSQA.Resource.CSharp.Selenium.PageObjects;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleHome
{
    public partial class ExampleHomePage : BasePage
    {
        public bool TopSearchButtonIsClickable { get { return TopSearchButton.Enabled; } }
    }
}
