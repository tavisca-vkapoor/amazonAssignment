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
    public class SearchPage : BasePage
    {
        private IWebDriver _webdriver;

        public SearchPage()
        {
            _webdriver = SeleniumDriverUtils.Instance.Driver;

            PageFactory.InitElements(_webdriver, this);
        }

        #region SearchPage
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        IWebElement searchTextBox;
        #endregion  

        [FindsBy(How = How.XPath, Using = "//span[@title='Apple iPhone X (64GB) - Silver']")]
        IWebElement appleIphoneX64GbSilver;

        [FindsBy(How = How.Id, Using = "nav-search-submit-text]")]
        IWebElement goButton;

        public void Search(string searchString)
        {
            searchTextBox.SendKeys(searchString);
        }

        public void OpenIphone64GBInNexPage()
        {
            appleIphoneX64GbSilver.SendKeys(Keys.Control + "t");
            goButton.Click();
        }
    }
}
