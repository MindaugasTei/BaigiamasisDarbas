using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
           
                this.driver = driver;
            }

            public void RemoveProductFromCart()
            {
            By removeButtonLocator = By.XPath("//*[@id=\"root\"]/main/div/div/div[2]/div[2]/div/div/div[2]/div[2]/button[2]");

        }


    }
}

