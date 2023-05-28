using System;
using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
	public class AddToCartTest
	{
        [Test]
        public void AddToCart()
        {
            Framework.Pages.HomePage homePage = new HomePage(driver);
            Framework.Pages.ProductPage productPage = homePage.NavigateToProductPage();
            productPage.AddProductToCart();
            Framework.Pages.CartPage cartPage = productPage.GoToCart();

           
            Assert.IsTrue(cartPage.IsProductAddedToCart());
        }

    }
}

