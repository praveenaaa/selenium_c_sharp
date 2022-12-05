using OpenQA.Selenium;
using Payback_Po.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payback_Po.Pages
{
    public class Recharge : utility
    {
        private IWebDriver driver;

        private By recharge = By.XPath("//*[normalize-space(text())='Recharges']");

        private By mobilerecharge = By.XPath("//*[text()='Mobile Recharge']");

        private By dthrecharge = By.XPath("//*[text()='DTH']");

        private By checkbox = By.XPath("//*[text()='I agree to the ']");

        private By placeorder = By.XPath("//*[text()='Place Order']");

        

        private By mobilenumber = By.XPath("//*[@id='autocomplete-input']");

        private By amount = By.XPath("//*[@id='amountPlan']");



        public Recharge(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Recharges()
        {
            driver.FindElement(recharge).Click();
        }

        public void Mbrecharge()
        {
            string parentwindow = driver.CurrentWindowHandle;

            IList all_windows = driver.WindowHandles;
            foreach (string child_window in all_windows)
            {
                if(!parentwindow.Equals(child_window))
                {
                    driver.SwitchTo().Window(child_window);
                }
               
            }

            driver.FindElement(mobilerecharge).Click();
           
        }
        public void DTH()
        {
            driver.FindElement(dthrecharge).Click();
        }
        public void Check()
        {
            driver.FindElement(checkbox).Click();
        }

        public void Placeorder()
        {
            driver.FindElement(placeorder);
        }

        public void Number(string Num)
        {
            driver.FindElement(mobilenumber).SendKeys(Num);
        }
        public void Amount(string amt)
        {
            driver.FindElement(amount).SendKeys(amt);
        }



    }
}
