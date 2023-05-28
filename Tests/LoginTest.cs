using System;
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class ClientLoginTest
    {
        [Test]
        public void ClientLogin()
        {
            Framework.Pages.HomePage homePage = new Framework.Pages.HomePage(driver);
            Framework.Pages.LoginPage loginPage = homePage.NavigateToLoginPage();
            loginPage.FillLoginForm("johndoe@example.com", "password123");
            loginPage.ClickLoginButton();

            Assert.IsTrue(loginPage.IsLoginSuccessful());
        }

    }
}

