using DataDriven.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDriven.StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }



        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            signUpPage.NavigateToWebsite(url);
        }

        
        [When(@"I enter a username ""(.*)""")]
        public void WhenIEnterAUsername(string username)
        {
            signUpPage.EnterUsename(username);
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string email)
        {
            signUpPage.EnterEmail(email);
        }
        
        [When(@"I enter a password ""(.*)""")]
        public void WhenIEnterAPassword(string password)
        {
            signUpPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickSignUp();
        }
        
        [Then(@"I should be registered and logged in with my username displayed")]
        public void ThenIShouldBeRegisteredAndLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(signUpPage.IsConfirmUsernameDisplayed);
        }
    }
}
