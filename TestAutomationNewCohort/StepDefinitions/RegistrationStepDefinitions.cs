using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;

        public RegistrationStepDefinitions()
        {
            registrationPage= new RegistrationPage();
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }




        [Given(@"I enter Username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPasssword();
        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
