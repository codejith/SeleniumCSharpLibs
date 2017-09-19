using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace Selenium.lro.Selenium
{
    /// <summary>
    /// Utility Class help to create a browser to maniplulate by selenium.
    /// </summary>
    public class Browsers
    {

        /// <summary>
        /// List of Browsers supported by the test
        /// </summary>
        public enum Browser
        {
            /// <summary>
            /// Microsoft Edge
            /// </summary>
            Edge = 0,

            /// <summary>
            /// Google Chrome
            /// </summary>
            Chrome,

            /// <summary>
            /// Mozilla FireFox
            /// </summary>
            FireFox,

            /// <summary>
            /// Internet Explorer
            /// </summary>
            InternetExplorer
        }

        public const Browser defautBrowser = Browser.Chrome;
        public static TimeSpan defaultPageLoadTime = TimeSpan.FromSeconds(30);
        public static TimeSpan defaultJavaScriptLoadTime = TimeSpan.FromSeconds(60);
        public static TimeSpan defaultPageReadyWait = TimeSpan.FromSeconds(15);


        public static Browser GetBrowser(string inBrowserName)
        {
            inBrowserName = inBrowserName.Trim();
            if (!Enum.TryParse(inBrowserName, out Browser outDetctedBrowser))
            {
                outDetctedBrowser = defautBrowser;
            }

            return outDetctedBrowser;
        }

        public static IWebDriver CreateNewBrowserInstance(ITestConfiguration configuration)
        {
            var capabilities = new DesiredCapabilities();
            IWebDriver outDriver;

            switch(configuration.browser)
            {
                case Browser.Chrome:
                    configuration.TestContext?.WriteLine("Creating google chrome instance");
                    var newBroswerInstance = new ChromeOptions();
                    newBroswerInstance.AddArgument("-incognito");
                    newBroswerInstance.AddArgument("--start-maximized");
                    outDriver = new ChromeDriver();
                    break;
            }

        }
    }
}
