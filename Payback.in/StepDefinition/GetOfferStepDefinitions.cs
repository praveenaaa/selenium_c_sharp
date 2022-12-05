/*
using NUnit.Framework;
using Payback_Po.apphooks;
using System;
using TechTalk.SpecFlow;

namespace Payback_Po.StepDefinition
{
    [Binding]
    public class GetOfferStepDefinitions : ApplicationHooks
    {
        [Given(@"Open Browser  Enter URL for the website")]
        public void GivenOpenBrowserEnterURLForTheWebsite()
        {
            Thread.Sleep(5000);
            string expectedTitle = "Largest Multi-brand Loyalty Program in India - PAYBACK";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            lp.loginButton();
        }

        [When(@"enters the login details")]
        public void WhenEntersTheLoginDetails()
        {
            Thread.Sleep(5000);
            lp.LoginUser();
            lp.LoginPassword();
            Thread.Sleep(20000);
            lp.loginButton1();
            Thread.Sleep(20000);

        }

        [When(@"go to explore menu")]
        public void WhenGoToExploreMenu()
        {
              IWebElement exp = op.Explore();
            Hover(exp);




            Thread.Sleep(10000);
           
        }

        [When(@"Click on Offers")]
        public void WhenClickOnOffers()
        {
            op.Offer();
        }
        [When(@"click on GetOffeer")]
        public void WhenClickOnGetOffeer()
        {
            op.getOffer();
        }

        [Then(@"GetOffer page is displayed")]
        public void ThenGetOfferPageIsDisplayed()
        {

            string expectedTitle = "Online Shopping Offers, Best Deals of the Day - PAYBACK";
            Thread.Sleep(5000);
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

        }
    }
}
*/