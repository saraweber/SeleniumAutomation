using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace YahooLoginAutomation
{
    public class EmailPage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Trending Now";
                return false;
            }
        }
    }
}
