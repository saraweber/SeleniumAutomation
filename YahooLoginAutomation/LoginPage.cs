using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace YahooLoginAutomation
{
    public class LoginPage
    {

        public static void GoTo()
        {

           Driver.Instance.Navigate().GoToUrl("https://login.yahoo.com/config/login?.src=fpctx&.intl=us&.lang=en-US&.done=https%3A%2F%2Fwww.yahoo.com");
           
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public class LoginCommand
        {
            private readonly string userName;
            private string password;

            public LoginCommand (string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Id("login-username"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id("login-passwd"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.Id("login-signin"));
                loginButton.Click();
            }
        }
    }
}
