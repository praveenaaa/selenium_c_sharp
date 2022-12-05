using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Payback_Po.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payback_Po.Pages
{
    public class HomePage : utility
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        
     }
}
