using OpenQA.Selenium;

namespace Framework
{
    public class Common
    {
        private static IWebElement GetElement(By locator)
        {
            return Driver.GetDriver().FindElement(locator);
        }

        internal static void ClickElement(By locator)
        {
            GetElement(locator).Click();
        }

        internal static void SetText(By locator, string text)
        {
            GetElement(locator).SendKeys(text);
        }

        internal static string GetText(By locator)
        {
            return GetElement(locator).Text;
        }
    }
}

