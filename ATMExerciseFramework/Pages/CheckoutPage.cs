using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class CheckoutPage
    {
        readonly IWebDriver _driver;
        public By checkoutPage = By.Id("address_delivery");
        public By commentField = By.ClassName("form-control");
        public By placeOrderBtn = By.ClassName("check_out");

        public CheckoutPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(checkoutPage));
        }
    }
}
