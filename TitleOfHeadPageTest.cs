using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class TitleOfHeadPageTest : TestBase
    {
        [Test]
        public void VerifyTitleOfHeadPage()
        {
            string expectedTitle = "C# Online Compiler | .NET Fiddle";
            string actualTitle = Driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}