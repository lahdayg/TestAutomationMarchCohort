using System;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{
    [Binding]
    public class DataDrivenWithExampleStepDefinitions
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleStepDefinitions()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }






        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string urltext)
        {
            dataDrivenWithExamplePage.NavigateToWebsite(urltext);
        }

        [Given(@"I enter Username text ""([^""]*)""")]
        public void GivenIEnterUsernameText(string username)
        {
            dataDrivenWithExamplePage.EnterUsername(username);
        }

        [Given(@"I enter Email text ""([^""]*)""")]
        public void GivenIEnterEmailText(string email)
        {
            dataDrivenWithExamplePage.EnterEmail(email);
        }

        [Given(@"I enter password text ""([^""]*)""")]
        public void GivenIEnterPasswordText(string password)
        {
            dataDrivenWithExamplePage.EnterPasssword(password);
        }
    }
}
