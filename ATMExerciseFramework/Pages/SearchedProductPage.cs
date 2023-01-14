using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class SearchedProductPage
    {
        readonly IWebDriver _driver;
        public By searchedProductPage = By.ClassName("product-image-wrapper");
        public By viewProductBtn = By.ClassName("fa-plus-square");

        public SearchedProductPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(searchedProductPage));
        }
    }
}
