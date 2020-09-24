# SYSQA.Resource.CSharp.Selenium

## Doel

Met deze resource proberen we twee dingen te berijken

1. Het bieden van een begin project om de opstart fase van een nieuw test script te versnellen
1. Het beschijven en uitleggen van één implementatie van het `Page-Object Model` om zo bij te dragen aan een overzichtelijk en onderhoudbaar Selenium C# project. 

## Belangrijk om te weten

Gedurende iedere stap in een project worden er keuzes gemaakt. Voor sommige dingen is het belangrijk om vooraf te weten waarom bepaalde keuzes zijn gemaakt.

Dit is een kort overzicht van de redenatie achter een aantal belangrijke keuzes.

### Visual Studio Code als IDE
Dit project is opgezet met en beschreven voor het gebruik van Visual Studo Code. Dit is de opensource versie van Microsofts bekende IDE Visual Studio.

Dit heeft een aantal voordelen, maar ook veel nadelen:
* Voordelen
    * Visual Studo Code doet minder voor ons op de achtergrond. Hierdoor hebben we meer inzicht in wat er precies met ons project gebeurt
    * Visual Studo Code heeft veel extenties om de IDE naar onze wensen aan te passen
    * Het dwingt je relatief snel iets van de command line te leren
* Nadelen
    * Het dwingt je relatief snel iets van de command line te leren
    * Extenties zijn vaak ook open source projecten en niet altijd even feature complete
    * Veel handelingen (zoals het aanmaken van een solution, of het installeren van een NuGet package) zijn veel intuïtiever in Visual Studio.
    * VSCode is minder eenvoudig gedocumenteerd online

    Voor beginners die een privé of opensource project willen starten is het aan te raden te kijken naar de `community` versie van [Visual Studio](https://visualstudio.microsoft.com/vs/community/) als een vriendelijker alternatief. Voor comerciele projecten zul je echter een licentie aan moeten schaven.

## Voorbereiding
De volgende stappen moet je nemen voor dat je aan dit project kunt beginnen.
* Intalleer de benodigde software
    * [Download en installeer Visual Studio Code (VSCode)](https://code.visualstudio.com/)
    * [Download en installeer de aanbevolen versie van dotnet framework](https://dotnet.microsoft.com/download/dotnet-framework/net47)
* Clone de gitrepository of [download de zip hier](https://github.com/SYSQA-ExpertiseLeadership/SYSQA.Resource.CSharp.Selenium/archive/master.zip)
* Ga naar de `.vscode` folder en open de `IDE.code-workspace` file met vs code.

<img src="./resources/InstallExtentions.gif">

* Ga naar de test window en druk op `Reload Test` om te kijken of de voorbeeld test succesvol gevonden wordt.


<img src="./resources/ReloadTests.gif">

Als de tests succesvol draaien ben je klaar om het project uit te breiden met jou eigen testcases.

Heb je problemen? neem dan contact op met één van de maintainers van dit project.

## Meer informatie

Voor meer informatie over hoe het project werkt kun je kijken naar de comments die in de .cs files geschreven zijn.

Meer informatie over waarom bepaalde keuzes gemaakt zijn kun je vinden in de [wiki](https://github.com/SYSQA-ExpertiseLeadership/SYSQA.Resource.CSharp.Selenium/wiki). Mis je informatie of heb je specifieke vragen? Bel,Mail of maak een [github issue](https://github.com/SYSQA-ExpertiseLeadership/SYSQA.Resource.CSharp.Selenium/issues) aan we staan altijd open voor vragen en feedback.

## Tips

* Als een verandering niet gelijk doorgevoerd lijkt te worden probeer dan VSCode een keer te refreshen. De toetsencombinatie `Ctrl+R` is een snelle optie.

