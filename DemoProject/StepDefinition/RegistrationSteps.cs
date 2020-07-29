using DemoProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DemoProject.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }

        [When(@"I click on create Amazon account")]
        public void WhenIClickOnCreateAmazonAccount()
        {
            registrationPage.ClickOnCreateYourAmazonAccount1();

        }

        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.EnterYourName();
        }

        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmail();
        }

        [When(@"I create a password")]
        public void WhenICreateAPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I re-enter my password")]
        public void WhenIRe_EnterMyPassword()
        {
            registrationPage.ReEnterPassword();
        }


        [When(@"I click on create account")]
        public void WhenIClickOnCreateAccount()
        {
            registrationPage.ClickOnCreateYourAmazonAccount2();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            Assert.That(registrationPage.IsHelloDemoDisplayed);
        }
    }
}
   

