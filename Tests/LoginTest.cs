using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    public class ClientLoginTest : BaseTest
    {
        [Test]
        public void ClientLogin()
        {
            LoginPage.Open();
            LoginPage.FillLoginForm("johndoe@example.com", "password123");
            LoginPage.ClickLoginButton();
            Assert.IsTrue(LoginPage.IsLoginSuccessful());
        }
    }
}