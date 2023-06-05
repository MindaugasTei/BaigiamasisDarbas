using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    public class ProductFilterTest : BaseTest
    {
        [Test]
        public void ProductFilter()
        {
            ProductPage.Open();
            ProductPage.ApplyProductFilter("Kauno parduotuvė");
            ProductPage.ApplyProductFilter("Energijos šaltiniai");
            Assert.IsTrue(ProductPage.AreFiltersApplied());
        }
    }
}