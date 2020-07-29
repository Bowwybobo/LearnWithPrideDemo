using MyFirstProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PageObject
{
    class SignUpPage
    {
        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("//a[@ui-sref = 'app.register']"));

        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type = 'password']"));

        IWebElement SignUp1 => driver.FindElement(By.XPath("//button[@type = 'submit']"));

        IWebElement ConfirmHomeIsDisplayed => driver.FindElement(By.XPath("//a[@href = '#/@Bowwybobo']"));




        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io");
        }


        public void ClickOnSignUp()
        {
            SignUp.Click();
        }


        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys("Bowwybobo" + randomInt);
        }


        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys("bowale" + randomInt + "@demo.com");
        }


        public void EnterPassword()
        {
            Password.SendKeys("Olutosin87");
        }


        public void ClickOnSignUp1()
        {
            SignUp1.Click();
        }


        public bool IsHomeDisplayed()
        {
            return ConfirmHomeIsDisplayed.Displayed;
        }






    }

}
