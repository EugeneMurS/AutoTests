using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Pages
{
	public abstract class PageBase
	{
		protected readonly IWebDriver _driver;

		protected PageBase(IWebDriver driver)
		{
			_driver = driver;
		}

		public string GetUrl()
		{
			return _driver.Url;
		}

		public string GetTitle()
		{
			return _driver.Title;
		}

		public IWebElement WaitForElement(By by, TimeSpan timeout)
		{
			var wait = new WebDriverWait(_driver, timeout);
			wait.Message = $"Wait for element '{by}'";
			return wait.Until((driver) => driver.FindElement(by));
		}
	}
}