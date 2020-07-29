using DataDrivenWithExample.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExample.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            registrationPage.NavigateToWebsite(url);
        }

        
        [When(@"I enter a username ""(.*)""")]
        public void WhenIEnterAUsername(string username)
        {
            registrationPage.EnterUsename(username);
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string email)
        {
            registrationPage.EnterEmail(email);
        }
        
        [When(@"I create a password ""(.*)""")]
        public void WhenICreateAPassword(string password)
        {
            registrationPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            registrationPage.ClickSignUp();
        }
    }
}
