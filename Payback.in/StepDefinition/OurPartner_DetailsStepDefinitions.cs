
/*

using NUnit.Framework;
using OpenQA.Selenium;
using Payback_Po.apphooks;
using System;
using TechTalk.SpecFlow;

namespace Payback_Po.StepDefinition
{
    [Binding]
    public class OurPartner_DetailsStepDefinitions : ApplicationHooks
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

           // op.Explore();


           Thread.Sleep(10000);
            
        }

        [Given(@"Click on Our Partners")]
        public void GivenClickOnOurPartners()
        {
           
            ourP.Ourpartners();
            Thread.Sleep(5000);
           

           
        }

        
        [When(@"Click on Details nutton")]
        public void WhenClickOnDetailsNutton()
        {
            Thread.Sleep(1000);
            ourP.Details();
        }
        

        [Then(@"User is navigated to details page of the selected Business partner\.")]
        public void ThenUserIsNavigatedToDetailsPageOfTheSelectedBusinessPartner_()
        {
            string expectedTitle = "Amex PAYBACK Credit Card Offers: dining, travel & shopping";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        
        [When(@"Click on Redeeem points button\.")]
        public void WhenClickOnRedeeemPointsButton_()
        {
            ourP.RedeemPoints();
            Thread.Sleep(1000);
        }

        [Then(@"user is navigated redeem points page")]
        public void ThenUserIsNavigatedRedeemPointsPage()
        {
            Console.WriteLine(ValidatePageTitle());
        }

        

        [When(@"click on shopping button")]
        public void WhenClickOnShoppingButton()
        {
            ourP.Shop();
            Thread.Sleep(1000);
        }

        [Then(@"user is navigated to shopping page")]
        public void ThenUserIsNavigatedToShoppingPage()
        {
            Console.WriteLine(ValidatePageTitle());
        }


    }
}
*/
