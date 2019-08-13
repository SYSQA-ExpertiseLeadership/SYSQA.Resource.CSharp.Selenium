using SYSQA.Resource.CSharp.Selenium.PageObjects.Example;
using SYSQA.Resource.CSharp.Selenium.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.SUT
{
    public class ExampleSUT : BasePage //System Under Test 
    {
        public ExamplePage GoToExamplePage() {
            BrowserManager.Instance.Navigate().GoToUrl("www.examplepage.com");
            return new ExamplePage();
        }
    }
}
