using DemoProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement helloSignIn => driver.FindElement(By.XPath("//*[@id='nav-link-accountList']/div/span"));

        IWebElement createYourAmazonAccount1 => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.CssSelector("#ap_customer_name"));

        IWebElement email => driver.FindElement(By.XPath("//*[@id='ap_email']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='ap_password']"));

        IWebElement reEnterPassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement createYourAmazonAccount2 => driver.FindElement(By.XPath("//*[@id='continue']"));

        IWebElement confirmHelloDemo => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));




        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void ClickOnCreateYourAmazonAccount1()
        {
            createYourAmazonAccount1.Click();
        }

        public void EnterYourName()
        {
            yourName.SendKeys("Demo");
        }

        public void EnterEmail()
        {
            email.SendKeys("info@learnwithpride.co.uk");
        }

        public void EnterPassword()
        {
            password.SendKeys("Olutosin87");
        }

        public void ReEnterPassword()
        {
            reEnterPassword.SendKeys("Olutosin87");
        }

        public void ClickOnCreateYourAmazonAccount2()
        {
            createYourAmazonAccount2.Click();
        }

        public bool IsHelloDemoDisplayed()
        {
            return confirmHelloDemo.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
        }

    }


}
