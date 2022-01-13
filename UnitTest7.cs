using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JDC
{  // POM: PAGE OBJECT MODEL.

    //Test class to call the other classes 
    [TestClass]
    public class TestExecution : BasePage
    {
        LoginPage loginPage = new LoginPage(); //Call Login page 
        SearchPage searchPage = new SearchPage();// call search page
        BasePage basePage = new BasePage(); //call Basepage 


        [TestMethod]
        public void TestCase_01()
        {

            basePage.SeleniumInit();
            loginPage.Login("https://adactinhotelapp.com/HotelAppBuild2/index.php", "Pateltester", "Pateltester");
            searchPage.Search();
        }
    }

    public class LoginPage : BasePage
    {
        public void Login(string url, string user, string pass)
        {
            //IWebDriver driver = new ChromeDriver();
            By usernameTxt = By.Id("username");
            By passwordTxt = By.Id("password");
            By loginBTN = By.Id("login");

            driver.Url = url;
            driver.FindElement(usernameTxt).SendKeys(user);//Ask the driver to findelement using id. use sendkeys to type given data
            driver.FindElement(passwordTxt).SendKeys(pass);//ask driver to findelemnt by using password  &  use sendkeys to to type given data.
            driver.FindElement(loginBTN).Click();//ask driver to find element by classname and press click to login.
        }
    }


    public class SearchPage : BasePage
    {
        public void Search()
        {

        }
    }

    //Base class : init driver : sleniuminit : inherit to all the classes.
    public class BasePage
    {

        public static IWebDriver driver;
        public void SeleniumInit()
        {
            var myDriver = new ChromeDriver();

            driver = myDriver;
        }
    }

}
