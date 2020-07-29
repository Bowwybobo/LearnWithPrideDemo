using DataDriven.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven.PageObject
{
    class SignUpPage
    {
       public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type = 'password']"));

        IWebElement SignUp => driver.FindElement(By.XPath("//button[@type = 'submit']"));

        IWebElement ConfirmUsernameIsDisplayed => driver.FindElement(By.XPath("//a[@href = '#/@MrNubesco']"));



        public void NavigateToWebsite (string url)
        {
            driver.Navigate().GoToUrl(url);
        }


      
        public void EnterUsename (string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
        }
    
       
        public void EnterEmail (string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt + "@demo.com");
        }


        public void EnterPassword (string password)
        {
            Password.SendKeys(password);
        }


        public void ClickSignUp()
        {
            SignUp.Click();
        }


        public bool IsConfirmUsernameDisplayed()
        {
            return ConfirmUsernameIsDisplayed.Displayed;
        }

        

    }
}
