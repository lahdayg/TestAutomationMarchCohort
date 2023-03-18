using System;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }




        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }

        [Given(@"I bought (.*) pens")]
        public void GivenIBoughtPens(int p0)
        {
            throw new PendingStepException();
        }


        [Given(@"I enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I enter my Email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }

        [Given(@"I enter my password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPasssword(password);
        }

        [Given(@"I select skills from the dropdown arrow")]
        public void GivenISelectSkillsFromTheDropdownArrow()
        {
            dataDrivenWithParameterPage.SelectFromDropdown();
        }

    }
}
