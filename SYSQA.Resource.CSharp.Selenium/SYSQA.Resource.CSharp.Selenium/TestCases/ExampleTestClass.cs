using NUnit.Framework;
using SYSQA.Resource.CSharp.Selenium.PageObjects.Example;
using SYSQA.Resource.CSharp.Selenium.PageObjects.SUT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSQA.Resource.CSharp.Selenium.TestCases
{
    [TestFixture]
    public class ExampleTestClass
    {
        [TestCase]
        public void First_Test_Should()
        {
            //Arrange
            var app = new ExampleSUT()
                .GoToExamplePage()
                .DoSomeThing();
            //Act

            //Assert
        }

    }
}
