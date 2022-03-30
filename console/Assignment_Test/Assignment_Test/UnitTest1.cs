using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Assignment_Test
{    
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();            

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void PageTitle_EnterAssignment3_ReturnTrue()
        {
            driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\index.html";
            Assert.AreEqual("Assignment 3", driver.Title);
        }

        [Test]
        public void PageTitle_Assignment3_ReturnTre()
        {
            //driver.Url = "";
            driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\index.html";

            driver.FindElement(By.ClassName("main-card")).Click();
        }

        [TearDown]
        public void Close()
        {
            //driver.Close();
        }
    }
}