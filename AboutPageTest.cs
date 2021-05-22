using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    

    public class AboutPageTest
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
        public void VerifyAboutPage()
        {
            driver.FindElement(By.XPath("//*[@id='top-navbar']/div[3]/div[2]/button")).Click();
            driver.FindElement(By.XPath("//*[@id='top-navbar']/div[3]/div[2]/ul/li[10]")).Click();
            string expectedTitle = "Contact us | C# Online Compiler | .NET Fiddle";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }
        

        [TearDown]

        public void TearDown()
            {
                driver.Quit();
            }
        
    }
}