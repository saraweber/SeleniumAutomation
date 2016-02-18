using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace YahooLoginAutomation
{
    public class Class1
    {
        public void Go()
        {
            var driver = new ChromeDriver ();
            driver.Navigate().GoToUrl("https://login.yahoo.com/config/login?.src=fpctx&.intl=us&.lang=en-US&.done=https%3A%2F%2Fwww.yahoo.com");
        }
    }
}
