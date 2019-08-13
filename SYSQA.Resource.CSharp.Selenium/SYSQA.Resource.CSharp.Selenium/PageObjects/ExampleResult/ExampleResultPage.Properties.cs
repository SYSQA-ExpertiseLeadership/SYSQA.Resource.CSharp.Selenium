using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.ExampleResult
{
    public partial class ExampleResultPage : BasePage
    {
        public string ResultCounterText { get { return ResultCounter.Text; } }
    }
}
