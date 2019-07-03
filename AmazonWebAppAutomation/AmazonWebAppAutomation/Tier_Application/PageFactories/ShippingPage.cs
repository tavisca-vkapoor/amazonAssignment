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
    public class ShippingPage : BasePage
    {
        private IWebDriver _webdriver;

        public ShippingPage()
        {
            _webdriver = SeleniumDriverUtils.Instance.Driver;

            PageFactory.InitElements(_webdriver, this);
        }

        #region ShippingPage
        [FindsBy(How = How.Id, Using = "enterAddressFullName")]
        IWebElement name;
        #endregion  

        [FindsBy(How = How.Id, Using = "enterAddressPhoneNumber")]
        IWebElement phoneNo;

        [FindsBy(How = How.Id, Using = "enterAddressPostalCode")]
        IWebElement postalCodes;

        [FindsBy(How = How.Id, Using = "enterAddressAddressLine1")]
        IWebElement addressLine1;

        [FindsBy(How = How.Name, Using = "shipToThisAddress")]
        IWebElement deliverToAddrss;

        public void AddShippingAddress(string fullName,String no,string postalCode,string addressLine1)
        {
            name.SendKeys(fullName);
            phoneNo.SendKeys(no);
            postalCodes.SendKeys(postalCode);
            this.addressLine1.SendKeys(addressLine1);
            deliverToAddrss.Click();
        }

    }
}
