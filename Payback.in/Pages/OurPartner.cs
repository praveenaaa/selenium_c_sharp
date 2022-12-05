using OpenQA.Selenium;
using Payback_Po.Utility;

namespace Payback_Po
{
    public class OurPartner : utility
    {
        private IWebDriver driver;

        private By ourpartner = By.XPath("//*[normalize-space(text())='Our Partners']");

        private By detailsbutton = By.XPath("//*[normalize-space(text())='Details']");

        private By redeempoints = By.XPath("//*[normalize-space(text())='Redeem']");

        private By shop = By.XPath("//a[@data-title='Flipkart'][normalize-space()='Shop']");


        public OurPartner(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Ourpartners()
        {
            
            driver.FindElement(ourpartner).Click();
        }
        public void Details()
        {
            Thread.Sleep(1000);
            driver.FindElement(detailsbutton).Click();

        }
        public void RedeemPoints()
        {
            Thread.Sleep(1000);
            driver.FindElement(redeempoints).Click();
        }

        public void Shop()
        {
            Thread.Sleep(1000);
            driver.FindElement(shop).Click();
        }


    }
}
