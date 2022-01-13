using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JDC
{
    [TestClass]
    public class SeleniumControls
    { // working with diffrent browsers.
        [TestMethod]
        public void WorkingWithDifferentBrowserWindows()
        {
            IWebDriver driver = new ChromeDriver(); //init the driver
            driver.Url = "https://demoqa.com/browser-windows"; // call the url

            driver.FindElement(By.Id("windowButton")).Click(); // define button to be cliked

            var handlers = driver.WindowHandles; // define the handler

            driver.SwitchTo().Window(handlers[1]); //swtich to Child
            string childWindowText = driver.FindElement(By.Id("sampleHeading")).Text;

            driver.SwitchTo().Window(handlers[0]); // switch to parent
            string ParentWindowText = driver.FindElement(By.ClassName("main-header")).Text;

            driver.Close();
            driver.Quit();

        }
    }
}
