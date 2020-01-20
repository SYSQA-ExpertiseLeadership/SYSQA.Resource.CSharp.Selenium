using SYSQA.Resource.CSharp.Selenium.PageObjects;

namespace SYSQA.Resource.CSharp.Selenium.Example.PageObjects.ExampleResult
{
    /*
        In deze klasse verzamelen we alle handelingen die we op een pagina kunnen uitvoeren.
        Voorbeelden van handelingen kunnen zijn:
         - Het zoeken naar een item,
         - Het invullen en versturen van een formulier
         - Het navigeren naar een andere pagina

        Door deze handelingen in het pageobject te definieren hopen we twee dingen te berijken:
         - De testcase is leesbaarder omdat we al het klikken en typen een laag dieper doen
         - Wanneer de applicatie verandert kunnen we één methode aanpassen 
            en alle tests zouden weer moeten werken. 
        */
    public partial class ExampleResultPage : BasePage
    {
        public ExampleResultPage() {
            /*
             Het is niet verplicht om je pageobject een constructor te geven.
             In dit voorbeeld gebruik ik de constructor om de aanwezigheid van 
             een webelement (en dus de rest van de pagina) te verifiëren voor ik
             de test verder laat gaan.
             */
            WaitForElementToBeDisplayed(ResultCounter);
        }
    }
}
