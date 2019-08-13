using SYSQA.Resource.CSharp.Selenium.PageObjects.Template;
using SYSQA.Resource.CSharp.Selenium.Utilities;

namespace SYSQA.Resource.CSharp.Selenium.PageObjects.SUT
{
    /*
     Dit is het enige PageObject die we in onze tests instancieren.
     Het geeft ons de kans om de start van de applicatie voor te bereiden waar nodig.
     vanuit hier gaan we direct naar de pagina waar onze test begint en geven een object dat die pagina representeerd.
         */
    public class ExampleApp
    {
        public TemplatePage GoToHomePage()
        {
            BrowserManager.Instance.Navigate().GoToUrl("https://www.sysqa.nl/");
            return new TemplatePage();
        }
    }
}