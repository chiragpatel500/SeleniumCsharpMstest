using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JDC
{

    //postive and negative test cases
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Login"), TestCategory("Positive")]
        public void LoginWithValidUserNameValidPassword()
        {

            IWebDriver driver = new ChromeDriver();//initialise chrome driver
            driver.Manage().Window.Maximize(); //maximise the driver while opening.

            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("Pateltester");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Name("password")).SendKeys("Pateltester");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.ClassName("login_button")).Click();//ask driver to find element by classname and press click to login.

            //if the test is succesful -Ask driver to find a certian text and assign to a string for  this testcase.
            string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;

            //validate: when expected and actual matches
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText, "Assert Failed: Login not performed");
            driver.Close(); //Close the driver
        }

        [TestMethod]
        [TestCategory("Login"), TestCategory("Negative")]
        public void LoginWithInValidUserNameInValidPassword()
        {

            IWebDriver driver = new ChromeDriver();//initialise chrome driver
            driver.Manage().Window.Maximize(); //maximise the driver while opening.

            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys("jtest");//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Name("password")).SendKeys("jtest");//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.ClassName("login_button")).Click();//ask driver to find element by classname and press click to login.

            //if the test fails -Ask driver to find a certian text and assign to a string for  this testcase.
            string actualText = driver.FindElement(By.ClassName("auth_error")).Text;

            //validate: Neagtive assertion  = when expected and actualText matches. test will be passed. 
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText, "Assert Failed: Login not performed");
            driver.Close(); //Close the driver
        }


        //How to use DataRow to pass in mutiple test cases for the same test class.
        [TestMethod]
        [DataRow("Pateltester", "Pateltester", "welcome_menu", "Welcome to Adactin Group of Hotels")]
        [DataRow("jtester", "jtester", "auth_error", "Invalid Login details or Your Password might have expired. Click here to reset your password")]
        public void TestCase_003(string username, string password, string locator, string expectedMessage)
        {

            IWebDriver driver = new ChromeDriver();//initialise chrome driver
            driver.Manage().Window.Maximize(); //maximise the driver while opening.

            driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";// open this url into the maximised browser
            driver.FindElement(By.Id("username")).SendKeys(username);//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(By.Name("password")).SendKeys(password);//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(By.ClassName("login_button")).Click();//ask driver to find element by classname and press click to login.

            //if the test is succesful -Ask driver to find a certian text and assign to a string for  this testcase.
            string actualText = driver.FindElement(By.ClassName(locator)).Text;

            //validate:
            Assert.AreEqual(expectedMessage, actualText, "Assert Failed");
            driver.Close(); //Close the driver
        }
    }
}



