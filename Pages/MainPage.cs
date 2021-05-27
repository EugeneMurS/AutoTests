using System;
using System.Threading;
using OpenQA.Selenium;

namespace Selenium.Pages
{
	public class MainPage : PageBase {
		public MainPage(IWebDriver driver) : base(driver) { }

		public void Login(string email, string password)
		{
			FindLoginButton().Click();
			FindEmailField().SendKeys(email);
			FindPasswordField().SendKeys(password);
			FindLogInButton().Click();

			//end of login operation - appeared element with user's name
			WaitForElement(_accountDisplayNameLocator, TimeSpan.FromMilliseconds(400));
		}

		public MyFiddlesPage OpenMyFiddles() {
			FindAccountNameButton().Click();
			FindMyFiddlesButton().Click();
			return new MyFiddlesPage(_driver);
		}

		private readonly By _accountDisplayNameLocator = By.Id("account-display-name");
		private IWebElement FindLoginButton() => _driver.FindElement(By.Id("login-button"));
		private IWebElement FindEmailField() => _driver.FindElement(By.Id("Email"));
		private IWebElement FindPasswordField() => _driver.FindElement(By.Id("Password"));
		private IWebElement FindLogInButton() => _driver.FindElement(By.CssSelector("button[type='submit']"));
		private IWebElement FindAccountNameButton() => _driver.FindElement(_accountDisplayNameLocator);
		private IWebElement FindMyFiddlesButton() => _driver.FindElement(By.XPath("//a[@href='/Account/MyFiddles']"));
	}
}