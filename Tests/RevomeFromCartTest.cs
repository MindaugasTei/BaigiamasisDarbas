using System;
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class RemoveFromCartTest
    {
        [Test]
        public void RemoveFromCart()
        {
            HomePage homePage = new HomePage(driver);
            ProductPage productPage = homePage.NavigateToProductPage();
            productPage.AddProductToCart();
            CartPage cartPage = productPage.GoToCart();
            cartPage.RemoveProductFromCart();

            Assert.IsTrue(cartPage.IsProductRemovedFromCart());
        }

    }
}

