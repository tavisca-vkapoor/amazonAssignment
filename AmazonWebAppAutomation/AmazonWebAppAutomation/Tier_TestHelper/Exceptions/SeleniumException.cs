using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebAppAutomation.Tier_TestHelper.Exceptions
{
    public class SeleniumException : Exception
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public SeleniumException() : base()
        {
            logger.Error("Selenium Excpetion");
        }

        public SeleniumException(string message)
            : base(message)
        {
            logger.Error(message);
            //screenshot
        }

        public SeleniumException(string message, Exception ex)
            : base(message, ex)
        {
            logger.Error(ex, message);
        }
    }
}
