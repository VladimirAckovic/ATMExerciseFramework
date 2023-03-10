using ATMExerciseFramework.Helpers;
using ATMExerciseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ATMExerciseFramework.Steps
{
    [Binding]
    public class AuthenticationSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [StepDefinition(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.loginLink);
        }
        
        [StepDefinition(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.loginEmail, TestConstants.Username);
            ut.EnterTextInElement(ap.loginPassword, TestConstants.Password);
        }
        
        [StepDefinition(@"user submit login form")]
        public void WhenUserSubmitLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.loginBtn);
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Assert.True(ut.ElementIsDisplayed(hp.deleteAcc), "User is NOT logged in");
        }

        [Given(@"enters '(.*)' name and valid email address")]
        public void GivenEntersNameAndValidEmailAddress(string name)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.name, name);
            ut.EnterTextInElement(ap.singupEmail, ut.GenerateRandomEmail());
        }

        [Given(@"user clicks on SignUp button")]
        public void GivenUserClicksOnSignUpButton()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.singupBtn);
        }

        [StepDefinition(@"user fills in all required fields")]
        public void WhenUserFillsInAllRequiredFields()
        {
            SignupPage sp = new SignupPage(Driver);
            ut.EnterTextInElement(sp.password, TestConstants.Password);
            ut.EnterTextInElement(sp.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sp.lastName, TestConstants.LastName);
            ut.EnterTextInElement(sp.address, TestConstants.Address);
            ut.DropdownSelect(sp.country, TestConstants.Country);
            ut.EnterTextInElement(sp.state, TestConstants.State);
            ut.EnterTextInElement(sp.city, TestConstants.City);
            ut.EnterTextInElement(sp.zipcode, TestConstants.ZipCode);
            ut.EnterTextInElement(sp.mobile, TestConstants.Phone);
        }

        [StepDefinition(@"submits the signup form")]
        public void WhenSubmitsTheSignupForm()
        {
            SignupPage sp = new SignupPage(Driver);
            //Driver.FindElement(sp.form).Submit();
            ut.ClickOnElement(sp.createAcc);
        }

        [StepDefinition(@"user will get '(.*)' success message")]
        public void ThenUserWillGetSuccessMessage(string message)
        {
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            Assert.True(ut.TextPresentInElement(message), "User did NOT get expected success message");
            ut.ClickOnElement(acp.continueBtn);
        }

        [When(@"user clicks on DeleteAccount butoon")]
        public void WhenUserClicksOnDeleteAccountButoon()
        {
            HeaderPage hp = new HeaderPage(Driver);
            ut.ClickOnElement(hp.deleteAcc);
        }

        [Then(@"account will be deleted with message '(.*)'")]
        public void ThenAccountWillBeDeletedWithMessage(string message)
        {
            DeleteAccountPage dap = new DeleteAccountPage(Driver);
            Assert.True(ut.TextPresentInElement(message), "Account has not be deleted");
            ut.ClickOnElement(dap.contDeleteAccount);
        }
    }
}
