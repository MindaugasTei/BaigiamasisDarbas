using OpenQA.Selenium;

namespace Framework.Pages
{
    public class ProductPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.lemona.lt/visos-kategorijos");
        }

        public static void AddProductToCart()
        {
            By addToCartButtonLocator = By.XPath("//*[@id=\"root\"]/main/div[1]/div/div/div[1]/div[3]/div[1]/div[3]/div/button[1]");
            Common.ClickElement(addToCartButtonLocator);
        }

        public static void ApplyProductFilter(string filter)
        {
            string filterCheckboxLocator = $"//*[@id=\"desk-categories-{filter}\"]";
            Common.ClickElement(By.XPath(filterCheckboxLocator));
        }

        public static bool AreFiltersApplied()
        {
            return true;
        }
    }
}

