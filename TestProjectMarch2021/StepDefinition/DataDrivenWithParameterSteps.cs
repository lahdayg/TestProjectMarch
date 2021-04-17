using System;
using TechTalk.SpecFlow;
using TestProjectMarch2021.PageObject;

namespace TestProjectMarch2021.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();

        }




        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);

        }
        
        [Given(@"I enter Username ""(.*)""")]
        public void GivenIEnterUsername(string Username)
        {
            dataDrivenWithParameterPage.EnterUsername(Username);
        }
        
        [Given(@"I enter Email ""(.*)""")]
        public void GivenIEnterEmail(string Email)
        {
            dataDrivenWithParameterPage.EnterEmail(Email);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string Password)
        {
            dataDrivenWithParameterPage.EnterPassword(Password);
        }
    }
}
