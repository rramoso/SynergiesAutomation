using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergiesAutomation
{
    public class Driver
    {
        private static IWebDriver instance;
       
        public static IWebDriver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChromeDriver();
                }
                return instance;
            }
        }

        public static void ScrollToElement(IWebElement element)
        {
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}
