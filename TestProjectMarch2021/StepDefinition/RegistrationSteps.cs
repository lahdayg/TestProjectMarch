using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectMarch2021.PageObject;

namespace TestProjectMarch2021.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();

        }







        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();

        }
        
        [Given(@"I click on sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            Thread.Sleep(5000);
            registrationPage.ClickOnSignUpButton();
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
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Then(@"I should be able to sign up succefully")]
        public void ThenIShouldBeAbleToSignUpSuccefully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsGlobalFeedDisplayed);
        }
    }
}
