using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddProductToCart()
        {
            
            By addToCartButtonLocator = By.XPath("//*[@id=\"root\"]/main/div[1]/div/div/div[1]/div[3]/div[1]/div[3]/div/button[1]");

           
            Common.ClickElement(addToCartButtonLocator);
        }
    }

        public CartPage GoToCart()
        {
        
      driver.Navigate().GoToUrl("https://www.lemona.lt/cart");

        return new CartPage(driver);
        }

        public void ApplyProductFilter(string filter)
        {
       
        string filterCheckboxLocator = $"//*[@id=\"desk-categories-{filter}\"]";
        Common.ClickElement(By.XPath(filterCheckboxLocator));
    }

        public bool AreFiltersApplied()
        {
            
            return true;
        }

       
    }

}

