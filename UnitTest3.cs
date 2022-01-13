using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace JDC
{
    [TestClass]
    public class UnitTest3
    {
        //Parallel execution with selenium .
        [TestMethod]
        public void ParallelExecutionWithSelenium__01()
        {
            IWebDriver driver = new ChromeDriver();//initialise chrome driver
          

            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("Pateltester");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Id("password")).SendKeys("Pateltester");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.Id("login")).Click();//ask driver to find element by classname and press click to login.

          
            driver.Close(); //Close the driver
        }


        [TestMethod]
        public void ParallelExecutionWithSelenium__02()
        {
            IWebDriver driver = new ChromeDriver();//initialise chrome driver


            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("tester");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Id("password")).SendKeys("tester");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.Id("login")).Click();//ask driver to find element by classname and press click to login.


            driver.Close(); //Close the driver
        }


        [TestMethod]
        public void ParallelExecutionWithSelenium__03()
        {
            IWebDriver driver = new ChromeDriver();//initialise chrome driver


            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Id("password")).SendKeys("");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.Id("login")).Click();//ask driver to find element by classname and press click to login.


            driver.Close(); //Close the driver
        }

    }
   
   
}
