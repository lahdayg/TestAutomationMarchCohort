using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationNewCohort.Utilities;

namespace TestAutomationNewCohort.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));





        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPasssword(string password)
        {
            Password.SendKeys(password);
        }

        public void NavigateToWebsite(string urltext)
        {
            driver.Navigate().GoToUrl(urltext);
        }








    }
}
