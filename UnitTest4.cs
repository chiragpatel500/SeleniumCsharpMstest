using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JDC
{
    [TestClass]
    public class UnitTest4
    {
        //Headless execution
        [TestMethod]
        public void TestMethod1()
        {
            var chromeOptions = new ChromeOptions(); //define chromeoptions
            chromeOptions.AddArguments("Headless"); // add argument for headless exceution

            IWebDriver driver = new ChromeDriver(chromeOptions);//initialise chrome driver for headless excution using chromwoptions.


            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("Pateltester");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Id("password")).SendKeys("Pateltester");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.Id("login")).Click();//ask driver to find element by classname and press click to login.


            driver.Close(); //Close the driver
        }
    }
}
