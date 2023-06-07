using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    public class RemoveFromCartTest : BaseTest
    {
        [Test]
        public void RemoveFromCart()
        {
            ProductPage.Open();
            ProductPage.AddProductToCart();
            CartPage.GoToCart();
            CartPage.RemoveProductFromCart();
            Assert.IsTrue(CartPage.IsProductRemovedFromCart());
        }
    }
}