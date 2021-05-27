using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;

namespace Selenium
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class LogInFormTest: TestBase
    {
        [Test]
        public void VerifyLogInForm()
        {
            MainPage mainPage = new MainPage(Driver);
            mainPage.Login("goluboglazaya.1997@mail.ru", "password");

            MyFiddlesPage myFiddlesPage = mainPage.OpenMyFiddles();
            string expectedUrl = "https://dotnetfiddle.net/Account/MyFiddles";
            Assert.AreEqual (expectedUrl, myFiddlesPage.GetUrl(), "Not expected page's url after click 'MyFiddles'");
        }
    }
}