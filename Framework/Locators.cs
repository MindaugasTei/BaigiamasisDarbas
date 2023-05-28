namespace Framework.Pages
{
    internal class Locators
    {
        internal class CookieConsent
        {
            internal static string CookiesAccept = "//*[@id=\"root\"]/div[2]/div/button";
        }

        internal class ClientRegistration
        {
            internal static string NameImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[1]/div[1]/input";
            internal static string LastNameImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[1]/div[2]/input";
            internal static string EmailImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[2]/div[1]/input";
            internal static string PhoneNumberImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[2]/div[2]/input";
            internal static string PasswordImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[2]/div/div[1]/div/input";
            internal static string RePasswordImput = "//*[@id=\"root\"]/main/div[2]/form/fieldset[2]/div/div[2]/div/input";
            internal static string TermsAggrementButton = "//*[@id=\"agreement\"]";
            internal static string RegistrationButton = "//*[@id=\"root\"]/main/div[2]/form/div/div/div/button";
        }

        internal class ClientLogin
        {
            internal static string EmailImput = "/html/body/div[7]/div/div/div/div/form/input";
            internal static string PasswordImput = "/html/body/div[7]/div/div/div/div/form/div[2]/div/input";
            internal static string LoginButton = "/html/body/div[7]/div/div/div/div/form/button[2]";
            
        }

        internal class AddToCart
        {
            internal static string ButtonAddToCart = "//*[@id=\"root\"]/main/div[1]/div/div/div[1]/div[3]/div[1]/div[3]/div/button[1]";
            internal static string ButtLookInCart = "//*[@id=\"root\"]/header/div[2]/div/div[3]/div/div/div[2]/div[4]/a";
            internal static string ButtonBackToHomePage = "//*[@id=\"root\"]/header/div[2]/div/div[1]/a/img";
            
        }

        internal class ProductFilter
        {
            internal static string CheckboxKaunoParduotuve = "//*[@id=\"desk-sources-Kauno parduotuvė\"]";
            internal static string CheckboxEnergijosSaltiniai = "//*[@id=\"desk-categories-Energijos šaltiniai\"]";
            
        }

        internal class RevomeFromCart
        {
            internal static string ButtonAddToCart = "//*[@id=\"root\"]/main/div[1]/div/div/div[1]/div[3]/div[1]/div[3]/div/button[1]";
            internal static string ButtLookInCart = "//*[@id=\"root\"]/header/div[2]/div/div[3]/div/div/div[2]/div[4]/a";
            internal static string ButtomRevomeFromCart = "//*[@id=\"root\"]/main/div/div/div[2]/div[2]/div/div/div[2]/div[2]/button[2]";

        }



    }
}