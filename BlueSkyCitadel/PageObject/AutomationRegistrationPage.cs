using BlueSkyCitadel.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueSkyCitadel.PageObject
{
    class AutomationRegistrationPage
    {
        public AutomationRegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement SingleLineText => driver.FindElement(By.XPath("//input[@name='nf-field-135']"));

        IWebElement DropDownMenu => driver.FindElement(By.CssSelector("#nf-field-136"));

        IWebElement  Email => driver.FindElement(By.XPath("//*[@id='nf-field-124']"));

        IWebElement  Password => driver.FindElement(By.CssSelector("#nf-field-144"));

        IWebElement MultiSelector => driver.FindElement(By.CssSelector("#nf-field-137 "));


        IWebElement RadioList => driver.FindElement(By.XPath("//*[@id='nf-label-class-field-138-1']"));


        IWebElement CheckBox => driver.FindElement(By.CssSelector("#nf-label-field-139-2"));


        IWebElement Country => driver.FindElement(By.CssSelector("#nf-field-140"));


        IWebElement DatePicker => driver.FindElement(By.XPath("//input[@class='pikaday__display pikaday__display--pikaday ninja-forms-field nf-element datepicker']"));


        IWebElement ParagraphText => driver.FindElement(By.XPath("//*[@id='nf-field-143']"));




        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterValueSingleLineText(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            SingleLineText.SendKeys(username + randomInt);
           // SingleLineText.SendKeys(username);
        }


        public void SelectTwoFromDropDownMenu()
        {
            SelectElement select = new SelectElement(DropDownMenu);
            select.SelectByText("Two");
        }


        public void EnterEmail (string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt + "@yahoo.com");
        }


        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }


        public void SelectMultiSelector()
        {
            SelectElement multiSelector = new SelectElement(MultiSelector);
            multiSelector.SelectByText("Two");
            multiSelector.SelectByValue("three");
        }


        public void SelectTwoFromRadioList()
        {
            RadioList.Click();
        }


        public void SelectThreeFromCheckBox()
        {
            CheckBox.Click();
        }


        public void SelectCountry()
        {
            SelectElement select = new SelectElement(Country);
            select.SelectByValue("AU");
        }


        public void EnterDate(string date)
        {
            DatePicker.SendKeys(date);
        }


        public void EnterTextInParagraph(string text)
        {
            Thread.Sleep(5000);
            ParagraphText.SendKeys(text);
        }



    }
}
