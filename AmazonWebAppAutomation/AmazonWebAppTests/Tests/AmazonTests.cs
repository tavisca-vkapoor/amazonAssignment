using System;
using AmazonWebAppAutomation;
using AmazonWebAppAutomation.Tier_Application.PageFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AmazonWebAppAutomation.AmazonWebAppAutomationMain;

namespace AmazonWebAppTests.Tests
{
    [TestClass]
    public class AmazonTests
    {
        [TestMethod]
        public void VerifyPlacingOfOrder()
        {
            string searchString = "apple iphone x";

            PageFactory<SearchPage>.Actions.Search(searchString);

            PageFactory<SearchPage>.Actions.OpenIphone64GBInNexPage();

            PageFactory<BasePage>.Actions.AddToCart();

            PageFactory<BasePage>.Actions.GoToCart();

            PageFactory<CartPage>.Actions.UpdateQuantityForProduct("Apple iPhone X", 2);

            PageFactory<ShippingPage>.Actions.AddShippingAddress("vishal", "7777788888", "411028", "agrostar espace");
        }
    }
}
