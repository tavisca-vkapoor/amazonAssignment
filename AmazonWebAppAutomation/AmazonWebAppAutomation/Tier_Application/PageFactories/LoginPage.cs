using AmazonWebAppAutomation.Tier_TestHelper.Selenium;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmazonWebAppAutomation.Tier_Application.PageFactories
{
    public class LoginPage : BasePage
    {
        private IWebDriver _webdriver;

        public LoginPage()
        {
            _webdriver = SeleniumDriverUtils.Instance.Driver;

            PageFactory.InitElements(_webdriver, this);
        }

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "ap_password")]
        private IWebElement pwd;

        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement continueButton;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement loginButton;

        public void Login(string username,string password)
        {
            email.Clear();
            email.SendKeys(username);
            continueButton.Click();
            pwd.Clear();
            pwd.SendKeys(password);
            loginButton.Click();
        }
    }
}
