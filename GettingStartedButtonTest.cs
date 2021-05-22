using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    

    public class GettingStartedButtonTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl(@"https://dotnetfiddle.net");
        }

        [Test]
        public void VerifyGettingStartedButton()
        {
            driver.FindElement(By.XPath("//a[@href='/GettingStarted/']")).Click();
            string expectedUrl = "https://dotnetfiddle.net/GettingStarted/";
            string actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        

        [TearDown]

        public void TearDown()
            {
                driver.Quit();
            }
        
    }
}