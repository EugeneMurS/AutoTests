using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    

    public class LogInFormTest
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
        public void VerifyLogInForm()
        {
            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("goluboglazaya.1997@mail.ru");
            driver.FindElement(By.Id("Password")).SendKeys("password");
            driver.FindElement(By.XPath("//div[@class='col-lg-5 col-md-5 col-sm-5 col-xs-5 text-right']")).Click();
            Thread.Sleep(400);
            driver.FindElement(By.Id("account-display-name")).Click();
            driver.FindElement(By.XPath("//a[@href='/Account/MyFiddles']")).Click();
            string expectedUrl = "https://dotnetfiddle.net/Account/MyFiddles";
            string actualUrl = driver.Url;
            Assert.AreEqual (expectedUrl, actualUrl);

        }

        [TearDown]

        public void TearDown()
            {
                driver.Quit();
            }
        
    }
}