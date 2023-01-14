using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class PLPPage
    {
        readonly IWebDriver _driver;
        public By productsPage = By.Id("advertisement");
        //public By productsPage = By.ClassName("features_items");
        public By searchProduct = By.Id("search_product");
        public By magnifierBtn = By.Id("submit_search");

        public PLPPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productsPage));
        }
    }
}
