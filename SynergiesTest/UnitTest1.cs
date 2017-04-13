using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynergiesAutomation;

namespace SynergiesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            JobsearchPage.Go();
            JobsearchPage.ClickACurrentJob();

            JobsPage.FillApplyNowForm("name","last name","N","email@example.com","809-555-555","Bartolome Colon","Santiago de los Caballeros","51000");
            

        }
    }
}
