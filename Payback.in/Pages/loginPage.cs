using OpenQA.Selenium;
using Payback_Po.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payback_Po.Pages
{

    public class loginPage : utility
    {
        private IWebDriver driver;
       


        public loginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void loginButton()
        {
            IWebElement login = driver.FindElement(By.LinkText("Login"));
            login.Click();
        }
        public void LoginUser()
        {
            IWebElement usernameValue = driver.FindElement(By.Name("card_number"));
            usernameValue.SendKeys("8579066180");


        }


        public void LoginPassword()
        {
            IWebElement passwordText = driver.FindElement(By.Name("pin_number"));
            passwordText.SendKeys("0658");

        }
      
        public HomePage loginButton1()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@class='btn pb-login-submit red-button']"));
            loginButton.Click();
            return new HomePage(driver);
        }

    }
}
