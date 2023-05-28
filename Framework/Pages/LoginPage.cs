using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillLoginForm(string email, string password)
        {
           
            {
               
                By emailInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/input");
                By passwordInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/div[2]/div/input");
                Common.SetText(emailInputLocator, email);
                Common.SetText(passwordInputLocator, password);
            }

        public void ClickLoginButton()
        {
                
                By emailInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/input");
                By passwordInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/div[2]/div/input");
                Common.SetText(emailInputLocator, email);
                Common.SetText(passwordInputLocator, password);
            }
        }

    
    }

}


