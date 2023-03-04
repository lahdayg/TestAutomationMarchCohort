using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationNewCohort.Utilities;

namespace TestAutomationNewCohort.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));




        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("Dejavu000567");
        }

        public void EnterEmail()
        {
            Email.SendKeys("demo233003545@example.com");
        }

        public void EnterPasssword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public void NavigateToWebsite() 
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }


    }
}
