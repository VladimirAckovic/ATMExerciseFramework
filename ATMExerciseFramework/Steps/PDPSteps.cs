using ATMExerciseFramework.Helpers;
using ATMExerciseFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ATMExerciseFramework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.productsLink);
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string term)
        {
            PLPPage plp = new PLPPage(Driver);
            ut.EnterTextInElement(plp.searchProduct, term);
            ut.ClickOnElement(plp.magnifierBtn);
        }
        
        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
            SearchedProductPage spp = new SearchedProductPage(Driver);
            ut.ClickOnElement(spp.viewProductBtn);
        }
        
        [When(@"user click on Add to Cart button")]
        public void WhenUserClickOnAddToCartButton()
        {
            PDPPage pdp = new PDPPage(Driver);
            productData.ProductName = ut.ReturnTextFromElement(pdp.prodName);
            ut.ClickOnElement(pdp.AddtoCartBtn);
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            PDPPage pdp = new PDPPage(Driver);
            //ut.ClickOnElement(pdp.continueBtn);
            ut.ClickOnElement(pdp.viewCartLink);
        }
        
        [Then(@"shopping cart will be displayed with expected product inside")]
        public void ThenShoppingCartWillBeDisplayedWithProductInside()
        {
            ShoppingCartPage scp = new ShoppingCartPage(Driver);
            Assert.True(ut.TextPresentInElement(productData.ProductName), "Cart is empty!");
        }
    }
}
