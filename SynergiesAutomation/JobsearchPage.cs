using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergiesAutomation
{
    public class JobsearchPage
    {
        public static void Go()
        {
            Driver.Instance.Navigate().GoToUrl("https://synergiesservices.hirecentric.com/jobsearch/");
        }

        public static void ClickACurrentJob()
        {
            var firstJob = Driver.Instance.FindElement(By.ClassName("job-info"));
            Driver.ScrollToElement(firstJob);

            firstJob.Click();

        }

        

        public static void Close()
        {
            Driver.Instance.Close();
        }
    }
}
