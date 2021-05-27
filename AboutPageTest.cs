using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class AboutPageTest : TestBase
    {
        [Test]
        public void VerifyAboutPage()
        {
            Driver.FindElement(By.XPath("//*[@id='top-navbar']/div[3]/div[2]/button")).Click();
            Driver.FindElement(By.XPath("//*[@id='top-navbar']/div[3]/div[2]/ul/li[10]")).Click();
            string expectedTitle = "Contact us | C# Online Compiler | .NET Fiddle";
            string actualTitle = Driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Not expected title for contact us page");
        }
    }
}