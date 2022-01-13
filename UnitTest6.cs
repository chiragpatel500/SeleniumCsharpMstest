using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace JDC
{
    [TestClass]
    public class SeleniumControls__01
    {
        [TestMethod]
        public void WorkingWithDropDownMenu()
        {
            IWebDriver driver = new ChromeDriver();//init chrome driver
            driver.Url = "https://demoqa.com/select-menu"; // call the url

            var element = driver.FindElement(By.Id("oldSelectMenu")); //select/find element and asign to a string.

            var selectDropDown = new SelectElement(element); // pass the var to another var as newelement.

            //selectDropDown.SelectByText("Green");
           // selectDropDown.SelectByValue("3"); // call the reuired value. 
            selectDropDown.SelectByIndex(5);
        }
    }
}
