
using OpenQA.Selenium;
using Payback_Po.apphooks;
using System;
using TechTalk.SpecFlow;

namespace Payback_Po.StepDefinition
{
    [Binding]
    public class RechargeStepDefinitions : ApplicationHooks
    {

        [Given(@"Open Browser  and Enter URL for the website")]
        public void GivenOpenBrowserAndEnterURLForTheWebsite()
        {

            //Launching Browser & App code is given in ApplicationHooks.cs file
            Console.WriteLine(ValidatePageTitle());
        }


        [Given(@"Click on login")]
        public void GivenClickOnLogin()
        {
            lp.loginButton();
            Thread.Sleep(3000);
        }

        [Given(@"Log in using Valid Inputs\.")]
        public void GivenLogInUsingValidInputs_()
        {

            lp.LoginUser();
            
            lp.LoginPassword();
            Thread.Sleep(15000);
            lp.loginButton1();
            Thread.Sleep(20000);
        }

        [Given(@"Click on Explore Menu")]
        public void GivenClickOnExploreMenu()
        {
            IWebElement exp = op.Explore();
            Hover(exp);

           


            Thread.Sleep(10000);

        }
        [When(@"click on Recharge")]
        public void WhenClickOnRecharge()
        {
            rp.Recharges();
            Thread.Sleep(7000);
        }

        [When(@"recharge page is displayed")]
        public void WhenRechargePageIsDisplayed()
        {
            Console.WriteLine(ValidatePageTitle());
        }

        [When(@"click on Mobile Recharge")]
        public void WhenClickOnMobileRecharge()
        {
            rp.Mbrecharge();
            Thread.Sleep(20000);
        }

        [When(@"User enters Mobile number ""([^""]*)"" and amount ""([^""]*)""")]
        public void WhenUserEntersMobileNumberAndAmount(string Mnumber, string ramount)
        {
            
            rp.Number(Mnumber);
            Thread.Sleep(1000);
            rp.Amount(ramount);
        }


        [When(@"click on checkbox")]
        public void WhenClickOnCheckbox()
        {
            Thread.Sleep(3000);
            rp.Check();
            
        }

        [When(@"click on place order")]
        public void WhenClickOnPlaceOrder()
        {
            Thread.Sleep(3000);
            rp.Placeorder();
           
        }

        [Then(@"User is able to recharge")]
        public void ThenUserIsAbleToRecharge()
        {
            Thread.Sleep(3000);
            CaptureScreenshot();
        }
    }
}
