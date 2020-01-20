using OpenQA.Selenium;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.Template
{
    /*
    In deze klasse verzamelen we alle webelementen waar we op deze pagina mee willen werken.

    Door ze private te maken weten we dat ze niet buiten het pageobject gebruikt kunnen worden.
    Het aanpassen van de selector geldt dan direct voor de hele test suite.

    Door ze in deze gedeeltelijke klasse te plaatsen kunnen we de selectoren snel vinden wanneer 
    een verandering nodig is.
    */
    public partial class TemplatePage : BasePage
    {
        private IWebElement VoorbeeldDeclaratie { get { return BrowserManager.TryFindElement(By.CssSelector("")); } }
    }
}
