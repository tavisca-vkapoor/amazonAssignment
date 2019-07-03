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
    public class CartPage : BasePage
    {
        private IWebDriver _webdriver;

        public CartPage()
        {
            _webdriver = SeleniumDriverUtils.Instance.Driver;

            PageFactory.InitElements(_webdriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='proceedToCheckout")]
        IWebElement proceedToCheckout;

        private IWebElement quantityForProduct(string productNameOfProduct)
        {
            //span[@data-action='a-dropdown-button']
            return _webdriver.FindElement(By.XPath("//span[contains(text(),'"+ productNameOfProduct + "')]/ancestor::div[@class='a-row a-spacing-base a-spacing-top-base']//span[@data-action='a-dropdown-button']"));
        }

        private IWebElement quantityToBeAdd(int i)
        {
            return _webdriver.FindElement(By.XPath("//ul[@role='listbox']/li["+i+"]"));
        }

        public void UpdateQuantityForProduct(string productName,int productToBeAdd)
        {
            quantityForProduct(productName).Click();

            quantityToBeAdd(productToBeAdd).Click();
        }

    }
}
