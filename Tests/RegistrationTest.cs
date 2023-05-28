using System;
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class ClientRegistrationTest
    {
        [Test]
        public void ClientRegistration()
        {
            HomePage homePage = new HomePage(driver);
            RegistrationPage registrationPage = homePage.NavigateToRegistrationPage();
            registrationPage.FillRegistrationForm("Vardenis", "Pavardenis", "VardenisP@example.com", "1234567890", "password123");
            registrationPage.AcceptTermsAndConditions();
            registrationPage.ClickRegistrationButton();

          
            Assert.IsTrue(registrationPage.IsRegistrationSuccessful());
        }

    }
}

