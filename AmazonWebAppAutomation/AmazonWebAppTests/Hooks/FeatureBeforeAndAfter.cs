using AmazonWebAppAutomation;
using AmazonWebAppAutomation.Tier_Application.PageFactories;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AmazonWebAppTests.Hooks
{
    [Binding]
    public sealed class FeatureBeforeAndAfter
    {
        [BeforeFeature]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Debug("Feature Title: " + FeatureContext.Current.FeatureInfo.Title);
            logger.Debug("Feature Tags: " + FeatureContext.Current.FeatureInfo.Tags);

        }

        [AfterFeature]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            AmazonWebAppAutomationMain.PageFactory<BasePage>.Actions.Quit();
        }
    }
}
