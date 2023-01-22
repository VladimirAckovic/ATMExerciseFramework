using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class PaymentPage
    {
        readonly IWebDriver _driver;
        public By payment = By.ClassName("step-one");
        public By nameOnCard = By.Name("name_on_card");
        public By cardNumber = By.ClassName("card-number");
        public By cardCVC = By.ClassName("card-cvc");
        public By expiration = By.ClassName("card-expiry-month");
        public By year = By.ClassName("card-expiry-year");
        public By payAndConfirmOrder = By.ClassName("submit-button");
        public PaymentPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(payment));
        }
    }
}
