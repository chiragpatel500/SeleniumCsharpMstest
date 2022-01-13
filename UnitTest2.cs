using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JDC
{  [DoNotParallelize]
        [TestClass]
        public class UnitTest2
        {
            #region Initializations and Cleanups

            public TestContext instance;
            public TestContext TestContext
            {
                set { instance = value; }
                get { return instance; }
            }

            [AssemblyInitialize]
            public static void AssemblyInit(TestContext context)
            {
                // MessageBox.Show("Assembly Initialization");
            }

            [AssemblyCleanup]
            public static void AssemblyCleanup()
            {
                // MessageBox.Show("Assembly CleanUp");
            }

            [ClassInitialize]
            public static void ClassInit(TestContext context)
            {
                // MessageBox.Show("Class Initialization");
            }

            [ClassCleanup]
            public static void ClassCleanup()
            {
                //  MessageBox.Show("Class CleanUp");
            }


            [TestInitialize]
            public void TestInit()
            {
                // MessageBox.Show("Test Initialization");
            }

            [TestCleanup]
            public void TestCleanup()
            {
                // MessageBox.Show("Test CleanUp");
            }

            #endregion

            [TestMethod]
            //connecting external data source. 
            //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"Data.xml", "Login", DataAccessMethod.Sequential)]
            public void TestCase_01()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/index.php";

                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string message = TestContext.DataRow["message"].ToString();
                string locator = TestContext.DataRow["locator"].ToString();

                driver.FindElement(By.Id("username")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("login")).Click();

                string actualMessage = driver.FindElement(By.ClassName(locator)).Text;
                Assert.AreEqual(message, actualMessage, "Assert Failed");

                driver.Close();
            }
        }
    

}
