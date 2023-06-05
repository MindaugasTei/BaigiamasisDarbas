using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    public class ClientRegistrationTest : BaseTest
    {
        [Test]
        public void ClientRegistration()
        {
            RegistrationPage.Open();
            RegistrationPage.FillRegistrationForm("Vardenis", "Pavardenis", "VardenisP@example.com", "1234567890", "password123");
            RegistrationPage.AcceptTermsAndConditions();
            RegistrationPage.ClickRegistrationButton();
            Assert.IsTrue(RegistrationPage.IsRegistrationSuccessful());
        }
    }
}