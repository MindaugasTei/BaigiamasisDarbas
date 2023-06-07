using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
	public class AddToCartTest : BaseTest
	{
        [Test]
        public void AddToCart()
        {
            ProductPage.Open();
            ProductPage.AddProductToCart();
            CartPage.GoToCart();
            Assert.IsTrue(CartPage.IsProductAddedToCart());
        }
    }
}