using Framework;
using NUnit.Framework;

namespace Tests.BaseTests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
