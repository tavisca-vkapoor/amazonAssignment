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
    public class BasePage
    {
        private IWebDriver _driver = null;

        public string Title { get { return _driver.Title.ToString(); } }


        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        IWebElement addToCartButton;

        [FindsBy(How = How.Id, Using = "nav-cart")]
        IWebElement cart;

        public BasePage()
        {
            _driver = SeleniumDriverUtils.Instance.Driver;

            PageFactory.InitElements(_driver, this);

        }


        public void Launch(string url)
        {
            _driver = SeleniumDriverUtils.Instance.Driver;
            //_driver.Navigate().GoToUrl(url);
            _driver.Url = url;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            Console.WriteLine("DisposePage() called");
            SeleniumDriverUtils.Instance.Dispose();
        }

        public void AddToCart()
        {
            addToCartButton.Click();
        }

        public void GoToCart()
        {
            cart.Click();
        }
    }
}
