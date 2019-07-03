using AmazonWebAppAutomation.Tier_TestHelper.Exceptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebAppAutomation.Tier_TestHelper.Selenium
{
    public class SeleniumDriverUtils
    {
        #region Variables
        private static SeleniumDriverUtils mInstance;
        private IWebDriver _driver = null;
        private int _implicitWaitinSec = 30;
        #endregion

        public static SeleniumDriverUtils Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new SeleniumDriverUtils();
                }
                return mInstance;
            }
        }



        #region Public methods
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }


        public void Dispose()
        {
            if (_driver != null)
            {
                _driver.Dispose();
                mInstance = null;
                _driver = null;
            }
        }
        #endregion

        #region Private methods
        private void LaunchBrowser(BrowserType browserType)
        {

            switch (browserType)
            {

                case BrowserType.Chrome:

                    TimeSpan ts = new TimeSpan(0, 0, _implicitWaitinSec);

                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                    _driver.Manage().Cookies.DeleteAllCookies();
                    _driver.Manage().Timeouts().ImplicitWait = ts;
                    break;

               default:
                    throw new SeleniumException("Incorrect Browser type provided, supported Browser {Chrome}");
            }
            #endregion
        }

        public enum BrowserType
        {
            InternetExplorer,
            Chrome
        }
    }
}
