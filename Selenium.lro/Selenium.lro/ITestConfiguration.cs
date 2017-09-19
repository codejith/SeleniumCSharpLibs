using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium.lro
{
    interface ITestConfiguration
    {
         TestContext TestContext { get; }

         TimeSpan PageLoadWait { get; }

         string initialUrl { get; }
        
         
    }
}
