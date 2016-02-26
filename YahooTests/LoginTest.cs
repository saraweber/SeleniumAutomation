using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahooLoginAutomation;



namespace YahooTests
{
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("username").WithPassword("password").Login();

            Assert.IsTrue(EmailPage.IsAt, "Failed to Login.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close(); 
        }
    }
}
