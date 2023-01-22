using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class ProceedToCheckoutPage
    {
        readonly IWebDriver _driver;
        public By proceedToCheckout = By.Id("cart_items");
        public By proceedToCheckoutBtn = By.ClassName("check_out");

        public ProceedToCheckoutPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(proceedToCheckout));
        }
    }
}
