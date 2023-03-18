using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationNewCohort.Utilities;

namespace TestAutomationNewCohort.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement Skills => driver.FindElement(By.CssSelector("select[id='Skills']"));





        public void EnterUsername(string username)
        {
            //Username.SendKeys(username);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
        }

        public void EnterEmail(string email)
        {
            //Email.SendKeys(email);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt + "@gmail.com");
        }

        public void EnterPasssword(string password)
        {
            Password.SendKeys(password);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SelectFromDropdown()
        {
            SelectElement select = new SelectElement(Skills);
            select.SelectByIndex(2);
        }




    }
}
