using ATMExerciseFramework.Helpers;
using ATMExerciseFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace ATMExerciseFramework.Steps
{
    [Binding]
    public class CheckOutSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [When(@"user click on Proceed To Chekout button")]
        public void WhenUserClickOnProceedToChekoutButton()
        {
            ProceedToCheckoutPage ptc = new ProceedToCheckoutPage(Driver);
            ut.ClickOnElement(ptc.proceedToCheckoutBtn);
        }
        
        [When(@"enter message about order")]
        public void WhenEnterMessageAboutOrder()
        {
            //CheckoutPage cp = new CheckoutPage(Driver);
        }
        
        [When(@"user click on Place Order button")]
        public void WhenUserClickOnPlaceOrderButton()
        {
            CheckoutPage cp = new CheckoutPage(Driver);
            ut.ClickOnElement(cp.placeOrderBtn);
        }
        
        [When(@"user enter valid Visa cart data")]
        public void WhenUserEnterValidVisaCartData()
        {
            PaymentPage pp = new PaymentPage(Driver);
            ut.EnterTextInElement(pp.nameOnCard, TestConstants.FirstName + " " + TestConstants.LastName);
            ut.EnterTextInElement(pp.cardNumber, TestConstants.cardNumber);
            ut.EnterTextInElement(pp.cardCVC, TestConstants.CVC);
            ut.EnterTextInElement(pp.expiration, TestConstants.Expiration);
            ut.EnterTextInElement(pp.year, TestConstants.Year);
        }
        
        [When(@"user click on Pay and Confirm Order button")]
        public void WhenUserClickOnPayAndConfirmOrderButton()
        {
            PaymentPage pp = new PaymentPage(Driver);
            ut.ClickOnElement(pp.payAndConfirmOrder);
        }
    }
}
