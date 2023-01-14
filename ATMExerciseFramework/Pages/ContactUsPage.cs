using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class ContactUsPage
    {
        readonly IWebDriver _driver;
        public By contactPage = By.Id("contact-page");
        public By name = By.Name("name");
        public By email = By.Name("email");
        public By subject = By.Name("subject");
        public By message = By.Name("message");
        public By form = By.Id("contact-us-form");

        public ContactUsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(contactPage));
        }
    }
}
