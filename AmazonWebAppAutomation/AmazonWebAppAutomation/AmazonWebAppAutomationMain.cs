using AmazonWebAppAutomation.Tier_Application.PageFactories;
using AmazonWebAppAutomation.Tier_TestHelper.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AmazonWebAppAutomation.AmazonWebAppAutomationMain;

namespace AmazonWebAppAutomation
{
    public class AmazonWebAppAutomationMain
    {
        static AmazonWebAppAutomationMain()
        {
            //if (FileLogger.Instance == null) FileLogger.Instance.LoadNLogConfig();
        }

        public static class PageFactory<T> where T : BasePage, new()
        {
            private static T _page;

            public static T Actions
            {
                get
                {
                    if (_page == null)
                        _page = new T();

                    PageFactory.InitElements(SeleniumDriverUtils.Instance.Driver, _page);

                    return _page;
                }
            }


        }
    }
}
