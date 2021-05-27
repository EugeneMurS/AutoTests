using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class LogInFormTest: TestBase
    {
        [Test]
        public void VerifyLogInForm()
        {
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.Id("Email")).SendKeys("goluboglazaya.1997@mail.ru");
            Driver.FindElement(By.Id("Password")).SendKeys("password");
            Driver.FindElement(By.XPath("//div[@class='col-lg-5 col-md-5 col-sm-5 col-xs-5 text-right']")).Click();
            Thread.Sleep(400);
            Driver.FindElement(By.Id("account-display-name")).Click();
            Driver.FindElement(By.XPath("//a[@href='/Account/MyFiddles']")).Click();
            string expectedUrl = "https://dotnetfiddle.net/Account/MyFiddles";
            string actualUrl = Driver.Url;
            Assert.AreEqual (expectedUrl, actualUrl, "Not expected page's url after click 'MyFiddles'");
        }
    }
}