using System;
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class ProductFilterTest
    {
        [Test]
        public void ProductFilter()
        {
            Framework.Pages.HomePage homePage = new Framework.Pages.HomePage(driver);
            Framework.Pages.ProductPage productPage = homePage.NavigateToProductPage();
            productPage.ApplyProductFilter("Kauno parduotuvė");
            productPage.ApplyProductFilter("Energijos šaltiniai");

            Assert.IsTrue(productPage.AreFiltersApplied());
        }

    }
}

