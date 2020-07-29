using MyFirstProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace MyFirstProject.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {

        SignUpPage signUpPage;


        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }



        [Given(@"I nagivate to Angularjs")]
        public void GivenINagivateToAngularjs()
        {
            signUpPage.NavigateToWebsite();
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickOnSignUp();
        }
        
        [When(@"I enter a username")]
        public void WhenIEnterAUsername()
        {
            signUpPage.EnterUsername();
        }
        
        [When(@"I enter an email address")]
        public void WhenIEnterAnEmailAddress()
        {
            signUpPage.EnterEmail();
        }
        
        [When(@"I enter a password")]
        public void WhenIEnterAPassword()
        {
            signUpPage.EnterPassword();
        }


        [When(@"I click on registration page sign up")]
        public void WhenIClickOnRegistrationPageSignUp()
        {
            signUpPage.ClickOnSignUp1();
        }


        [Then(@"My account should be created sucessfully")]
        public void ThenMyAccountShouldBeCreatedSucessfully()
        {
            signUpPage.IsHomeDisplayed();
        }
    }
}
