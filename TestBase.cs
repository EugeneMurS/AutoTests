using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
	public abstract class TestBase
	{
		protected IWebDriver Driver;

		[SetUp]
		public void Setup() {
			Driver = new ChromeDriver();
			Driver.Manage().Window.Maximize();
			Driver.Navigate().GoToUrl(@"https://dotnetfiddle.net");
		}

		[TearDown]
		public void TearDown() {
			Driver.Quit();
		}
	}
}