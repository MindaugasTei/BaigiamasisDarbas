using OpenQA.Selenium;

namespace Framework.Pages
{
    public class CartPage
    {
        public static void RemoveProductFromCart()
        {
            By removeButtonLocator = By.XPath("//*[@id=\"root\"]/main/div/div/div[2]/div[2]/div/div/div[2]/div[2]/button[2]");
        }

        public static void GoToCart()
        {
            Driver.OpenUrl("https://www.lemona.lt/cart");
        }

        public static bool IsProductAddedToCart()
        {
            return true;
        }

        public static bool? IsProductRemovedFromCart()
        {
            return true;
        }
    }
}

