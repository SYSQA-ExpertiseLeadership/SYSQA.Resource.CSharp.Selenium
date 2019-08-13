namespace SYSQA.Resource.CSharp.Selenium.PageObjects.Template
{
    /*
    In deze klasse verzamelen we alle eigenschappen van de pagina die we willen weten.
    Voorbeelden van deze eigenschappen kunnen zijn:
    - Het aantal records in een lijst
    - De titel van de pagina
    - De zichtbaarheid van een specefieke knop
    */

    public partial class TemplatePage : BasePage
    {
        public bool TestEigenschap { get { return VoorbeeldDeclaratie.Displayed; } }
    }
}
