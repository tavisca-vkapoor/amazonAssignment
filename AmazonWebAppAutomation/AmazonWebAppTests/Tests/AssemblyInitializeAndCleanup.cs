using System;
using AmazonWebAppAutomation;
using AmazonWebAppAutomation.Tier_Application.PageFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace AmazonWebAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public void setup()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string defaultUrl = "https://www.amazon.in/ap/signin"

            string username = "";
            string password = "";

            AmazonWebAppAutomationMain.PageFactory<LoginPage>.Actions.Login(username, password);
        }
    }
}
