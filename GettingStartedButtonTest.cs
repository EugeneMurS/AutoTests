using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class GettingStartedButtonTest : TestBase
    {
        [Test]
        public void VerifyGettingStartedButton()
        {
            Driver.FindElement(By.XPath("//a[@href='/GettingStarted/']")).Click();
            string expectedUrl = "https://dotnetfiddle.net/GettingStarted/";
            string actualUrl = Driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }
    }
}