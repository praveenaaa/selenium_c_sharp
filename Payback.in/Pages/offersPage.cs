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
    public class offersPage : utility
    {

        private IWebDriver driver;

      

        private By offer = By.XPath("//*[normalize-space(text())='Offers']");
        private By redeem = By.XPath("//*[normalize-space(text())='Redeem']");
        private By getofferbutton = By.XPath("//*[text()='Get Offer']");
        private By explore = By.XPath("//*[normalize-space(text())='Explore']");



        public offersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        
        public IWebElement Explore()
        {
            return driver.FindElement(explore);
        }

        /*
        public void Explore()
        {
            IWebElement explore = driver.FindElement(By.XPath("//*[normalize-space(text())='Explore']"));
            Actions action = new Actions(driver);
            action.MoveToElement(explore).Perform(); 
            Thread.Sleep(1000);
         }
        
      */

       public void Offer()
       {
            Thread.Sleep(1000);
            driver.FindElement(offer).Click();


           
            
        }
      

     
        public void Redeem()
        {
            driver.FindElement(redeem).Click();
            Thread.Sleep(5000);
        }

        public void getOffer()
        {
            driver.FindElement(getofferbutton).Click();
        }
      


    }
}

