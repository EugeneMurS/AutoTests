using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    

    public class TitleOfHeadPageTest
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
        public void VerifyTitleOfHeadPage()
        {
            string expectedTitle = "C# Online Compiler | .NET Fiddle";
            string actuaiTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actuaiTitle);
        }
        

        [TearDown]

        public void TearDown()
            {
                driver.Quit();
            }
        
    }
}