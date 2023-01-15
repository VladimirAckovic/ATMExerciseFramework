using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class DeleteAccountPage
    {
        readonly IWebDriver _driver;
        public By deletePage = By.CssSelector(".title[data-qa='account-deleted']");
        public By contDeleteAccount = By.ClassName("btn-primary");

        public DeleteAccountPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(deletePage));
        }
    }
}
