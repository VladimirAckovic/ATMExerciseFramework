using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMExerciseFramework.Pages
{
    class PDPPage
    {
        readonly IWebDriver _driver;
        public By productDetailsPage = By.ClassName("padding-right");
        public By AddtoCartBtn = By.ClassName("cart");
        //public By continueBtn = By.ClassName("btn-block");
        public By viewCartLink = By.CssSelector(".text-center [href='/view_cart']");
        public By prodName = By.XPath("//*[@class='product-information']//h2");

        public PDPPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productDetailsPage));
        }
    }
}
