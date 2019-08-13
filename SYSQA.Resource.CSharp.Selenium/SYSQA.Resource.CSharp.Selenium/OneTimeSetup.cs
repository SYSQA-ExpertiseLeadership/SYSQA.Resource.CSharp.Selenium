using NUnit.Framework;

namespace Tests
{
    public class OneTimeSetup
    {
        /* 
        Plaats hier code die voor iedere test run moet draaien.
        Denk hierbij aan voorbeelden als:
            * Het starten van een specefieke applicatie
            * Het verbinden met een database
            * Het aanmaken van een account die in alle testgevallen gebruikt gaat worden
        */
        [OneTimeSetUp]
        public void Setup()
        {
        }
        /* 
        Plaats hier code die na ieder etest run moet draaien.
        Denk hierbij aan voorbeelden als:
            * Het opruimen van je testdatabase
            * Het opsturen van verzamelde data naar een externe applicatie
            * Het verwijderen van een gebruikt test account
        */
        [OneTimeTearDown]
        public void TearDown()
        {
        }
    }
}