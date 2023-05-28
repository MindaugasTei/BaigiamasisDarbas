using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public RegistrationPage NavigateToRegistrationPage()
        {
           
         driver.Navigate().GoToUrl("https://www.lemona.lt/register");

            return new RegistrationPage(driver);
        }

        public LoginPage NavigateToLoginPage()
        {
           
           driver.Navigate().GoToUrl("https://www.lemona.lt/login");

            return new LoginPage(driver);
        }

        public ProductPage NavigateToProductPage()
        {
            
           driver.Navigate().GoToUrl("https://www.lemona.lt/visos-kategorijos");

            return new ProductPage(driver);
        }

       
    }

}


