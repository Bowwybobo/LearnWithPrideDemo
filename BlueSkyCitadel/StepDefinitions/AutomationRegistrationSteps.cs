using BlueSkyCitadel.PageObject;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.StepDefinitions
{
    [Binding]
    public class AutomationRegistrationSteps

    {
        AutomationRegistrationPage automationRegistrationPage;


        public AutomationRegistrationSteps()
        {
            automationRegistrationPage = new AutomationRegistrationPage();
        }


        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
           automationRegistrationPage.NavigateToWebsite(url);
        }
        
        [When(@"I Enter a value in the single line text ""(.*)""")]
        public void WhenIEnterAValueInTheSingleLineText(string username)
        {
            automationRegistrationPage.EnterValueSingleLineText(username);
        }
        
        [When(@"I Select a value from the select drop down")]
        public void WhenISelectAValueFromTheSelectDropDown()
        {
            automationRegistrationPage.SelectTwoFromDropDownMenu();
        }
        
        [When(@"I Enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string email)
        {
            automationRegistrationPage.EnterEmail(email);
        }

        [When(@"I Enter a password ""(.*)""")]
        public void WhenIEnterAPassword(string password)
        {
            automationRegistrationPage.EnterPassword(password);
        }



        [When(@"I Select multiple numbers from the multi select")]
        public void WhenISelectMultipleNumbersFromTheMultiSelect()
        {
            automationRegistrationPage.SelectMultiSelector();
        }
        
        [When(@"I Choose a radio list")]
        public void WhenIChooseARadioList()
        {
            automationRegistrationPage.SelectTwoFromRadioList();
        }
        
        [When(@"I Tick the checkbox")]
        public void WhenITickTheCheckbox()
        {
            automationRegistrationPage.SelectThreeFromCheckBox();
        }
        
        [When(@"I Select a country")]
        public void WhenISelectACountry()
        {
            automationRegistrationPage.SelectCountry();
        }
        
        [When(@"I Enter a date ""(.*)""")]
        public void WhenIEnterADate(string date)
        {
            automationRegistrationPage.EnterDate(date);
        }
        
        [When(@"I Check the single check box")]
        public void WhenICheckTheSingleCheckBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Enter words in the paragraph text ""(.*)""")]
        public void WhenIEnterWordsInTheParagraphText(string text)
        {
            automationRegistrationPage.EnterTextInParagraph(text);
        }
        
        [When(@"I Click submit")]
        public void WhenIClickSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
