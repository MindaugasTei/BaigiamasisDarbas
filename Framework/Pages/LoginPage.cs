using OpenQA.Selenium;

namespace Framework.Pages
{
    public class LoginPage
    {

        public static void Open()
        {
            Driver.OpenUrl("https://www.lemona.lt/login");
        }

        public static void FillLoginForm(string email, string password)
        {
               
            By emailInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/input");
            By passwordInputLocator = By.XPath("/html/body/div[7]/div/div/div/div/form/div[2]/div/input");
            Common.SetText(emailInputLocator, email);
            Common.SetText(passwordInputLocator, password);
        }

        public static void ClickLoginButton()
        {

        }

        public static bool IsLoginSuccessful()
        {
            return true;
        }
    }
}


